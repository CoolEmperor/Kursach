namespace Мастерская
{
    partial class FormModelDevice
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
            System.Windows.Forms.Label дата_выпускаLabel;
            System.Windows.Forms.Label описаниеLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.идМоделиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мастерскаяDataSet = new Мастерская.МастерскаяDataSet();
            this.модельTableAdapter = new Мастерская.МастерскаяDataSetTableAdapters.МодельTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.дата_выпускаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
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
            this.tableAdapterManager = new Мастерская.МастерскаяDataSetTableAdapters.TableAdapterManager();
            названиеLabel = new System.Windows.Forms.Label();
            дата_выпускаLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.модельBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(34, 40);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(76, 16);
            названиеLabel.TabIndex = 18;
            названиеLabel.Text = "Название:";
            // 
            // дата_выпускаLabel
            // 
            дата_выпускаLabel.AutoSize = true;
            дата_выпускаLabel.Location = new System.Drawing.Point(34, 69);
            дата_выпускаLabel.Name = "дата_выпускаLabel";
            дата_выпускаLabel.Size = new System.Drawing.Size(100, 16);
            дата_выпускаLabel.TabIndex = 20;
            дата_выпускаLabel.Text = "Дата выпуска:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(34, 96);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(75, 16);
            описаниеLabel.TabIndex = 22;
            описаниеLabel.Text = "Описание:";
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
            this.идМоделиDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.датавыпускаDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.модельBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(883, 553);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // идМоделиDataGridViewTextBoxColumn
            // 
            this.идМоделиDataGridViewTextBoxColumn.DataPropertyName = "ИдМодели";
            this.идМоделиDataGridViewTextBoxColumn.HeaderText = "ИдМодели";
            this.идМоделиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идМоделиDataGridViewTextBoxColumn.Name = "идМоделиDataGridViewTextBoxColumn";
            this.идМоделиDataGridViewTextBoxColumn.ReadOnly = true;
            this.идМоделиDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датавыпускаDataGridViewTextBoxColumn
            // 
            this.датавыпускаDataGridViewTextBoxColumn.DataPropertyName = "Дата_выпуска";
            this.датавыпускаDataGridViewTextBoxColumn.HeaderText = "Дата выпуска";
            this.датавыпускаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датавыпускаDataGridViewTextBoxColumn.Name = "датавыпускаDataGridViewTextBoxColumn";
            this.датавыпускаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // модельBindingSource
            // 
            this.модельBindingSource.DataMember = "Модель";
            this.модельBindingSource.DataSource = this.мастерскаяDataSet;
            // 
            // мастерскаяDataSet
            // 
            this.мастерскаяDataSet.DataSetName = "МастерскаяDataSet";
            this.мастерскаяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // модельTableAdapter
            // 
            this.модельTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(названиеLabel);
            this.groupBox1.Controls.Add(this.названиеTextBox);
            this.groupBox1.Controls.Add(дата_выпускаLabel);
            this.groupBox1.Controls.Add(this.дата_выпускаDateTimePicker);
            this.groupBox1.Controls.Add(описаниеLabel);
            this.groupBox1.Controls.Add(this.описаниеTextBox);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Location = new System.Drawing.Point(903, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление, редактирование, удаление";
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.модельBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(140, 37);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(200, 22);
            this.названиеTextBox.TabIndex = 19;
            // 
            // дата_выпускаDateTimePicker
            // 
            this.дата_выпускаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.модельBindingSource, "Дата_выпуска", true));
            this.дата_выпускаDateTimePicker.Location = new System.Drawing.Point(140, 65);
            this.дата_выпускаDateTimePicker.Name = "дата_выпускаDateTimePicker";
            this.дата_выпускаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_выпускаDateTimePicker.TabIndex = 21;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.модельBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(140, 93);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(200, 22);
            this.описаниеTextBox.TabIndex = 23;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(28, 222);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(312, 33);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(186, 183);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(154, 33);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(28, 183);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(159, 33);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(28, 144);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(312, 33);
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
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxFind);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxFind);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(903, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 249);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск, сортировка";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(122, 207);
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
            this.label6.Location = new System.Drawing.Point(45, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 150);
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
            this.comboBox2.Location = new System.Drawing.Point(112, 177);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Название",
            "Дата_выпуска",
            "Описание"});
            this.comboBox1.Location = new System.Drawing.Point(112, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Данные для поиска";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(158, 80);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(182, 22);
            this.textBoxFind.TabIndex = 4;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 53);
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
            this.comboBoxFind.Location = new System.Drawing.Point(158, 50);
            this.comboBoxFind.Name = "comboBoxFind";
            this.comboBoxFind.Size = new System.Drawing.Size(182, 24);
            this.comboBoxFind.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сортировка по критерию";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 18);
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
            this.label7.Location = new System.Drawing.Point(1052, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Мастерская \"СделаНо\"";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Мастерская.МастерскаяDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_техникиTableAdapter = null;
            this.tableAdapterManager.Заказ_на_диагностикуTableAdapter = null;
            this.tableAdapterManager.Заказ_на_ремонтTableAdapter = null;
            this.tableAdapterManager.Затраченный_материалTableAdapter = null;
            this.tableAdapterManager.МодельTableAdapter = this.модельTableAdapter;
            this.tableAdapterManager.РаботаTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Тип_поломкиTableAdapter = null;
            this.tableAdapterManager.Тип_устройстваTableAdapter = null;
            // 
            // FormModelDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 578);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormModelDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Модель";
            this.Load += new System.EventHandler(this.FormModelDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.модельBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private МастерскаяDataSet мастерскаяDataSet;
        private System.Windows.Forms.BindingSource модельBindingSource;
        private МастерскаяDataSetTableAdapters.МодельTableAdapter модельTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
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
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.DateTimePicker дата_выпускаDateTimePicker;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private МастерскаяDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn идМоделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
    }
}