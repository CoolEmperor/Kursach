namespace Мастерская
{
    partial class FormOrderRepair
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label дата_принятияLabel;
            System.Windows.Forms.Label идВидаLabel;
            System.Windows.Forms.Label идСотрудникаLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label дата_выдачиLabel;
            System.Windows.Forms.Label фИО_КлиентаLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.КлиентTextBox = new System.Windows.Forms.TextBox();
            this.номер_телефонаTextBox = new System.Windows.Forms.TextBox();
            this.статусTextBox = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.СотрудникComboBox = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.дата_принятияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonВид = new System.Windows.Forms.Button();
            this.дата_выдачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFind = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            дата_принятияLabel = new System.Windows.Forms.Label();
            идВидаLabel = new System.Windows.Forms.Label();
            идСотрудникаLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            дата_выдачиLabel = new System.Windows.Forms.Label();
            фИО_КлиентаLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // дата_принятияLabel
            // 
            дата_принятияLabel.AutoSize = true;
            дата_принятияLabel.Location = new System.Drawing.Point(5, 29);
            дата_принятияLabel.Name = "дата_принятияLabel";
            дата_принятияLabel.Size = new System.Drawing.Size(106, 16);
            дата_принятияLabel.TabIndex = 18;
            дата_принятияLabel.Text = "Дата принятия:";
            // 
            // идВидаLabel
            // 
            идВидаLabel.AutoSize = true;
            идВидаLabel.Location = new System.Drawing.Point(5, 56);
            идВидаLabel.Name = "идВидаLabel";
            идВидаLabel.Size = new System.Drawing.Size(90, 16);
            идВидаLabel.TabIndex = 20;
            идВидаLabel.Text = "Вид техники:";
            // 
            // идСотрудникаLabel
            // 
            идСотрудникаLabel.AutoSize = true;
            идСотрудникаLabel.Location = new System.Drawing.Point(5, 140);
            идСотрудникаLabel.Name = "идСотрудникаLabel";
            идСотрудникаLabel.Size = new System.Drawing.Size(81, 16);
            идСотрудникаLabel.TabIndex = 26;
            идСотрудникаLabel.Text = "Сотрудник:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(5, 196);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(122, 16);
            номер_телефонаLabel.TabIndex = 30;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(5, 112);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(56, 16);
            статусLabel.TabIndex = 24;
            статусLabel.Text = "Статус:";
            // 
            // дата_выдачиLabel
            // 
            дата_выдачиLabel.AutoSize = true;
            дата_выдачиLabel.Location = new System.Drawing.Point(5, 85);
            дата_выдачиLabel.Name = "дата_выдачиLabel";
            дата_выдачиLabel.Size = new System.Drawing.Size(94, 16);
            дата_выдачиLabel.TabIndex = 22;
            дата_выдачиLabel.Text = "Дата выдачи:";
            // 
            // фИО_КлиентаLabel
            // 
            фИО_КлиентаLabel.AutoSize = true;
            фИО_КлиентаLabel.Location = new System.Drawing.Point(5, 168);
            фИО_КлиентаLabel.Name = "фИО_КлиентаLabel";
            фИО_КлиентаLabel.Size = new System.Drawing.Size(99, 16);
            фИО_КлиентаLabel.TabIndex = 28;
            фИО_КлиентаLabel.Text = "ФИО Клиента:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.КлиентTextBox);
            this.groupBox1.Controls.Add(this.номер_телефонаTextBox);
            this.groupBox1.Controls.Add(this.статусTextBox);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.СотрудникComboBox);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(дата_принятияLabel);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.дата_принятияDateTimePicker);
            this.groupBox1.Controls.Add(this.buttonВид);
            this.groupBox1.Controls.Add(идВидаLabel);
            this.groupBox1.Controls.Add(идСотрудникаLabel);
            this.groupBox1.Controls.Add(номер_телефонаLabel);
            this.groupBox1.Controls.Add(статусLabel);
            this.groupBox1.Controls.Add(this.дата_выдачиDateTimePicker);
            this.groupBox1.Controls.Add(дата_выдачиLabel);
            this.groupBox1.Controls.Add(фИО_КлиентаLabel);
            this.groupBox1.Location = new System.Drawing.Point(994, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 334);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление, редактирование, удаление";
            // 
            // КлиентTextBox
            // 
            this.КлиентTextBox.Location = new System.Drawing.Point(133, 168);
            this.КлиентTextBox.Name = "КлиентTextBox";
            this.КлиентTextBox.Size = new System.Drawing.Size(200, 22);
            this.КлиентTextBox.TabIndex = 36;
            // 
            // номер_телефонаTextBox
            // 
            this.номер_телефонаTextBox.Location = new System.Drawing.Point(133, 196);
            this.номер_телефонаTextBox.Name = "номер_телефонаTextBox";
            this.номер_телефонаTextBox.Size = new System.Drawing.Size(200, 22);
            this.номер_телефонаTextBox.TabIndex = 35;
            // 
            // статусTextBox
            // 
            this.статусTextBox.Location = new System.Drawing.Point(133, 110);
            this.статусTextBox.Name = "статусTextBox";
            this.статусTextBox.Size = new System.Drawing.Size(200, 22);
            this.статусTextBox.TabIndex = 34;
            // 
            // comboBox3
            // 
            this.comboBox3.DisplayMember = "Название";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(133, 52);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 24);
            this.comboBox3.TabIndex = 33;
            this.comboBox3.ValueMember = "ИдВида";
            // 
            // СотрудникComboBox
            // 
            this.СотрудникComboBox.DisplayMember = "Фамилия";
            this.СотрудникComboBox.FormattingEnabled = true;
            this.СотрудникComboBox.Location = new System.Drawing.Point(133, 137);
            this.СотрудникComboBox.Name = "СотрудникComboBox";
            this.СотрудникComboBox.Size = new System.Drawing.Size(200, 24);
            this.СотрудникComboBox.TabIndex = 32;
            this.СотрудникComboBox.ValueMember = "ИдСотрудника";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(80, 288);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(312, 26);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(80, 256);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(159, 26);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(238, 256);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(154, 26);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(80, 224);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(312, 26);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // дата_принятияDateTimePicker
            // 
            this.дата_принятияDateTimePicker.Location = new System.Drawing.Point(133, 25);
            this.дата_принятияDateTimePicker.Name = "дата_принятияDateTimePicker";
            this.дата_принятияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_принятияDateTimePicker.TabIndex = 19;
            // 
            // buttonВид
            // 
            this.buttonВид.Location = new System.Drawing.Point(339, 51);
            this.buttonВид.Name = "buttonВид";
            this.buttonВид.Size = new System.Drawing.Size(106, 24);
            this.buttonВид.TabIndex = 11;
            this.buttonВид.Text = "Перейти";
            this.buttonВид.UseVisualStyleBackColor = true;
            // 
            // дата_выдачиDateTimePicker
            // 
            this.дата_выдачиDateTimePicker.Location = new System.Drawing.Point(133, 81);
            this.дата_выдачиDateTimePicker.Name = "дата_выдачиDateTimePicker";
            this.дата_выдачиDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_выдачиDateTimePicker.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonSort);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxFind);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxFind);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(995, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 249);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск, сортировка";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(173, 207);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(147, 33);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Поле";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Возрастание",
            "Убывание"});
            this.comboBox2.Location = new System.Drawing.Point(163, 177);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Дата_принятия",
            "Дата_выдачи",
            "Статус",
            "ФИО_Клиента",
            "Номер_телефона"});
            this.comboBox1.Location = new System.Drawing.Point(163, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Данные для поиска";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(209, 77);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(182, 22);
            this.textBoxFind.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Поле";
            // 
            // comboBoxFind
            // 
            this.comboBoxFind.FormattingEnabled = true;
            this.comboBoxFind.Items.AddRange(new object[] {
            "Дата принятия",
            "Статус",
            "ФИО_Клиента",
            "Номер_телефона"});
            this.comboBoxFind.Location = new System.Drawing.Point(209, 47);
            this.comboBoxFind.Name = "comboBoxFind";
            this.comboBoxFind.Size = new System.Drawing.Size(182, 24);
            this.comboBoxFind.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сортировка по критерию";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Живой поиск";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1213, 612);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "Мастерская \"СделаНо\"";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(976, 627);
            this.dataGridView1.TabIndex = 10;
            // 
            // FormOrderRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 648);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOrderRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы на ремонт";
            this.Load += new System.EventHandler(this.FormOrderRepair_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox КлиентTextBox;
        private System.Windows.Forms.TextBox номер_телефонаTextBox;
        private System.Windows.Forms.TextBox статусTextBox;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox СотрудникComboBox;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DateTimePicker дата_принятияDateTimePicker;
        private System.Windows.Forms.Button buttonВид;
        private System.Windows.Forms.DateTimePicker дата_выдачиDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}