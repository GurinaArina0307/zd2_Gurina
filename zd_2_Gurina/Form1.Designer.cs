
namespace zd_2_Gurina
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавлениеКонтактаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеКонтактаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискКонтактаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВсеКонтактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКонтактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьКонтактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(310, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 26);
            this.textBox3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(380, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Поиск контактов";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(16, 417);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 36);
            this.button7.TabIndex = 21;
            this.button7.Text = "Выход";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(610, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(328, 364);
            this.dataGridView1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(16, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 26);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(16, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 26);
            this.textBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Введите телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введите имя";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеКонтактаToolStripMenuItem,
            this.удалениеКонтактаToolStripMenuItem,
            this.поискКонтактаToolStripMenuItem,
            this.показатьВсеКонтактыToolStripMenuItem,
            this.сохранитьКонтактыToolStripMenuItem,
            this.выгрузитьКонтактыToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 27);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавлениеКонтактаToolStripMenuItem
            // 
            this.добавлениеКонтактаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.добавлениеКонтактаToolStripMenuItem.Name = "добавлениеКонтактаToolStripMenuItem";
            this.добавлениеКонтактаToolStripMenuItem.Size = new System.Drawing.Size(158, 23);
            this.добавлениеКонтактаToolStripMenuItem.Text = "Добавление контакта";
            this.добавлениеКонтактаToolStripMenuItem.Click += new System.EventHandler(this.добавлениеКонтактаToolStripMenuItem_Click);
            // 
            // удалениеКонтактаToolStripMenuItem
            // 
            this.удалениеКонтактаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.удалениеКонтактаToolStripMenuItem.Name = "удалениеКонтактаToolStripMenuItem";
            this.удалениеКонтактаToolStripMenuItem.Size = new System.Drawing.Size(141, 23);
            this.удалениеКонтактаToolStripMenuItem.Text = "Удаление контакта";
            this.удалениеКонтактаToolStripMenuItem.Click += new System.EventHandler(this.удалениеКонтактаToolStripMenuItem_Click);
            // 
            // поискКонтактаToolStripMenuItem
            // 
            this.поискКонтактаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.поискКонтактаToolStripMenuItem.Name = "поискКонтактаToolStripMenuItem";
            this.поискКонтактаToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.поискКонтактаToolStripMenuItem.Text = "Поиск контакта";
            this.поискКонтактаToolStripMenuItem.Click += new System.EventHandler(this.поискКонтактаToolStripMenuItem_Click);
            // 
            // показатьВсеКонтактыToolStripMenuItem
            // 
            this.показатьВсеКонтактыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.показатьВсеКонтактыToolStripMenuItem.Name = "показатьВсеКонтактыToolStripMenuItem";
            this.показатьВсеКонтактыToolStripMenuItem.Size = new System.Drawing.Size(166, 23);
            this.показатьВсеКонтактыToolStripMenuItem.Text = "Показать все контакты";
            this.показатьВсеКонтактыToolStripMenuItem.Click += new System.EventHandler(this.показатьВсеКонтактыToolStripMenuItem_Click);
            // 
            // сохранитьКонтактыToolStripMenuItem
            // 
            this.сохранитьКонтактыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.сохранитьКонтактыToolStripMenuItem.Name = "сохранитьКонтактыToolStripMenuItem";
            this.сохранитьКонтактыToolStripMenuItem.Size = new System.Drawing.Size(151, 23);
            this.сохранитьКонтактыToolStripMenuItem.Text = "Сохранить контакты";
            this.сохранитьКонтактыToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКонтактыToolStripMenuItem_Click);
            // 
            // выгрузитьКонтактыToolStripMenuItem
            // 
            this.выгрузитьКонтактыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.выгрузитьКонтактыToolStripMenuItem.Name = "выгрузитьКонтактыToolStripMenuItem";
            this.выгрузитьКонтактыToolStripMenuItem.Size = new System.Drawing.Size(149, 23);
            this.выгрузитьКонтактыToolStripMenuItem.Text = "Выгрузить контакты";
            this.выгрузитьКонтактыToolStripMenuItem.Click += new System.EventHandler(this.выгрузитьКонтактыToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(128, 23);
            this.очиститьToolStripMenuItem.Text = "Очистить список";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(664, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 20);
            this.textBox4.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Путь";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавлениеКонтактаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеКонтактаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискКонтактаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеКонтактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКонтактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьКонтактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}

