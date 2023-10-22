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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label идЗаявкиLabel;
            System.Windows.Forms.Label номер_квитанцииLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label дата_началаLabel;
            System.Windows.Forms.Label дата_концаLabel;
            System.Windows.Forms.Label идСотрудникаLabel;
            System.Windows.Forms.Label скидкаLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
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
            this.мастерскаяDataSet = new Мастерская.МастерскаяDataSet();
            this.заказ_на_ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказ_на_ремонтTableAdapter = new Мастерская.МастерскаяDataSetTableAdapters.Заказ_на_ремонтTableAdapter();
            this.tableAdapterManager = new Мастерская.МастерскаяDataSetTableAdapters.TableAdapterManager();
            this.идЗаявкиTextBox = new System.Windows.Forms.TextBox();
            this.номер_квитанцииTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.дата_началаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_концаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.идСотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.скидкаTextBox = new System.Windows.Forms.TextBox();
            идЗаявкиLabel = new System.Windows.Forms.Label();
            номер_квитанцииLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            дата_началаLabel = new System.Windows.Forms.Label();
            дата_концаLabel = new System.Windows.Forms.Label();
            идСотрудникаLabel = new System.Windows.Forms.Label();
            скидкаLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказ_на_ремонтBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(идЗаявкиLabel);
            this.groupBox1.Controls.Add(this.идЗаявкиTextBox);
            this.groupBox1.Controls.Add(номер_квитанцииLabel);
            this.groupBox1.Controls.Add(this.номер_квитанцииTextBox);
            this.groupBox1.Controls.Add(стоимостьLabel);
            this.groupBox1.Controls.Add(this.стоимостьTextBox);
            this.groupBox1.Controls.Add(дата_началаLabel);
            this.groupBox1.Controls.Add(this.дата_началаDateTimePicker);
            this.groupBox1.Controls.Add(дата_концаLabel);
            this.groupBox1.Controls.Add(this.дата_концаDateTimePicker);
            this.groupBox1.Controls.Add(идСотрудникаLabel);
            this.groupBox1.Controls.Add(this.идСотрудникаTextBox);
            this.groupBox1.Controls.Add(скидкаLabel);
            this.groupBox1.Controls.Add(this.скидкаTextBox);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Location = new System.Drawing.Point(994, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 324);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление, редактирование, удаление";
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
            this.groupBox2.Location = new System.Drawing.Point(994, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 249);
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
            this.label7.Location = new System.Drawing.Point(1257, 612);
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
            // мастерскаяDataSet
            // 
            this.мастерскаяDataSet.DataSetName = "МастерскаяDataSet";
            this.мастерскаяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказ_на_ремонтBindingSource
            // 
            this.заказ_на_ремонтBindingSource.DataMember = "Заказ_на_ремонт";
            this.заказ_на_ремонтBindingSource.DataSource = this.мастерскаяDataSet;
            // 
            // заказ_на_ремонтTableAdapter
            // 
            this.заказ_на_ремонтTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Мастерская.МастерскаяDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_техникиTableAdapter = null;
            this.tableAdapterManager.Заказ_на_диагностикуTableAdapter = null;
            this.tableAdapterManager.Заказ_на_ремонтTableAdapter = this.заказ_на_ремонтTableAdapter;
            this.tableAdapterManager.Затраченный_материалTableAdapter = null;
            this.tableAdapterManager.МодельTableAdapter = null;
            this.tableAdapterManager.РаботаTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Тип_поломкиTableAdapter = null;
            this.tableAdapterManager.Тип_устройстваTableAdapter = null;
            // 
            // идЗаявкиLabel
            // 
            идЗаявкиLabel.AutoSize = true;
            идЗаявкиLabel.Location = new System.Drawing.Point(42, 35);
            идЗаявкиLabel.Name = "идЗаявкиLabel";
            идЗаявкиLabel.Size = new System.Drawing.Size(78, 16);
            идЗаявкиLabel.TabIndex = 16;
            идЗаявкиLabel.Text = "Ид Заявки:";
            // 
            // идЗаявкиTextBox
            // 
            this.идЗаявкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказ_на_ремонтBindingSource, "ИдЗаявки", true));
            this.идЗаявкиTextBox.Location = new System.Drawing.Point(174, 32);
            this.идЗаявкиTextBox.Name = "идЗаявкиTextBox";
            this.идЗаявкиTextBox.Size = new System.Drawing.Size(200, 22);
            this.идЗаявкиTextBox.TabIndex = 17;
            // 
            // номер_квитанцииLabel
            // 
            номер_квитанцииLabel.AutoSize = true;
            номер_квитанцииLabel.Location = new System.Drawing.Point(42, 63);
            номер_квитанцииLabel.Name = "номер_квитанцииLabel";
            номер_квитанцииLabel.Size = new System.Drawing.Size(126, 16);
            номер_квитанцииLabel.TabIndex = 18;
            номер_квитанцииLabel.Text = "Номер квитанции:";
            // 
            // номер_квитанцииTextBox
            // 
            this.номер_квитанцииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказ_на_ремонтBindingSource, "Номер_квитанции", true));
            this.номер_квитанцииTextBox.Location = new System.Drawing.Point(174, 60);
            this.номер_квитанцииTextBox.Name = "номер_квитанцииTextBox";
            this.номер_квитанцииTextBox.Size = new System.Drawing.Size(200, 22);
            this.номер_квитанцииTextBox.TabIndex = 19;
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(42, 91);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(80, 16);
            стоимостьLabel.TabIndex = 20;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказ_на_ремонтBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(174, 88);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(200, 22);
            this.стоимостьTextBox.TabIndex = 21;
            // 
            // дата_началаLabel
            // 
            дата_началаLabel.AutoSize = true;
            дата_началаLabel.Location = new System.Drawing.Point(42, 120);
            дата_началаLabel.Name = "дата_началаLabel";
            дата_началаLabel.Size = new System.Drawing.Size(93, 16);
            дата_началаLabel.TabIndex = 22;
            дата_началаLabel.Text = "Дата начала:";
            // 
            // дата_началаDateTimePicker
            // 
            this.дата_началаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказ_на_ремонтBindingSource, "Дата_начала", true));
            this.дата_началаDateTimePicker.Location = new System.Drawing.Point(174, 116);
            this.дата_началаDateTimePicker.Name = "дата_началаDateTimePicker";
            this.дата_началаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_началаDateTimePicker.TabIndex = 23;
            // 
            // дата_концаLabel
            // 
            дата_концаLabel.AutoSize = true;
            дата_концаLabel.Location = new System.Drawing.Point(42, 148);
            дата_концаLabel.Name = "дата_концаLabel";
            дата_концаLabel.Size = new System.Drawing.Size(84, 16);
            дата_концаLabel.TabIndex = 24;
            дата_концаLabel.Text = "Дата конца:";
            // 
            // дата_концаDateTimePicker
            // 
            this.дата_концаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказ_на_ремонтBindingSource, "Дата_конца", true));
            this.дата_концаDateTimePicker.Location = new System.Drawing.Point(174, 144);
            this.дата_концаDateTimePicker.Name = "дата_концаDateTimePicker";
            this.дата_концаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_концаDateTimePicker.TabIndex = 25;
            // 
            // идСотрудникаLabel
            // 
            идСотрудникаLabel.AutoSize = true;
            идСотрудникаLabel.Location = new System.Drawing.Point(42, 175);
            идСотрудникаLabel.Name = "идСотрудникаLabel";
            идСотрудникаLabel.Size = new System.Drawing.Size(110, 16);
            идСотрудникаLabel.TabIndex = 26;
            идСотрудникаLabel.Text = "Ид Сотрудника:";
            // 
            // идСотрудникаTextBox
            // 
            this.идСотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказ_на_ремонтBindingSource, "ИдСотрудника", true));
            this.идСотрудникаTextBox.Location = new System.Drawing.Point(174, 172);
            this.идСотрудникаTextBox.Name = "идСотрудникаTextBox";
            this.идСотрудникаTextBox.Size = new System.Drawing.Size(200, 22);
            this.идСотрудникаTextBox.TabIndex = 27;
            // 
            // скидкаLabel
            // 
            скидкаLabel.AutoSize = true;
            скидкаLabel.Location = new System.Drawing.Point(42, 203);
            скидкаLabel.Name = "скидкаLabel";
            скидкаLabel.Size = new System.Drawing.Size(57, 16);
            скидкаLabel.TabIndex = 28;
            скидкаLabel.Text = "Скидка:";
            // 
            // скидкаTextBox
            // 
            this.скидкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказ_на_ремонтBindingSource, "Скидка", true));
            this.скидкаTextBox.Location = new System.Drawing.Point(174, 200);
            this.скидкаTextBox.Name = "скидкаTextBox";
            this.скидкаTextBox.Size = new System.Drawing.Size(200, 22);
            this.скидкаTextBox.TabIndex = 29;
            // 
            // FormOrderRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 648);
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
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказ_на_ремонтBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonClear;
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
        private МастерскаяDataSet мастерскаяDataSet;
        private System.Windows.Forms.BindingSource заказ_на_ремонтBindingSource;
        private МастерскаяDataSetTableAdapters.Заказ_на_ремонтTableAdapter заказ_на_ремонтTableAdapter;
        private МастерскаяDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox идЗаявкиTextBox;
        private System.Windows.Forms.TextBox номер_квитанцииTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.DateTimePicker дата_началаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_концаDateTimePicker;
        private System.Windows.Forms.TextBox идСотрудникаTextBox;
        private System.Windows.Forms.TextBox скидкаTextBox;
    }
}