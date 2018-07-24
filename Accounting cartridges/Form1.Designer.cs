namespace Accounting_cartridges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbReport = new System.Windows.Forms.ToolStripButton();
            this.tsbAboutProgram = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpbNewItem = new System.Windows.Forms.TabPage();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnReserv = new System.Windows.Forms.Button();
            this.dgwInventaryCheck = new System.Windows.Forms.DataGridView();
            this.InventeryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartridgeCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpInPut = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbCartridge = new System.Windows.Forms.RichTextBox();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbDepartment = new System.Windows.Forms.TextBox();
            this.txbCartridge = new System.Windows.Forms.TextBox();
            this.txbInventoryNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbRequest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCheck = new System.Windows.Forms.Button();
            this.tbpChangeItem = new System.Windows.Forms.TabPage();
            this.btnOrderChange = new System.Windows.Forms.Button();
            this.btnBuyChange = new System.Windows.Forms.Button();
            this.btnReservChange = new System.Windows.Forms.Button();
            this.btnAddChange = new System.Windows.Forms.Button();
            this.btnSerchChange = new System.Windows.Forms.Button();
            this.txbCartridgeChange = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbRequestIdChange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvChage = new System.Windows.Forms.DataGridView();
            this.colIDChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrintID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartridge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStutus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpDeleteItem = new System.Windows.Forms.TabPage();
            this.dgvDelete = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchDelete = new System.Windows.Forms.Button();
            this.txbReqestIDDelete = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpbNewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInventaryCheck)).BeginInit();
            this.tbpChangeItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChage)).BeginInit();
            this.tbpDeleteItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReport,
            this.tsbAboutProgram,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(626, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbReport
            // 
            this.tsbReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReport.Image = ((System.Drawing.Image)(resources.GetObject("tsbReport.Image")));
            this.tsbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReport.Name = "tsbReport";
            this.tsbReport.Size = new System.Drawing.Size(43, 22);
            this.tsbReport.Text = "Отчет";
            this.tsbReport.Click += new System.EventHandler(this.tsbReport_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpbNewItem);
            this.tabControl1.Controls.Add(this.tbpChangeItem);
            this.tabControl1.Controls.Add(this.tbpDeleteItem);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 358);
            this.tabControl1.TabIndex = 1;
            // 
            // tpbNewItem
            // 
            this.tpbNewItem.Controls.Add(this.btnOrder);
            this.tpbNewItem.Controls.Add(this.btnPurchase);
            this.tpbNewItem.Controls.Add(this.btnReserv);
            this.tpbNewItem.Controls.Add(this.dgwInventaryCheck);
            this.tpbNewItem.Controls.Add(this.dtpInPut);
            this.tpbNewItem.Controls.Add(this.label7);
            this.tpbNewItem.Controls.Add(this.rtbCartridge);
            this.tpbNewItem.Controls.Add(this.txbQuantity);
            this.tpbNewItem.Controls.Add(this.label8);
            this.tpbNewItem.Controls.Add(this.btnAdd);
            this.tpbNewItem.Controls.Add(this.txbDepartment);
            this.tpbNewItem.Controls.Add(this.txbCartridge);
            this.tpbNewItem.Controls.Add(this.txbInventoryNumber);
            this.tpbNewItem.Controls.Add(this.label5);
            this.tpbNewItem.Controls.Add(this.label4);
            this.tpbNewItem.Controls.Add(this.label3);
            this.tpbNewItem.Controls.Add(this.label2);
            this.tpbNewItem.Controls.Add(this.txbRequest);
            this.tpbNewItem.Controls.Add(this.label1);
            this.tpbNewItem.Controls.Add(this.txbCheck);
            this.tpbNewItem.Location = new System.Drawing.Point(4, 22);
            this.tpbNewItem.Name = "tpbNewItem";
            this.tpbNewItem.Padding = new System.Windows.Forms.Padding(3);
            this.tpbNewItem.Size = new System.Drawing.Size(618, 332);
            this.tpbNewItem.TabIndex = 0;
            this.tpbNewItem.Text = "Новая запись";
            this.tpbNewItem.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(377, 303);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(79, 23);
            this.btnOrder.TabIndex = 47;
            this.btnOrder.Text = "Заказ";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(530, 303);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(80, 23);
            this.btnPurchase.TabIndex = 46;
            this.btnPurchase.Text = "Закупка";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click_1);
            // 
            // btnReserv
            // 
            this.btnReserv.Location = new System.Drawing.Point(143, 303);
            this.btnReserv.Name = "btnReserv";
            this.btnReserv.Size = new System.Drawing.Size(82, 23);
            this.btnReserv.TabIndex = 45;
            this.btnReserv.Text = "Резерв";
            this.btnReserv.UseVisualStyleBackColor = true;
            this.btnReserv.Click += new System.EventHandler(this.btnReserv_Click_1);
            // 
            // dgwInventaryCheck
            // 
            this.dgwInventaryCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwInventaryCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInventaryCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventeryNumber,
            this.CartridgeCheck,
            this.QuantityAdd,
            this.colStatusNew});
            this.dgwInventaryCheck.Location = new System.Drawing.Point(11, 167);
            this.dgwInventaryCheck.Name = "dgwInventaryCheck";
            this.dgwInventaryCheck.Size = new System.Drawing.Size(334, 123);
            this.dgwInventaryCheck.TabIndex = 44;
            // 
            // InventeryNumber
            // 
            this.InventeryNumber.HeaderText = "Инвентарный номер";
            this.InventeryNumber.Name = "InventeryNumber";
            this.InventeryNumber.ReadOnly = true;
            // 
            // CartridgeCheck
            // 
            this.CartridgeCheck.HeaderText = "Картридж";
            this.CartridgeCheck.Name = "CartridgeCheck";
            this.CartridgeCheck.ReadOnly = true;
            // 
            // QuantityAdd
            // 
            this.QuantityAdd.HeaderText = "Количество";
            this.QuantityAdd.Name = "QuantityAdd";
            this.QuantityAdd.ReadOnly = true;
            // 
            // colStatusNew
            // 
            this.colStatusNew.HeaderText = "Статус";
            this.colStatusNew.Name = "colStatusNew";
            // 
            // dtpInPut
            // 
            this.dtpInPut.Location = new System.Drawing.Point(445, 270);
            this.dtpInPut.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpInPut.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpInPut.Name = "dtpInPut";
            this.dtpInPut.Size = new System.Drawing.Size(165, 20);
            this.dtpInPut.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(282, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // rtbCartridge
            // 
            this.rtbCartridge.Location = new System.Drawing.Point(354, 3);
            this.rtbCartridge.Name = "rtbCartridge";
            this.rtbCartridge.ReadOnly = true;
            this.rtbCartridge.Size = new System.Drawing.Size(256, 128);
            this.rtbCartridge.TabIndex = 41;
            this.rtbCartridge.Text = "";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(445, 230);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(165, 20);
            this.txbQuantity.TabIndex = 40;
            this.txbQuantity.Text = "1";
            this.txbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Количество";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 23);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Выдать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
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
            this.txbDepartment.Location = new System.Drawing.Point(126, 111);
            this.txbDepartment.Name = "txbDepartment";
            this.txbDepartment.Size = new System.Drawing.Size(219, 20);
            this.txbDepartment.TabIndex = 36;
            // 
            // txbCartridge
            // 
            this.txbCartridge.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.txbCartridge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbCartridge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbCartridge.Location = new System.Drawing.Point(445, 187);
            this.txbCartridge.Name = "txbCartridge";
            this.txbCartridge.Size = new System.Drawing.Size(165, 20);
            this.txbCartridge.TabIndex = 35;
            this.txbCartridge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbInventoryNumber
            // 
            this.txbInventoryNumber.Location = new System.Drawing.Point(126, 54);
            this.txbInventoryNumber.Name = "txbInventoryNumber";
            this.txbInventoryNumber.Size = new System.Drawing.Size(219, 20);
            this.txbInventoryNumber.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Служба";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Картридж";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Инвинтарный номер";
            // 
            // txbRequest
            // 
            this.txbRequest.Location = new System.Drawing.Point(126, 3);
            this.txbRequest.Name = "txbRequest";
            this.txbRequest.Size = new System.Drawing.Size(219, 20);
            this.txbRequest.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "№ заявки";
            // 
            // txbCheck
            // 
            this.txbCheck.Location = new System.Drawing.Point(398, 137);
            this.txbCheck.Name = "txbCheck";
            this.txbCheck.Size = new System.Drawing.Size(183, 23);
            this.txbCheck.TabIndex = 27;
            this.txbCheck.Text = "Проверка инвентарного номера";
            this.txbCheck.UseVisualStyleBackColor = true;
            this.txbCheck.Click += new System.EventHandler(this.txbCheck_Click);
            // 
            // tbpChangeItem
            // 
            this.tbpChangeItem.Controls.Add(this.btnOrderChange);
            this.tbpChangeItem.Controls.Add(this.btnBuyChange);
            this.tbpChangeItem.Controls.Add(this.btnReservChange);
            this.tbpChangeItem.Controls.Add(this.btnAddChange);
            this.tbpChangeItem.Controls.Add(this.btnSerchChange);
            this.tbpChangeItem.Controls.Add(this.txbCartridgeChange);
            this.tbpChangeItem.Controls.Add(this.label10);
            this.tbpChangeItem.Controls.Add(this.txbRequestIdChange);
            this.tbpChangeItem.Controls.Add(this.label6);
            this.tbpChangeItem.Controls.Add(this.dgvChage);
            this.tbpChangeItem.Location = new System.Drawing.Point(4, 22);
            this.tbpChangeItem.Name = "tbpChangeItem";
            this.tbpChangeItem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpChangeItem.Size = new System.Drawing.Size(618, 332);
            this.tbpChangeItem.TabIndex = 2;
            this.tbpChangeItem.Text = "Изменение записи";
            this.tbpChangeItem.UseVisualStyleBackColor = true;
            // 
            // btnOrderChange
            // 
            this.btnOrderChange.Location = new System.Drawing.Point(320, 55);
            this.btnOrderChange.Name = "btnOrderChange";
            this.btnOrderChange.Size = new System.Drawing.Size(138, 23);
            this.btnOrderChange.TabIndex = 51;
            this.btnOrderChange.Text = "Заказ";
            this.btnOrderChange.UseVisualStyleBackColor = true;
            this.btnOrderChange.Click += new System.EventHandler(this.btnOrderChange_Click);
            // 
            // btnBuyChange
            // 
            this.btnBuyChange.Location = new System.Drawing.Point(464, 55);
            this.btnBuyChange.Name = "btnBuyChange";
            this.btnBuyChange.Size = new System.Drawing.Size(129, 23);
            this.btnBuyChange.TabIndex = 50;
            this.btnBuyChange.Text = "Закупка";
            this.btnBuyChange.UseVisualStyleBackColor = true;
            this.btnBuyChange.Click += new System.EventHandler(this.btnBuyChange_Click);
            // 
            // btnReservChange
            // 
            this.btnReservChange.Location = new System.Drawing.Point(161, 55);
            this.btnReservChange.Name = "btnReservChange";
            this.btnReservChange.Size = new System.Drawing.Size(153, 23);
            this.btnReservChange.TabIndex = 49;
            this.btnReservChange.Text = "Резерв";
            this.btnReservChange.UseVisualStyleBackColor = true;
            this.btnReservChange.Click += new System.EventHandler(this.btnReservChange_Click);
            // 
            // btnAddChange
            // 
            this.btnAddChange.Location = new System.Drawing.Point(11, 55);
            this.btnAddChange.Name = "btnAddChange";
            this.btnAddChange.Size = new System.Drawing.Size(144, 23);
            this.btnAddChange.TabIndex = 48;
            this.btnAddChange.Text = "Выдать";
            this.btnAddChange.UseVisualStyleBackColor = true;
            this.btnAddChange.Click += new System.EventHandler(this.btnAddChange_Click);
            // 
            // btnSerchChange
            // 
            this.btnSerchChange.Location = new System.Drawing.Point(390, 11);
            this.btnSerchChange.Name = "btnSerchChange";
            this.btnSerchChange.Size = new System.Drawing.Size(203, 23);
            this.btnSerchChange.TabIndex = 45;
            this.btnSerchChange.Text = "Найти";
            this.btnSerchChange.UseVisualStyleBackColor = true;
            this.btnSerchChange.Click += new System.EventHandler(this.btnSerchChange_Click);
            // 
            // txbCartridgeChange
            // 
            this.txbCartridgeChange.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.txbCartridgeChange.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbCartridgeChange.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbCartridgeChange.Location = new System.Drawing.Point(261, 13);
            this.txbCartridgeChange.Name = "txbCartridgeChange";
            this.txbCartridgeChange.Size = new System.Drawing.Size(112, 20);
            this.txbCartridgeChange.TabIndex = 42;
            this.txbCartridgeChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Картридж";
            // 
            // txbRequestIdChange
            // 
            this.txbRequestIdChange.Location = new System.Drawing.Point(71, 13);
            this.txbRequestIdChange.Name = "txbRequestIdChange";
            this.txbRequestIdChange.Size = new System.Drawing.Size(121, 20);
            this.txbRequestIdChange.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "№ заявки";
            // 
            // dgvChage
            // 
            this.dgvChage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDChange,
            this.colRequestID,
            this.colPrintID,
            this.colCartridge,
            this.colQuantityChange,
            this.colStutus});
            this.dgvChage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChage.Location = new System.Drawing.Point(3, 84);
            this.dgvChage.Name = "dgvChage";
            this.dgvChage.Size = new System.Drawing.Size(612, 245);
            this.dgvChage.TabIndex = 0;
            this.dgvChage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChage_CellClick);
            // 
            // colIDChange
            // 
            this.colIDChange.HeaderText = "ID";
            this.colIDChange.Name = "colIDChange";
            // 
            // colRequestID
            // 
            this.colRequestID.HeaderText = "Номер заявки";
            this.colRequestID.Name = "colRequestID";
            // 
            // colPrintID
            // 
            this.colPrintID.HeaderText = "Инвентарный номер";
            this.colPrintID.Name = "colPrintID";
            // 
            // colCartridge
            // 
            this.colCartridge.HeaderText = "Картридж";
            this.colCartridge.Name = "colCartridge";
            // 
            // colQuantityChange
            // 
            this.colQuantityChange.HeaderText = "Количетсво";
            this.colQuantityChange.Name = "colQuantityChange";
            // 
            // colStutus
            // 
            this.colStutus.HeaderText = "Статус";
            this.colStutus.Name = "colStutus";
            // 
            // tbpDeleteItem
            // 
            this.tbpDeleteItem.Controls.Add(this.dgvDelete);
            this.tbpDeleteItem.Controls.Add(this.btnDelete);
            this.tbpDeleteItem.Controls.Add(this.btnSearchDelete);
            this.tbpDeleteItem.Controls.Add(this.txbReqestIDDelete);
            this.tbpDeleteItem.Controls.Add(this.label11);
            this.tbpDeleteItem.Location = new System.Drawing.Point(4, 22);
            this.tbpDeleteItem.Name = "tbpDeleteItem";
            this.tbpDeleteItem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDeleteItem.Size = new System.Drawing.Size(618, 332);
            this.tbpDeleteItem.TabIndex = 3;
            this.tbpDeleteItem.Text = "Удаление записи";
            this.tbpDeleteItem.UseVisualStyleBackColor = true;
            // 
            // dgvDelete
            // 
            this.dgvDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDelete.Location = new System.Drawing.Point(3, 46);
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.Size = new System.Drawing.Size(612, 283);
            this.dgvDelete.TabIndex = 50;
            this.dgvDelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelete_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер заявки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Инвентарный номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Картридж";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(506, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearchDelete
            // 
            this.btnSearchDelete.Location = new System.Drawing.Point(375, 17);
            this.btnSearchDelete.Name = "btnSearchDelete";
            this.btnSearchDelete.Size = new System.Drawing.Size(107, 23);
            this.btnSearchDelete.TabIndex = 48;
            this.btnSearchDelete.Text = "Найти";
            this.btnSearchDelete.UseVisualStyleBackColor = true;
            this.btnSearchDelete.Click += new System.EventHandler(this.btnSearchDelete_Click);
            // 
            // txbReqestIDDelete
            // 
            this.txbReqestIDDelete.Location = new System.Drawing.Point(130, 19);
            this.txbReqestIDDelete.Name = "txbReqestIDDelete";
            this.txbReqestIDDelete.Size = new System.Drawing.Size(214, 20);
            this.txbReqestIDDelete.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "№ заявки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 383);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Учет картриджей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpbNewItem.ResumeLayout(false);
            this.tpbNewItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInventaryCheck)).EndInit();
            this.tbpChangeItem.ResumeLayout(false);
            this.tbpChangeItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChage)).EndInit();
            this.tbpDeleteItem.ResumeLayout(false);
            this.tbpDeleteItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripButton tsbReport;
        private System.Windows.Forms.ToolStripButton tsbAboutProgram;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpbNewItem;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnReserv;
        private System.Windows.Forms.DataGridView dgwInventaryCheck;
        private System.Windows.Forms.DateTimePicker dtpInPut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbCartridge;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbDepartment;
        private System.Windows.Forms.TextBox txbCartridge;
        private System.Windows.Forms.TextBox txbInventoryNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txbCheck;
        private System.Windows.Forms.TabPage tbpChangeItem;
        private System.Windows.Forms.TabPage tbpDeleteItem;
        private System.Windows.Forms.TextBox txbRequestIdChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvChage;
        private System.Windows.Forms.TextBox txbCartridgeChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOrderChange;
        private System.Windows.Forms.Button btnBuyChange;
        private System.Windows.Forms.Button btnReservChange;
        private System.Windows.Forms.Button btnAddChange;
        private System.Windows.Forms.Button btnSerchChange;
        private System.Windows.Forms.DataGridView dgvDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchDelete;
        private System.Windows.Forms.TextBox txbReqestIDDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrintID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartridge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStutus;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventeryNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartridgeCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusNew;
    }
}

