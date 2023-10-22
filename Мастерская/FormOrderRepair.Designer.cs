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
            System.Windows.Forms.Label дата_началаLabel;
            System.Windows.Forms.Label дата_концаLabel;
            System.Windows.Forms.Label идСотрудникаLabel;
            System.Windows.Forms.Label скидкаLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxЗаявка = new System.Windows.Forms.ComboBox();
            this.comboBoxСотрудник = new System.Windows.Forms.ComboBox();
            this.дата_началаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_концаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.скидкаTextBox = new System.Windows.Forms.TextBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерквитанцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаконцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мастерскаяDataSet = new Мастерская.МастерскаяDataSet();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказнаремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказ_на_ремонтTableAdapter = new Мастерская.МастерскаяDataSetTableAdapters.Заказ_на_ремонтTableAdapter();
            this.сотрудникTableAdapter = new Мастерская.МастерскаяDataSetTableAdapters.СотрудникTableAdapter();
            this.заказнадиагностикуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказ_на_диагностикуTableAdapter = new Мастерская.МастерскаяDataSetTableAdapters.Заказ_на_диагностикуTableAdapter();
            идЗаявкиLabel = new System.Windows.Forms.Label();
            дата_началаLabel = new System.Windows.Forms.Label();
            дата_концаLabel = new System.Windows.Forms.Label();
            идСотрудникаLabel = new System.Windows.Forms.Label();
            скидкаLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказнаремонтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказнадиагностикуBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // идЗаявкиLabel
            // 
            идЗаявкиLabel.AutoSize = true;
            идЗаявкиLabel.Location = new System.Drawing.Point(7, 44);
            идЗаявкиLabel.Name = "идЗаявкиLabel";
            идЗаявкиLabel.Size = new System.Drawing.Size(78, 16);
            идЗаявкиLabel.TabIndex = 16;
            идЗаявкиLabel.Text = "Ид Заявки:";
            // 
            // дата_началаLabel
            // 
            дата_началаLabel.AutoSize = true;
            дата_началаLabel.Location = new System.Drawing.Point(7, 69);
            дата_началаLabel.Name = "дата_началаLabel";
            дата_началаLabel.Size = new System.Drawing.Size(93, 16);
            дата_началаLabel.TabIndex = 22;
            дата_началаLabel.Text = "Дата начала:";
            // 
            // дата_концаLabel
            // 
            дата_концаLabel.AutoSize = true;
            дата_концаLabel.Location = new System.Drawing.Point(7, 97);
            дата_концаLabel.Name = "дата_концаLabel";
            дата_концаLabel.Size = new System.Drawing.Size(84, 16);
            дата_концаLabel.TabIndex = 24;
            дата_концаLabel.Text = "Дата конца:";
            // 
            // идСотрудникаLabel
            // 
            идСотрудникаLabel.AutoSize = true;
            идСотрудникаLabel.Location = new System.Drawing.Point(7, 124);
            идСотрудникаLabel.Name = "идСотрудникаLabel";
            идСотрудникаLabel.Size = new System.Drawing.Size(81, 16);
            идСотрудникаLabel.TabIndex = 26;
            идСотрудникаLabel.Text = "Сотрудник:";
            // 
            // скидкаLabel
            // 
            скидкаLabel.AutoSize = true;
            скидкаLabel.Location = new System.Drawing.Point(7, 152);
            скидкаLabel.Name = "скидкаLabel";
            скидкаLabel.Size = new System.Drawing.Size(57, 16);
            скидкаLabel.TabIndex = 28;
            скидкаLabel.Text = "Скидка:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxЗаявка);
            this.groupBox1.Controls.Add(this.comboBoxСотрудник);
            this.groupBox1.Controls.Add(идЗаявкиLabel);
            this.groupBox1.Controls.Add(дата_началаLabel);
            this.groupBox1.Controls.Add(this.дата_началаDateTimePicker);
            this.groupBox1.Controls.Add(дата_концаLabel);
            this.groupBox1.Controls.Add(this.дата_концаDateTimePicker);
            this.groupBox1.Controls.Add(идСотрудникаLabel);
            this.groupBox1.Controls.Add(скидкаLabel);
            this.groupBox1.Controls.Add(this.скидкаTextBox);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Location = new System.Drawing.Point(1115, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 324);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление, редактирование, удаление";
            // 
            // comboBoxЗаявка
            // 
            this.comboBoxЗаявка.DataSource = this.заказнадиагностикуBindingSource;
            this.comboBoxЗаявка.DisplayMember = "ИдЗаявки";
            this.comboBoxЗаявка.FormattingEnabled = true;
            this.comboBoxЗаявка.Location = new System.Drawing.Point(139, 35);
            this.comboBoxЗаявка.Name = "comboBoxЗаявка";
            this.comboBoxЗаявка.Size = new System.Drawing.Size(200, 24);
            this.comboBoxЗаявка.TabIndex = 31;
            this.comboBoxЗаявка.ValueMember = "ИдЗаявки";
            // 
            // comboBoxСотрудник
            // 
            this.comboBoxСотрудник.DataSource = this.сотрудникBindingSource;
            this.comboBoxСотрудник.DisplayMember = "Фамилия";
            this.comboBoxСотрудник.FormattingEnabled = true;
            this.comboBoxСотрудник.Location = new System.Drawing.Point(139, 119);
            this.comboBoxСотрудник.Name = "comboBoxСотрудник";
            this.comboBoxСотрудник.Size = new System.Drawing.Size(200, 24);
            this.comboBoxСотрудник.TabIndex = 30;
            this.comboBoxСотрудник.ValueMember = "ИдСотрудника";
            // 
            // дата_началаDateTimePicker
            // 
            this.дата_началаDateTimePicker.Location = new System.Drawing.Point(139, 65);
            this.дата_началаDateTimePicker.Name = "дата_началаDateTimePicker";
            this.дата_началаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_началаDateTimePicker.TabIndex = 23;
            // 
            // дата_концаDateTimePicker
            // 
            this.дата_концаDateTimePicker.Location = new System.Drawing.Point(139, 93);
            this.дата_концаDateTimePicker.Name = "дата_концаDateTimePicker";
            this.дата_концаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_концаDateTimePicker.TabIndex = 25;
            // 
            // скидкаTextBox
            // 
            this.скидкаTextBox.Location = new System.Drawing.Point(139, 149);
            this.скидкаTextBox.Name = "скидкаTextBox";
            this.скидкаTextBox.Size = new System.Drawing.Size(200, 22);
            this.скидкаTextBox.TabIndex = 29;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(10, 271);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(312, 26);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(10, 239);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(159, 26);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(168, 239);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(154, 26);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(10, 207);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(312, 26);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonSort);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(1115, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 249);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(113, 123);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(147, 33);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 66);
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
            this.comboBox2.Location = new System.Drawing.Point(103, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Дата_начала",
            "Дата_конца",
            "Скидка",
            "Стоимость"});
            this.comboBox1.Location = new System.Drawing.Point(103, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сортировка по критерию";
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерквитанцииDataGridViewTextBoxColumn,
            this.идЗаявкиDataGridViewTextBoxColumn,
            this.датаначалаDataGridViewTextBoxColumn,
            this.датаконцаDataGridViewTextBoxColumn,
            this.идСотрудникаDataGridViewTextBoxColumn,
            this.скидкаDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказнаремонтBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 627);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // номерквитанцииDataGridViewTextBoxColumn
            // 
            this.номерквитанцииDataGridViewTextBoxColumn.DataPropertyName = "Номер_квитанции";
            this.номерквитанцииDataGridViewTextBoxColumn.HeaderText = "Номер_квитанции";
            this.номерквитанцииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерквитанцииDataGridViewTextBoxColumn.Name = "номерквитанцииDataGridViewTextBoxColumn";
            this.номерквитанцииDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерквитанцииDataGridViewTextBoxColumn.Visible = false;
            // 
            // идЗаявкиDataGridViewTextBoxColumn
            // 
            this.идЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "ИдЗаявки";
            this.идЗаявкиDataGridViewTextBoxColumn.HeaderText = "ИдЗаявки";
            this.идЗаявкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идЗаявкиDataGridViewTextBoxColumn.Name = "идЗаявкиDataGridViewTextBoxColumn";
            this.идЗаявкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаначалаDataGridViewTextBoxColumn
            // 
            this.датаначалаDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.датаначалаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаначалаDataGridViewTextBoxColumn.Name = "датаначалаDataGridViewTextBoxColumn";
            this.датаначалаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаконцаDataGridViewTextBoxColumn
            // 
            this.датаконцаDataGridViewTextBoxColumn.DataPropertyName = "Дата_конца";
            this.датаконцаDataGridViewTextBoxColumn.HeaderText = "Дата конца";
            this.датаконцаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаконцаDataGridViewTextBoxColumn.Name = "датаконцаDataGridViewTextBoxColumn";
            this.датаконцаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // идСотрудникаDataGridViewTextBoxColumn
            // 
            this.идСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ИдСотрудника";
            this.идСотрудникаDataGridViewTextBoxColumn.DataSource = this.сотрудникBindingSource;
            this.идСотрудникаDataGridViewTextBoxColumn.DisplayMember = "Фамилия";
            this.идСотрудникаDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.идСотрудникаDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.идСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идСотрудникаDataGridViewTextBoxColumn.Name = "идСотрудникаDataGridViewTextBoxColumn";
            this.идСотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.идСотрудникаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.идСотрудникаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.идСотрудникаDataGridViewTextBoxColumn.ValueMember = "ИдСотрудника";
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.мастерскаяDataSet;
            // 
            // мастерскаяDataSet
            // 
            this.мастерскаяDataSet.DataSetName = "МастерскаяDataSet";
            this.мастерскаяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            this.скидкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // заказнаремонтBindingSource
            // 
            this.заказнаремонтBindingSource.DataMember = "Заказ_на_ремонт";
            this.заказнаремонтBindingSource.DataSource = this.мастерскаяDataSet;
            // 
            // заказ_на_ремонтTableAdapter
            // 
            this.заказ_на_ремонтTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // заказнадиагностикуBindingSource
            // 
            this.заказнадиагностикуBindingSource.DataMember = "Заказ_на_диагностику";
            this.заказнадиагностикуBindingSource.DataSource = this.мастерскаяDataSet;
            // 
            // заказ_на_диагностикуTableAdapter
            // 
            this.заказ_на_диагностикуTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказнаремонтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказнадиагностикуBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker дата_началаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_концаDateTimePicker;
        private System.Windows.Forms.TextBox скидкаTextBox;
        private МастерскаяDataSet мастерскаяDataSet;
        private System.Windows.Forms.BindingSource заказнаремонтBindingSource;
        private МастерскаяDataSetTableAdapters.Заказ_на_ремонтTableAdapter заказ_на_ремонтTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private МастерскаяDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxСотрудник;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерквитанцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn идЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаначалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаконцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn идСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxЗаявка;
        private System.Windows.Forms.BindingSource заказнадиагностикуBindingSource;
        private МастерскаяDataSetTableAdapters.Заказ_на_диагностикуTableAdapter заказ_на_диагностикуTableAdapter;
    }
}