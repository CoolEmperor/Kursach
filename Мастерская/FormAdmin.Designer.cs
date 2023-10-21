namespace Мастерская
{
    partial class FormAdmin
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
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label рольLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label адресLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.идСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мастерскаяDataSet = new Мастерская.МастерскаяDataSet();
            this.сотрудникTableAdapter = new Мастерская.МастерскаяDataSetTableAdapters.СотрудникTableAdapter();
            this.tableAdapterManager = new Мастерская.МастерскаяDataSetTableAdapters.TableAdapterManager();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.comboBoxSort1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSort2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFindLogin = new System.Windows.Forms.TextBox();
            this.textBoxFindFam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            рольLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(22, 27);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(69, 16);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(22, 55);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(36, 16);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(22, 83);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(49, 16);
            логинLabel.TabIndex = 7;
            логинLabel.Text = "Логин:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(22, 111);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(59, 16);
            парольLabel.TabIndex = 9;
            парольLabel.Text = "Пароль:";
            // 
            // рольLabel
            // 
            рольLabel.AutoSize = true;
            рольLabel.Location = new System.Drawing.Point(22, 139);
            рольLabel.Name = "рольLabel";
            рольLabel.Size = new System.Drawing.Size(42, 16);
            рольLabel.TabIndex = 11;
            рольLabel.Text = "Роль:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(22, 167);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(70, 16);
            телефонLabel.TabIndex = 13;
            телефонLabel.Text = "Телефон:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(22, 195);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(50, 16);
            адресLabel.TabIndex = 15;
            адресLabel.Text = "Адрес:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идСотрудникаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.логинDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.рольDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сотрудникBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(954, 553);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // идСотрудникаDataGridViewTextBoxColumn
            // 
            this.идСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ИдСотрудника";
            this.идСотрудникаDataGridViewTextBoxColumn.HeaderText = "ИдСотрудника";
            this.идСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.идСотрудникаDataGridViewTextBoxColumn.Name = "идСотрудникаDataGridViewTextBoxColumn";
            this.идСотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.идСотрудникаDataGridViewTextBoxColumn.Visible = false;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            this.логинDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // рольDataGridViewTextBoxColumn
            // 
            this.рольDataGridViewTextBoxColumn.DataPropertyName = "Роль";
            this.рольDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.рольDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.рольDataGridViewTextBoxColumn.Name = "рольDataGridViewTextBoxColumn";
            this.рольDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
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
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Мастерская.МастерскаяDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_техникиTableAdapter = null;
            this.tableAdapterManager.Заказ_на_диагностикуTableAdapter = null;
            this.tableAdapterManager.Заказ_на_ремонтTableAdapter = null;
            this.tableAdapterManager.Затраченный_материалTableAdapter = null;
            this.tableAdapterManager.МодельTableAdapter = null;
            this.tableAdapterManager.РаботаTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = this.сотрудникTableAdapter;
            this.tableAdapterManager.Тип_поломкиTableAdapter = null;
            this.tableAdapterManager.Тип_устройстваTableAdapter = null;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.Location = new System.Drawing.Point(138, 24);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(189, 22);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // имяTextBox
            // 
            this.имяTextBox.Location = new System.Drawing.Point(138, 52);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(189, 22);
            this.имяTextBox.TabIndex = 6;
            // 
            // логинTextBox
            // 
            this.логинTextBox.Location = new System.Drawing.Point(138, 80);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(189, 22);
            this.логинTextBox.TabIndex = 8;
            // 
            // парольTextBox
            // 
            this.парольTextBox.Location = new System.Drawing.Point(138, 108);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(189, 22);
            this.парольTextBox.TabIndex = 10;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.Location = new System.Drawing.Point(138, 164);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(189, 22);
            this.телефонTextBox.TabIndex = 14;
            // 
            // адресTextBox
            // 
            this.адресTextBox.Location = new System.Drawing.Point(138, 192);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(189, 22);
            this.адресTextBox.TabIndex = 16;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(11, 265);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(155, 32);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(172, 266);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(155, 32);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(11, 303);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(316, 32);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.comboBoxRole);
            this.groupBox1.Controls.Add(фамилияLabel);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.адресTextBox);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(адресLabel);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.телефонTextBox);
            this.groupBox1.Controls.Add(телефонLabel);
            this.groupBox1.Controls.Add(this.фамилияTextBox);
            this.groupBox1.Controls.Add(имяLabel);
            this.groupBox1.Controls.Add(рольLabel);
            this.groupBox1.Controls.Add(this.имяTextBox);
            this.groupBox1.Controls.Add(this.парольTextBox);
            this.groupBox1.Controls.Add(логинLabel);
            this.groupBox1.Controls.Add(парольLabel);
            this.groupBox1.Controls.Add(this.логинTextBox);
            this.groupBox1.Location = new System.Drawing.Point(973, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 341);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление, редактирование, удаление";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(11, 228);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(316, 32);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Мастер"});
            this.comboBoxRole.Location = new System.Drawing.Point(138, 137);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(189, 24);
            this.comboBoxRole.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonSort);
            this.groupBox2.Controls.Add(this.comboBoxSort1);
            this.groupBox2.Controls.Add(this.comboBoxSort2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxFindLogin);
            this.groupBox2.Controls.Add(this.textBoxFindFam);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(973, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 213);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск, сортировка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Живой поиск";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Поле";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(62, 171);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(218, 33);
            this.buttonSort.TabIndex = 8;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // comboBoxSort1
            // 
            this.comboBoxSort1.FormattingEnabled = true;
            this.comboBoxSort1.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Логин",
            "Роль",
            "Телефон",
            "Адрес"});
            this.comboBoxSort1.Location = new System.Drawing.Point(125, 111);
            this.comboBoxSort1.Name = "comboBoxSort1";
            this.comboBoxSort1.Size = new System.Drawing.Size(155, 24);
            this.comboBoxSort1.TabIndex = 7;
            // 
            // comboBoxSort2
            // 
            this.comboBoxSort2.FormattingEnabled = true;
            this.comboBoxSort2.Items.AddRange(new object[] {
            "Возрастание",
            "Убывание"});
            this.comboBoxSort2.Location = new System.Drawing.Point(125, 141);
            this.comboBoxSort2.Name = "comboBoxSort2";
            this.comboBoxSort2.Size = new System.Drawing.Size(155, 24);
            this.comboBoxSort2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сортировка по критерию";
            // 
            // textBoxFindLogin
            // 
            this.textBoxFindLogin.Location = new System.Drawing.Point(179, 67);
            this.textBoxFindLogin.Name = "textBoxFindLogin";
            this.textBoxFindLogin.Size = new System.Drawing.Size(160, 22);
            this.textBoxFindLogin.TabIndex = 3;
            this.textBoxFindLogin.TextChanged += new System.EventHandler(this.textBoxFindLogin_TextChanged);
            // 
            // textBoxFindFam
            // 
            this.textBoxFindFam.Location = new System.Drawing.Point(4, 67);
            this.textBoxFindFam.Name = "textBoxFindFam";
            this.textBoxFindFam.Size = new System.Drawing.Size(160, 22);
            this.textBoxFindFam.TabIndex = 2;
            this.textBoxFindFam.TextChanged += new System.EventHandler(this.textBoxFindFam_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поиск по Логину";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по Фамилии";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 578);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAdmin";
            this.Text = "Список пользователей";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерскаяDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private МастерскаяDataSet мастерскаяDataSet;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private МастерскаяDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private МастерскаяDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFindLogin;
        private System.Windows.Forms.TextBox textBoxFindFam;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox comboBoxSort1;
        private System.Windows.Forms.ComboBox comboBoxSort2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn идСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonClear;
    }
}