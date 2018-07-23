namespace Accounting_cartridges
{
    partial class Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExportDepartment = new System.Windows.Forms.Button();
            this.dgwDepartmens = new System.Windows.Forms.DataGridView();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cartridge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpTill = new System.Windows.Forms.DateTimePicker();
            this.dtpSins = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDepartment = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExportCartridgRaport = new System.Windows.Forms.Button();
            this.dgwCartridgeReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpTillCartridgeReport = new System.Windows.Forms.DateTimePicker();
            this.dtpSinsCartridgeReport = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCartridgeReport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCartridgeReport = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbFullMoutheReport = new System.Windows.Forms.ToolStripButton();
            this.tsbAboutProgram = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartmens)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCartridgeReport)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExportDepartment);
            this.tabPage1.Controls.Add(this.dgwDepartmens);
            this.tabPage1.Controls.Add(this.dtpTill);
            this.tabPage1.Controls.Add(this.dtpSins);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnCreateReport);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txbDepartment);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отчет по службам";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExportDepartment
            // 
            this.btnExportDepartment.Location = new System.Drawing.Point(412, 54);
            this.btnExportDepartment.Name = "btnExportDepartment";
            this.btnExportDepartment.Size = new System.Drawing.Size(140, 23);
            this.btnExportDepartment.TabIndex = 9;
            this.btnExportDepartment.Text = "Экспорт отчета";
            this.btnExportDepartment.UseVisualStyleBackColor = true;
            this.btnExportDepartment.Click += new System.EventHandler(this.btnExportDepartment_Click);
            // 
            // dgwDepartmens
            // 
            this.dgwDepartmens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDepartmens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepartmens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Department,
            this.Cartridge,
            this.Quantity});
            this.dgwDepartmens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwDepartmens.Location = new System.Drawing.Point(3, 117);
            this.dgwDepartmens.Name = "dgwDepartmens";
            this.dgwDepartmens.ReadOnly = true;
            this.dgwDepartmens.RowTemplate.ReadOnly = true;
            this.dgwDepartmens.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwDepartmens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDepartmens.Size = new System.Drawing.Size(576, 276);
            this.dgwDepartmens.TabIndex = 8;
            this.dgwDepartmens.TabStop = false;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Department.HeaderText = "Служба";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 70;
            // 
            // Cartridge
            // 
            this.Cartridge.HeaderText = "Картридж";
            this.Cartridge.Name = "Cartridge";
            this.Cartridge.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Количесво";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // dtpTill
            // 
            this.dtpTill.Location = new System.Drawing.Point(262, 54);
            this.dtpTill.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpTill.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpTill.Name = "dtpTill";
            this.dtpTill.Size = new System.Drawing.Size(143, 20);
            this.dtpTill.TabIndex = 7;
            // 
            // dtpSins
            // 
            this.dtpSins.Location = new System.Drawing.Point(68, 54);
            this.dtpSins.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpSins.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpSins.Name = "dtpSins";
            this.dtpSins.Size = new System.Drawing.Size(141, 20);
            this.dtpSins.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "По";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "С";
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(412, 15);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(140, 23);
            this.btnCreateReport.TabIndex = 2;
            this.btnCreateReport.Text = "Составить отчет";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Служба";
            // 
            // txbDepartment
            // 
            this.txbDepartment.AutoCompleteCustomSource.AddRange(new string[] {
            "Вагоноремонтный комплекс",
            "Главная бухгалтерия",
            "Дирекция инфраструктуры",
            "Дирекция МЦК",
            "ДИТС",
            "Дирекция строящегося метрополитена",
            "Контрактная служба",
            "Лаборатория метрологии",
            "Отдел рабочего набжения",
            "Проектно-конструкторское бюро",
            "Служба безопасности",
            "Служба движения",
            "Служба охраны труда",
            "Служба пассажирских сервисов",
            "Служба пути и искусственных сооружений",
            "Служба сбора доходов",
            "Служба управления делами",
            "Служба электроснабжения",
            "Управление метрополитена",
            "Электродепо Братеево",
            "Электродепо Варшавское",
            "Электродепо Выхино",
            "Электродепо Измайлово",
            "Электродепо Калужское",
            "Электродепо Красная Пресня",
            "Электродепо Митино",
            "Электродепо Новогиреево",
            "Электродепо Печатники",
            "Электродепо Свиблово",
            "Электродепо Северное",
            "Электродепо Фили",
            "Электродепо Черкизово",
            "Электродепо Сокол",
            "Юридическая служба",
            "Монорельсовая транспортная система",
            "Служба технической политики",
            "Эскалаторная служба",
            "Казначейство",
            "Служба управления персоналом",
            "Электродепо Замоскворецкое",
            "Медицинская служба",
            "СЦБ",
            "Электродепо Планерное",
            "Служба подвижного состава",
            "Служба имущественно-земельных отношений"});
            this.txbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbDepartment.Location = new System.Drawing.Point(68, 17);
            this.txbDepartment.Name = "txbDepartment";
            this.txbDepartment.Size = new System.Drawing.Size(338, 20);
            this.txbDepartment.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExportCartridgRaport);
            this.tabPage2.Controls.Add(this.dgwCartridgeReport);
            this.tabPage2.Controls.Add(this.dtpTillCartridgeReport);
            this.tabPage2.Controls.Add(this.dtpSinsCartridgeReport);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnCartridgeReport);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txbCartridgeReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчет по картриждам";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExportCartridgRaport
            // 
            this.btnExportCartridgRaport.Location = new System.Drawing.Point(410, 53);
            this.btnExportCartridgRaport.Name = "btnExportCartridgRaport";
            this.btnExportCartridgRaport.Size = new System.Drawing.Size(140, 23);
            this.btnExportCartridgRaport.TabIndex = 16;
            this.btnExportCartridgRaport.Text = "Экспорт отчета";
            this.btnExportCartridgRaport.UseVisualStyleBackColor = true;
            this.btnExportCartridgRaport.Click += new System.EventHandler(this.btnExportCartridgRaport_Click);
            // 
            // dgwCartridgeReport
            // 
            this.dgwCartridgeReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCartridgeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCartridgeReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1});
            this.dgwCartridgeReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwCartridgeReport.Location = new System.Drawing.Point(3, 103);
            this.dgwCartridgeReport.Name = "dgwCartridgeReport";
            this.dgwCartridgeReport.ReadOnly = true;
            this.dgwCartridgeReport.RowTemplate.ReadOnly = true;
            this.dgwCartridgeReport.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCartridgeReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCartridgeReport.Size = new System.Drawing.Size(576, 290);
            this.dgwCartridgeReport.TabIndex = 15;
            this.dgwCartridgeReport.TabStop = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Картридж";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Количесво";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Служба";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dtpTillCartridgeReport
            // 
            this.dtpTillCartridgeReport.Location = new System.Drawing.Point(249, 53);
            this.dtpTillCartridgeReport.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpTillCartridgeReport.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpTillCartridgeReport.Name = "dtpTillCartridgeReport";
            this.dtpTillCartridgeReport.Size = new System.Drawing.Size(144, 20);
            this.dtpTillCartridgeReport.TabIndex = 14;
            // 
            // dtpSinsCartridgeReport
            // 
            this.dtpSinsCartridgeReport.Location = new System.Drawing.Point(79, 53);
            this.dtpSinsCartridgeReport.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpSinsCartridgeReport.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpSinsCartridgeReport.Name = "dtpSinsCartridgeReport";
            this.dtpSinsCartridgeReport.Size = new System.Drawing.Size(137, 20);
            this.dtpSinsCartridgeReport.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "По";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "С";
            // 
            // btnCartridgeReport
            // 
            this.btnCartridgeReport.Location = new System.Drawing.Point(410, 14);
            this.btnCartridgeReport.Name = "btnCartridgeReport";
            this.btnCartridgeReport.Size = new System.Drawing.Size(140, 23);
            this.btnCartridgeReport.TabIndex = 10;
            this.btnCartridgeReport.Text = "Составить отчет";
            this.btnCartridgeReport.UseVisualStyleBackColor = true;
            this.btnCartridgeReport.Click += new System.EventHandler(this.btnCartridgeReport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Картридж";
            // 
            // txbCartridgeReport
            // 
            this.txbCartridgeReport.AutoCompleteCustomSource.AddRange(new string[] {
            "106R01486",
            "106R02183",
            "108R00908, 108R00909",
            "113R00737",
            "C7115A",
            "CC531A (голубой)",
            "CC532A (желтый)",
            "CC533A (пурпурный) ",
            "CD971AE (черный)",
            "CD972AE (голубой)",
            "CD973AE (пурпурный)",
            "CD974AE (желтый)",
            "CE255A (№55A), CE255X (№55X)",
            "CE285A",
            "CE320A (черный)",
            "CE321A (голубой)",
            "CE322A (желтый)",
            "CE323A (пурпурный)",
            "CE410A (черный)",
            "CE411A (голубой)",
            "CE412A (желтый)",
            "CE413A (пурпурный) ",
            "CE505A",
            "CE740A (черный)",
            "CE741A (голубой)",
            "CE742A (желтый)",
            "CE743A (пурпурный)",
            "CF210A (черный)",
            "CF211A (голубой)",
            "CF212A (желтый)",
            "CF213A (пурпурный)",
            "CF214X",
            "CF230A",
            "CF278X",
            "CF280A",
            "CF283X",
            "CF380A (черный)",
            "CF381A (голубой) ",
            "CF382A (желтый)",
            "CF383A (пурпурный) ",
            "CF410A (черный)",
            "CF411A (голубой)",
            "CF412A (желтый)",
            "CF413A (пурпурный)",
            "CG-TN-3380",
            "CLI-36 Color",
            "PGI-35 Black",
            "PL-T67314A (черный)",
            "PL-T67334A (пурпурный)",
            "PL-T67364A (светло-пурпурный)",
            "PL-T67344A (желтый)",
            "PL-T67354A (светло-голубой)",
            "PL-T67324A (голубой)",
            "Q2610A",
            "Q2612A",
            "Q2613A",
            "Q5949A",
            "Q6511A",
            "Q7115A",
            "Q7516A",
            "Q7570A",
            "ricoh 2000",
            "ricoh 201",
            "ricoh 2501",
            "ricoh 2503 (голубой)",
            "ricoh 2503 (желтый)",
            "ricoh 2503 (пурпурный)",
            "ricoh 2503 (черный)",
            "ricoh 3353",
            "ricoh МРС2550Е (голубой)",
            "ricoh МРС2550Е (желтый)",
            "ricoh МРС2550Е (пурпурный)",
            "ricoh МРС2550Е (черный)",
            "ricoh С250E (голубой)",
            "ricoh С250E (желтый)",
            "ricoh С250E (пурпурный)",
            "ricoh С250E (черный)",
            "SP 4500E (барабан)",
            "SP 4500LE, SP 4500E (картридж)",
            "SP3500XE",
            "T6037",
            "TN-321C blue",
            "CE505A"});
            this.txbCartridgeReport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbCartridgeReport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbCartridgeReport.Location = new System.Drawing.Point(79, 16);
            this.txbCartridgeReport.Name = "txbCartridgeReport";
            this.txbCartridgeReport.Size = new System.Drawing.Size(314, 20);
            this.txbCartridgeReport.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFullMoutheReport,
            this.tsbAboutProgram,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(590, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbFullMoutheReport
            // 
            this.tsbFullMoutheReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbFullMoutheReport.Image = ((System.Drawing.Image)(resources.GetObject("tsbFullMoutheReport.Image")));
            this.tsbFullMoutheReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFullMoutheReport.Name = "tsbFullMoutheReport";
            this.tsbFullMoutheReport.Size = new System.Drawing.Size(141, 22);
            this.tsbFullMoutheReport.Text = "Полный отчет за месяц";
            this.tsbFullMoutheReport.Click += new System.EventHandler(this.tsbFullMoutheReport_Click);
            // 
            // tsbAboutProgram
            // 
            this.tsbAboutProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAboutProgram.Image = ((System.Drawing.Image)(resources.GetObject("tsbAboutProgram.Image")));
            this.tsbAboutProgram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAboutProgram.Name = "tsbAboutProgram";
            this.tsbAboutProgram.Size = new System.Drawing.Size(86, 22);
            this.tsbAboutProgram.Text = "О программе";
            this.tsbAboutProgram.Click += new System.EventHandler(this.tsbAboutProgram_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(45, 22);
            this.tsbExit.Text = "Выход";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Request";
            this.Text = "Request";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Request_FormClosing);
            this.Load += new System.EventHandler(this.Request_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartmens)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCartridgeReport)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDepartment;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbFullMoutheReport;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.DateTimePicker dtpTill;
        private System.Windows.Forms.DateTimePicker dtpSins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTillCartridgeReport;
        private System.Windows.Forms.DateTimePicker dtpSinsCartridgeReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCartridgeReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCartridgeReport;
        private System.Windows.Forms.DataGridView dgwDepartmens;
        private System.Windows.Forms.DataGridView dgwCartridgeReport;
        private System.Windows.Forms.Button btnExportDepartment;
        private System.Windows.Forms.ToolStripButton tsbAboutProgram;
        private System.Windows.Forms.Button btnExportCartridgRaport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cartridge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}