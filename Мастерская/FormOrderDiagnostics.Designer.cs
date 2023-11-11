namespace Мастерская
{
    partial class FormOrderDiagnostics
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
            System.Windows.Forms.Label дата_принятияLabel;
            System.Windows.Forms.Label идВидаLabel;
            System.Windows.Forms.Label дата_выдачиLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label идСотрудникаLabel;
            System.Windows.Forms.Label фИО_КлиентаLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.идЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапринятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идВидаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.видтехникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мастерскаяDataSet = new Мастерская.МастерскаяDataSet();
            this.датавыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фИОКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказнадиагностикуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказ_на_диагностикуTableAdapter = new Мастерская.МастерскаяDataSetTableAdapters.Заказ_на_диагностикуTableAdapter();
            this.вид_техникиTableAdapter = new Мастерская.МастерскаяDataSetTableAdapters.Вид_техникиTableAdapter();
            this.сотрудникTableAdapter = new Мастерская.МастерскаяDataSetTableAdapters.СотрудникTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.КлиентTextBox = new System.Windows.Forms.TextBox();
            this.номер_телефонаTextBox = new System.Windows.Forms.TextBox();
            this.статусTextBox = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.видтехникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.СотрудникComboBox = new System.Windows.Forms.ComboBox();
            this.сотрудникBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.дата_принятияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonВид = new System.Windows.Forms.Button();
            this.дата_выдачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableAdapterManager = new Мастерская.МастерскаяDataSetTableAdapters.TableAdapterManager();
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
            дата_принятияLabel = new System.Windows.Forms.Label();
            идВидаLabel = new System.Windows.Forms.Label();
            дата_выдачиLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            идСотрудникаLabel = new System.Windows.Forms.Label();
            фИО_КлиентаLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видтехникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказнадиагностикуBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.видтехникиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // дата_выдачиLabel
            // 
            дата_выдачиLabel.AutoSize = true;
            дата_выдачиLabel.Location = new System.Drawing.Point(5, 85);
            дата_выдачиLabel.Name = "дата_выдачиLabel";
            дата_выдачиLabel.Size = new System.Drawing.Size(94, 16);
            дата_выдачиLabel.TabIndex = 22;
            дата_выдачиLabel.Text = "Дата выдачи:";
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
            // идСотрудникаLabel
            // 
            идСотрудникаLabel.AutoSize = true;
            идСотрудникаLabel.Location = new System.Drawing.Point(5, 140);
            идСотрудникаLabel.Name = "идСотрудникаLabel";
            идСотрудникаLabel.Size = new System.Drawing.Size(81, 16);
            идСотрудникаLabel.TabIndex = 26;
            идСотрудникаLabel.Text = "Сотрудник:";
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
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(5, 196);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(122, 16);
            номер_телефонаLabel.TabIndex = 30;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идЗаявкиDataGridViewTextBoxColumn,
            this.датапринятияDataGridViewTextBoxColumn,
            this.идВидаDataGridViewTextBoxColumn,
            this.датавыдачиDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.идСотрудникаDataGridViewTextBoxColumn,
            this.фИОКлиентаDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказнадиагностикуBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(975, 623);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // идЗаявкиDataGridViewTextBoxColumn
            // 
            this.идЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "ИдЗаявки";
            this.идЗаявкиDataGridViewTextBoxColumn.HeaderText = "ИдЗаявки";
            this.идЗаявкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идЗаявкиDataGridViewTextBoxColumn.Name = "идЗаявкиDataGridViewTextBoxColumn";
            this.идЗаявкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.идЗаявкиDataGridViewTextBoxColumn.Visible = false;
            // 
            // датапринятияDataGridViewTextBoxColumn
            // 
            this.датапринятияDataGridViewTextBoxColumn.DataPropertyName = "Дата_принятия";
            this.датапринятияDataGridViewTextBoxColumn.HeaderText = "Дата принятия";
            this.датапринятияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датапринятияDataGridViewTextBoxColumn.Name = "датапринятияDataGridViewTextBoxColumn";
            this.датапринятияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // идВидаDataGridViewTextBoxColumn
            // 
            this.идВидаDataGridViewTextBoxColumn.DataPropertyName = "ИдВида";
            this.идВидаDataGridViewTextBoxColumn.DataSource = this.видтехникиBindingSource;
            this.идВидаDataGridViewTextBoxColumn.DisplayMember = "Название";
            this.идВидаDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.идВидаDataGridViewTextBoxColumn.HeaderText = "Вид техники";
            this.идВидаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идВидаDataGridViewTextBoxColumn.Name = "идВидаDataGridViewTextBoxColumn";
            this.идВидаDataGridViewTextBoxColumn.ReadOnly = true;
            this.идВидаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.идВидаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.идВидаDataGridViewTextBoxColumn.ValueMember = "ИдВида";
            // 
            // видтехникиBindingSource
            // 
            this.видтехникиBindingSource.DataMember = "Вид_техники";
            this.видтехникиBindingSource.DataSource = this.мастерскаяDataSet;
            // 
            // мастерскаяDataSet
            // 
            this.мастерскаяDataSet.DataSetName = "МастерскаяDataSet";
            this.мастерскаяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // датавыдачиDataGridViewTextBoxColumn
            // 
            this.датавыдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата_выдачи";
            this.датавыдачиDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.датавыдачиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датавыдачиDataGridViewTextBoxColumn.Name = "датавыдачиDataGridViewTextBoxColumn";
            this.датавыдачиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // идСотрудникаDataGridViewTextBoxColumn
            // 
            this.идСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ИдСотрудника";
            this.идСотрудникаDataGridViewTextBoxColumn.DataSource = this.сотрудникBindingSource;
            this.идСотрудникаDataGridViewTextBoxColumn.DisplayMember = "Фамилия";
            this.идСотрудникаDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.идСотрудникаDataGridViewTextBoxColumn.HeaderText = "Фамилия Сотрудника";
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
            // фИОКлиентаDataGridViewTextBoxColumn
            // 
            this.фИОКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ФИО_Клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.HeaderText = "ФИО Клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОКлиентаDataGridViewTextBoxColumn.Name = "фИОКлиентаDataGridViewTextBoxColumn";
            this.фИОКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номертелефонаDataGridViewTextBoxColumn
            // 
            this.номертелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номертелефонаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номертелефонаDataGridViewTextBoxColumn.Name = "номертелефонаDataGridViewTextBoxColumn";
            this.номертелефонаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // вид_техникиTableAdapter
            // 
            this.вид_техникиTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
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
            this.groupBox1.TabIndex = 2;
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
            this.comboBox3.DataSource = this.видтехникиBindingSource1;
            this.comboBox3.DisplayMember = "Название";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(133, 52);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 24);
            this.comboBox3.TabIndex = 33;
            this.comboBox3.ValueMember = "ИдВида";
            // 
            // видтехникиBindingSource1
            // 
            this.видтехникиBindingSource1.DataMember = "Вид_техники";
            this.видтехникиBindingSource1.DataSource = this.мастерскаяDataSet;
            // 
            // СотрудникComboBox
            // 
            this.СотрудникComboBox.DataSource = this.сотрудникBindingSource1;
            this.СотрудникComboBox.DisplayMember = "Фамилия";
            this.СотрудникComboBox.FormattingEnabled = true;
            this.СотрудникComboBox.Location = new System.Drawing.Point(133, 137);
            this.СотрудникComboBox.Name = "СотрудникComboBox";
            this.СотрудникComboBox.Size = new System.Drawing.Size(200, 24);
            this.СотрудникComboBox.TabIndex = 32;
            this.СотрудникComboBox.ValueMember = "ИдСотрудника";
            // 
            // сотрудникBindingSource1
            // 
            this.сотрудникBindingSource1.DataMember = "Сотрудник";
            this.сотрудникBindingSource1.DataSource = this.мастерскаяDataSet;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(80, 288);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(312, 26);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(80, 256);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(159, 26);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(238, 256);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(154, 26);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(80, 224);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(312, 26);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // дата_принятияDateTimePicker
            // 
            this.дата_принятияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказнадиагностикуBindingSource, "Дата_принятия", true));
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
            this.buttonВид.Click += new System.EventHandler(this.buttonВид_Click);
            // 
            // дата_выдачиDateTimePicker
            // 
            this.дата_выдачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказнадиагностикуBindingSource, "Дата_выдачи", true));
            this.дата_выдачиDateTimePicker.Location = new System.Drawing.Point(133, 81);
            this.дата_выдачиDateTimePicker.Name = "дата_выдачиDateTimePicker";
            this.дата_выдачиDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_выдачиDateTimePicker.TabIndex = 23;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Мастерская.МастерскаяDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_техникиTableAdapter = this.вид_техникиTableAdapter;
            this.tableAdapterManager.Заказ_на_диагностикуTableAdapter = this.заказ_на_диагностикуTableAdapter;
            this.tableAdapterManager.Заказ_на_ремонтTableAdapter = null;
            this.tableAdapterManager.Затраченный_материалTableAdapter = null;
            this.tableAdapterManager.МодельTableAdapter = null;
            this.tableAdapterManager.РаботаTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = this.сотрудникTableAdapter;
            this.tableAdapterManager.Тип_поломкиTableAdapter = null;
            this.tableAdapterManager.Тип_устройстваTableAdapter = null;
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
            this.groupBox2.TabIndex = 3;
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
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
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
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
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
            this.label7.Location = new System.Drawing.Point(1211, 612);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Мастерская \"СделаНо\"";
            // 
            // FormOrderDiagnostics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 648);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormOrderDiagnostics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация на диагностику";
            this.Load += new System.EventHandler(this.FormOrderDiagnostics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видтехникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказнадиагностикуBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.видтехникиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private МастерскаяDataSet мастерскаяDataSet;
        private System.Windows.Forms.BindingSource заказнадиагностикуBindingSource;
        private МастерскаяDataSetTableAdapters.Заказ_на_диагностикуTableAdapter заказ_на_диагностикуTableAdapter;
        private System.Windows.Forms.BindingSource видтехникиBindingSource;
        private МастерскаяDataSetTableAdapters.Вид_техникиTableAdapter вид_техникиTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private МастерскаяDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn идЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапринятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn идВидаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn идСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DateTimePicker дата_принятияDateTimePicker;
        private System.Windows.Forms.Button buttonВид;
        private System.Windows.Forms.DateTimePicker дата_выдачиDateTimePicker;
        private МастерскаяDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.ComboBox СотрудникComboBox;
        private System.Windows.Forms.BindingSource сотрудникBindingSource1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource видтехникиBindingSource1;
        private System.Windows.Forms.TextBox номер_телефонаTextBox;
        private System.Windows.Forms.TextBox статусTextBox;
        private System.Windows.Forms.TextBox КлиентTextBox;
    }
}