using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace zd_2_Gurina
{
    public partial class Form1 : Form
    {
        private PhoneBook phoneBook = new PhoneBook(); //Объект класса PhoneBook
        private string fileName = ""; //Название файла
        public Form1()
        {
            InitializeComponent();
        }

        //Обновление таблицы
        private void UpdateDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = phoneBook.GetAllContacts();
        }

        private void добавлениеКонтактаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text.Trim();
                string phone = textBox2.Text.Trim();

                phoneBook.AddContact(new Contact(name, phone));
                UpdateDataGrid();
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void удалениеКонтактаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var contact = dataGridView1.SelectedRows[0].DataBoundItem as Contact;
                phoneBook.RemoveContact(contact.Name);
                UpdateDataGrid();
                MessageBox.Show("Строка удалена!");
            }
            else
            {
                MessageBox.Show("Необходимо выбрать строку!");
                return;
            }
        }

        private void поискКонтактаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searsh = textBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(searsh))
            {
                MessageBox.Show("Введите имя или номер для поиска контакта");
                return;
            }

            if (phoneBook.SearchContact(searsh).Count == 0)
            {
                MessageBox.Show("Нет данного контакта", "Ошибка");
                return;
            }

            var result = phoneBook.SearchContact(searsh);
            string res = "";
            foreach (var r in result)
            {
                res += r.ToString() + "\n";
            }
            MessageBox.Show(res);           
        }

        private void показатьВсеКонтактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void сохранитьКонтактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = textBox4.Text.Trim();
            if (!string.IsNullOrWhiteSpace(fileName))
            {              
                PhoneBookLoader.Save(phoneBook, fileName);
                MessageBox.Show("Файл сохранен", "Успех");
            }
            else
            {
                MessageBox.Show("Укажите название файла");
                return;
            }
        }

        private void выгрузитьКонтактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = textBox4.Text.Trim();
            if (!string.IsNullOrWhiteSpace(fileName))
            {
                PhoneBookLoader.Load(phoneBook, fileName);
                UpdateDataGrid();
                MessageBox.Show("Файл выгружен", "Успех");
            }
            else
            {
                MessageBox.Show("Укажите название файла");
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (phoneBook != null)
                {
                    phoneBook.RemoveAllContacts();
                    UpdateDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
