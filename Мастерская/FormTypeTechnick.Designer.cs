namespace Мастерская
{
    partial class FormTypeTechnick
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
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label идТипаLabel;
            System.Windows.Forms.Label идМоделиLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.идВидаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идТипаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.типустройстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мастерскаяDataSet = new Мастерская.МастерскаяDataSet();
            this.идМоделиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.модельBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.видтехникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вид_техникиTableAdapter = new Мастерская.МастерскаяDataSetTableAdapters.Вид_техникиTableAdapter();
            this.тип_устройстваTableAdapter = new Мастерская.МастерскаяDataSetTableAdapters.Тип_устройстваTableAdapter();
            this.модельTableAdapter = new Мастерская.МастерскаяDataSetTableAdapters.МодельTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonМодель = new System.Windows.Forms.Button();
            this.buttonТип = new System.Windows.Forms.Button();
            this.МодельComboBox = new System.Windows.Forms.ComboBox();
            this.модельBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ТипComboBox = new System.Windows.Forms.ComboBox();
            this.типустройстваBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new Мастерская.МастерскаяDataSetTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBoxFModel = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBoxFType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            названиеLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            идТипаLabel = new System.Windows.Forms.Label();
            идМоделиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типустройстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.модельBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видтехникиBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.модельBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типустройстваBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(4, 27);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(76, 16);
            названиеLabel.TabIndex = 2;
            названиеLabel.Text = "Название:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(4, 55);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(75, 16);
            описаниеLabel.TabIndex = 4;
            описаниеLabel.Text = "Описание:";
            // 
            // идТипаLabel
            // 
            идТипаLabel.AutoSize = true;
            идТипаLabel.Location = new System.Drawing.Point(4, 83);
            идТипаLabel.Name = "идТипаLabel";
            идТипаLabel.Size = new System.Drawing.Size(35, 16);
            идТипаLabel.TabIndex = 6;
            идТипаLabel.Text = "Тип:";
            // 
            // идМоделиLabel
            // 
            идМоделиLabel.AutoSize = true;
            идМоделиLabel.Location = new System.Drawing.Point(4, 111);
            идМоделиLabel.Name = "идМоделиLabel";
            идМоделиLabel.Size = new System.Drawing.Size(60, 16);
            идМоделиLabel.TabIndex = 8;
            идМоделиLabel.Text = "Модель:";
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
            this.идВидаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.идТипаDataGridViewTextBoxColumn,
            this.идМоделиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.видтехникиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(845, 553);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // идВидаDataGridViewTextBoxColumn
            // 
            this.идВидаDataGridViewTextBoxColumn.DataPropertyName = "ИдВида";
            this.идВидаDataGridViewTextBoxColumn.HeaderText = "ИдВида";
            this.идВидаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идВидаDataGridViewTextBoxColumn.Name = "идВидаDataGridViewTextBoxColumn";
            this.идВидаDataGridViewTextBoxColumn.ReadOnly = true;
            this.идВидаDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // идТипаDataGridViewTextBoxColumn
            // 
            this.идТипаDataGridViewTextBoxColumn.DataPropertyName = "ИдТипа";
            this.идТипаDataGridViewTextBoxColumn.DataSource = this.типустройстваBindingSource;
            this.идТипаDataGridViewTextBoxColumn.DisplayMember = "Название";
            this.идТипаDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.идТипаDataGridViewTextBoxColumn.HeaderText = "Тип устройства";
            this.идТипаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идТипаDataGridViewTextBoxColumn.Name = "идТипаDataGridViewTextBoxColumn";
            this.идТипаDataGridViewTextBoxColumn.ReadOnly = true;
            this.идТипаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.идТипаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.идТипаDataGridViewTextBoxColumn.ValueMember = "ИдТипа";
            // 
            // типустройстваBindingSource
            // 
            this.типустройстваBindingSource.DataMember = "Тип_устройства";
            this.типустройстваBindingSource.DataSource = this.мастерскаяDataSet;
            // 
            // мастерскаяDataSet
            // 
            this.мастерскаяDataSet.DataSetName = "МастерскаяDataSet";
            this.мастерскаяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // идМоделиDataGridViewTextBoxColumn
            // 
            this.идМоделиDataGridViewTextBoxColumn.DataPropertyName = "ИдМодели";
            this.идМоделиDataGridViewTextBoxColumn.DataSource = this.модельBindingSource;
            this.идМоделиDataGridViewTextBoxColumn.DisplayMember = "Название";
            this.идМоделиDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.идМоделиDataGridViewTextBoxColumn.HeaderText = "Модель устройства";
            this.идМоделиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идМоделиDataGridViewTextBoxColumn.Name = "идМоделиDataGridViewTextBoxColumn";
            this.идМоделиDataGridViewTextBoxColumn.ReadOnly = true;
            this.идМоделиDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.идМоделиDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.идМоделиDataGridViewTextBoxColumn.ValueMember = "ИдМодели";
            // 
            // модельBindingSource
            // 
            this.модельBindingSource.DataMember = "Модель";
            this.модельBindingSource.DataSource = this.мастерскаяDataSet;
            // 
            // видтехникиBindingSource
            // 
            this.видтехникиBindingSource.DataMember = "Вид_техники";
            this.видтехникиBindingSource.DataSource = this.мастерскаяDataSet;
            // 
            // вид_техникиTableAdapter
            // 
            this.вид_техникиTableAdapter.ClearBeforeFill = true;
            // 
            // тип_устройстваTableAdapter
            // 
            this.тип_устройстваTableAdapter.ClearBeforeFill = true;
            // 
            // модельTableAdapter
            // 
            this.модельTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonМодель);
            this.groupBox1.Controls.Add(this.buttonТип);
            this.groupBox1.Controls.Add(this.МодельComboBox);
            this.groupBox1.Controls.Add(this.ТипComboBox);
            this.groupBox1.Controls.Add(названиеLabel);
            this.groupBox1.Controls.Add(this.названиеTextBox);
            this.groupBox1.Controls.Add(описаниеLabel);
            this.groupBox1.Controls.Add(this.описаниеTextBox);
            this.groupBox1.Controls.Add(идТипаLabel);
            this.groupBox1.Controls.Add(идМоделиLabel);
            this.groupBox1.Location = new System.Drawing.Point(864, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление, редактирование, удаление";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(60, 207);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(312, 27);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(218, 174);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(154, 27);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(60, 174);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 27);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(60, 141);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(312, 27);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonМодель
            // 
            this.buttonМодель.Location = new System.Drawing.Point(276, 111);
            this.buttonМодель.Name = "buttonМодель";
            this.buttonМодель.Size = new System.Drawing.Size(124, 24);
            this.buttonМодель.TabIndex = 12;
            this.buttonМодель.Text = "Перейти";
            this.buttonМодель.UseVisualStyleBackColor = true;
            this.buttonМодель.Click += new System.EventHandler(this.buttonМодель_Click);
            // 
            // buttonТип
            // 
            this.buttonТип.Location = new System.Drawing.Point(277, 81);
            this.buttonТип.Name = "buttonТип";
            this.buttonТип.Size = new System.Drawing.Size(124, 24);
            this.buttonТип.TabIndex = 11;
            this.buttonТип.Text = "Перейти";
            this.buttonТип.UseVisualStyleBackColor = true;
            this.buttonТип.Click += new System.EventHandler(this.buttonТип_Click);
            // 
            // МодельComboBox
            // 
            this.МодельComboBox.DataSource = this.модельBindingSource1;
            this.МодельComboBox.DisplayMember = "Название";
            this.МодельComboBox.FormattingEnabled = true;
            this.МодельComboBox.Location = new System.Drawing.Point(92, 111);
            this.МодельComboBox.Name = "МодельComboBox";
            this.МодельComboBox.Size = new System.Drawing.Size(178, 24);
            this.МодельComboBox.TabIndex = 10;
            this.МодельComboBox.ValueMember = "ИдМодели";
            // 
            // модельBindingSource1
            // 
            this.модельBindingSource1.DataMember = "Модель";
            this.модельBindingSource1.DataSource = this.мастерскаяDataSet;
            // 
            // ТипComboBox
            // 
            this.ТипComboBox.DataSource = this.типустройстваBindingSource1;
            this.ТипComboBox.DisplayMember = "Название";
            this.ТипComboBox.FormattingEnabled = true;
            this.ТипComboBox.Location = new System.Drawing.Point(92, 81);
            this.ТипComboBox.Name = "ТипComboBox";
            this.ТипComboBox.Size = new System.Drawing.Size(178, 24);
            this.ТипComboBox.TabIndex = 9;
            this.ТипComboBox.ValueMember = "ИдТипа";
            // 
            // типустройстваBindingSource1
            // 
            this.типустройстваBindingSource1.DataMember = "Тип_устройства";
            this.типустройстваBindingSource1.DataSource = this.мастерскаяDataSet;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.видтехникиBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(92, 24);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(178, 22);
            this.названиеTextBox.TabIndex = 3;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.видтехникиBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(92, 52);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(178, 22);
            this.описаниеTextBox.TabIndex = 5;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Мастерская.МастерскаяDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_техникиTableAdapter = this.вид_техникиTableAdapter;
            this.tableAdapterManager.Заказ_на_диагностикуTableAdapter = null;
            this.tableAdapterManager.Заказ_на_ремонтTableAdapter = null;
            this.tableAdapterManager.Затраченный_материалTableAdapter = null;
            this.tableAdapterManager.МодельTableAdapter = this.модельTableAdapter;
            this.tableAdapterManager.РаботаTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Тип_поломкиTableAdapter = null;
            this.tableAdapterManager.Тип_устройстваTableAdapter = this.тип_устройстваTableAdapter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.comboBoxFModel);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.comboBoxFType);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
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
            this.groupBox2.Location = new System.Drawing.Point(864, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 278);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск, сортировка";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(232, 197);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 20);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Поиск";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBoxFModel
            // 
            this.comboBoxFModel.DataSource = this.модельBindingSource1;
            this.comboBoxFModel.DisplayMember = "Название";
            this.comboBoxFModel.FormattingEnabled = true;
            this.comboBoxFModel.Location = new System.Drawing.Point(232, 166);
            this.comboBoxFModel.Name = "comboBoxFModel";
            this.comboBoxFModel.Size = new System.Drawing.Size(158, 24);
            this.comboBoxFModel.TabIndex = 15;
            this.comboBoxFModel.ValueMember = "ИдМодели";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(232, 93);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Поиск";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxFType
            // 
            this.comboBoxFType.DataSource = this.типустройстваBindingSource1;
            this.comboBoxFType.DisplayMember = "Название";
            this.comboBoxFType.FormattingEnabled = true;
            this.comboBoxFType.Location = new System.Drawing.Point(232, 62);
            this.comboBoxFType.Name = "comboBoxFType";
            this.comboBoxFType.Size = new System.Drawing.Size(158, 24);
            this.comboBoxFType.TabIndex = 13;
            this.comboBoxFType.ValueMember = "ИдТипа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Поиск по модели";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Поиск по типу устройств";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(60, 223);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(147, 27);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 166);
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
            this.comboBox2.Location = new System.Drawing.Point(70, 193);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Название",
            "Тип устройства",
            "Модель устройства"});
            this.comboBox1.Location = new System.Drawing.Point(70, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Искомое";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(76, 89);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(131, 22);
            this.textBoxFind.TabIndex = 4;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Поле";
            // 
            // comboBoxFind
            // 
            this.comboBoxFind.FormattingEnabled = true;
            this.comboBoxFind.Items.AddRange(new object[] {
            "Название",
            "Описание"});
            this.comboBoxFind.Location = new System.Drawing.Point(76, 62);
            this.comboBoxFind.Name = "comboBoxFind";
            this.comboBoxFind.Size = new System.Drawing.Size(131, 24);
            this.comboBoxFind.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сортировка по критерию";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 31);
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
            this.label7.Location = new System.Drawing.Point(1039, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 27);
            this.label7.TabIndex = 7;
            this.label7.Text = "Мастерская \"СделаНо\"";
            // 
            // FormTypeTechnick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 578);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTypeTechnick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вид Техники";
            this.Load += new System.EventHandler(this.FormTypeTechnick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типустройстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.модельBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видтехникиBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.модельBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типустройстваBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private МастерскаяDataSet мастерскаяDataSet;
        private System.Windows.Forms.BindingSource видтехникиBindingSource;
        private МастерскаяDataSetTableAdapters.Вид_техникиTableAdapter вид_техникиTableAdapter;
        private System.Windows.Forms.BindingSource типустройстваBindingSource;
        private МастерскаяDataSetTableAdapters.Тип_устройстваTableAdapter тип_устройстваTableAdapter;
        private System.Windows.Forms.BindingSource модельBindingSource;
        private МастерскаяDataSetTableAdapters.МодельTableAdapter модельTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn идВидаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn идТипаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn идМоделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private МастерскаяDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox МодельComboBox;
        private System.Windows.Forms.ComboBox ТипComboBox;
        private System.Windows.Forms.Button buttonМодель;
        private System.Windows.Forms.Button buttonТип;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFind;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource модельBindingSource1;
        private System.Windows.Forms.BindingSource типустройстваBindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBoxFModel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBoxFType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}