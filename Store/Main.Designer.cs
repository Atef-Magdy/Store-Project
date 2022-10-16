using System.Threading;
using System.Windows.Forms;

namespace Store
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.صنفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشترياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton6 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.بالصنفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.برقمالفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فاتورةبيعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton8 = new System.Windows.Forms.ToolStripDropDownButton();
            this.مصاريفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.itemsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.ربحعنفترةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.أسمصنفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الوحدةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سعرصنفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.المستخدمونToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton7 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addItem = new System.Windows.Forms.Panel();
            this.cancelBuyBill = new System.Windows.Forms.Button();
            this.buyItemsDG = new System.Windows.Forms.DataGridView();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label71 = new System.Windows.Forms.Label();
            this.buyTotalPriceCheck = new System.Windows.Forms.TextBox();
            this.endBill = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.detailsLamp = new System.Windows.Forms.Label();
            this.sPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.itemBtn = new System.Windows.Forms.Button();
            this.bPrice = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.itemQuantity = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.billImage = new System.Windows.Forms.Button();
            this.billLamp = new System.Windows.Forms.Label();
            this.addBill = new System.Windows.Forms.Button();
            this.billDate = new System.Windows.Forms.DateTimePicker();
            this.billPrice = new System.Windows.Forms.TextBox();
            this.incName = new System.Windows.Forms.TextBox();
            this.billNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.password = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dbSource = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.editDB = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.Panel();
            this.customersPayments = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label68 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.payMoney = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.payments = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.printSaleBill = new System.Windows.Forms.Button();
            this.payingAmount = new System.Windows.Forms.NumericUpDown();
            this.label58 = new System.Windows.Forms.Label();
            this.currentBill = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.previousAmount = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.sale = new System.Windows.Forms.Panel();
            this.cancelSaleBill = new System.Windows.Forms.Button();
            this.continueSaleBill = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saleQuantity = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.saleBillGrid = new System.Windows.Forms.DataGridView();
            this.saleGridItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleGridQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleGridUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleGridTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleAddItem = new System.Windows.Forms.Button();
            this.saleItemName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saleBillDate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.addSaleBill = new System.Windows.Forms.Button();
            this.saleTotalPrice = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.saleBillNumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.updatePrice = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.itemFilter = new System.Windows.Forms.TextBox();
            this.updatePriceDG = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.currcentName = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.updatePriceBtn = new System.Windows.Forms.Button();
            this.newPrice = new System.Windows.Forms.TextBox();
            this.curentPrice = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.itemSearch = new System.Windows.Forms.Panel();
            this.itemsSearchGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saleBillSearchDetails = new System.Windows.Forms.Panel();
            this.printAgain = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saleBillSearchDetailsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label22 = new System.Windows.Forms.Label();
            this.saleBillSearch = new System.Windows.Forms.Panel();
            this.saleBillSearchGrid = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.itemsDetails = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.updateNames = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.updateCustomerName = new System.Windows.Forms.Button();
            this.customerNewName = new System.Windows.Forms.TextBox();
            this.customerOldName = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.updateItemName = new System.Windows.Forms.Button();
            this.itemNewName = new System.Windows.Forms.TextBox();
            this.itemOldName = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.buyBillSearchDetails = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buyBillImage = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.units = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.updateUnitBtn = new System.Windows.Forms.Button();
            this.UunitNewName = new System.Windows.Forms.TextBox();
            this.UunitOldName = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.addUnitBtn = new System.Windows.Forms.Button();
            this.AunitName = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.users = new System.Windows.Forms.Panel();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.passwordBX = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.userRoleX = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.updateUser = new System.Windows.Forms.Button();
            this.userRealNameX = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.usersDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label54 = new System.Windows.Forms.Label();
            this.passwordB = new System.Windows.Forms.TextBox();
            this.userRole = new System.Windows.Forms.ComboBox();
            this.userRealName = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.addUser = new System.Windows.Forms.Button();
            this.userNameB = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.buyBillSearch = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.buyBillincNameSearch = new System.Windows.Forms.TextBox();
            this.buyBillSearchGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buyBillNumberSearch = new System.Windows.Forms.TextBox();
            this.itemWithoutBill = new System.Windows.Forms.Panel();
            this.itemDateX = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.itemSalePriceX = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.itemUnitX = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.itemQuantityX = new System.Windows.Forms.NumericUpDown();
            this.addItemBtnX = new System.Windows.Forms.Button();
            this.itemBuyPriceX = new System.Windows.Forms.TextBox();
            this.itemNameX = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Panel();
            this.label61 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reports = new System.Windows.Forms.Panel();
            this.CRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.statusStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.addItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyItemsDG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.login.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.customersPayments.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.payments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payingAmount)).BeginInit();
            this.sale.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBillGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.updatePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatePriceDG)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.itemSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSearchGrid)).BeginInit();
            this.saleBillSearchDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBillSearchDetailsGrid)).BeginInit();
            this.saleBillSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBillSearchGrid)).BeginInit();
            this.itemsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.updateNames.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.buyBillSearchDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyBillImage)).BeginInit();
            this.units.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDG)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.buyBillSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyBillSearchGrid)).BeginInit();
            this.itemWithoutBill.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantityX)).BeginInit();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.reports.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(97)))), ((int)(((byte)(199)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton6,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton8,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton5,
            this.toolStripDropDownButton7,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1244, 34);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(97)))), ((int)(((byte)(199)))));
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.صنفToolStripMenuItem,
            this.مشترياتToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(95)))), ((int)(((byte)(181)))));
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 32);
            this.toolStripDropDownButton1.Text = "إضافة";
            // 
            // صنفToolStripMenuItem
            // 
            this.صنفToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(95)))), ((int)(((byte)(181)))));
            this.صنفToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.صنفToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.صنفToolStripMenuItem.Name = "صنفToolStripMenuItem";
            this.صنفToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.صنفToolStripMenuItem.Text = "فاتورة";
            this.صنفToolStripMenuItem.Click += new System.EventHandler(this.صنفToolStripMenuItem_Click);
            // 
            // مشترياتToolStripMenuItem
            // 
            this.مشترياتToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(95)))), ((int)(((byte)(181)))));
            this.مشترياتToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.مشترياتToolStripMenuItem.Name = "مشترياتToolStripMenuItem";
            this.مشترياتToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.مشترياتToolStripMenuItem.Text = "أصناف بدون فاتورة";
            this.مشترياتToolStripMenuItem.Click += new System.EventHandler(this.مشترياتToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton6
            // 
            this.toolStripDropDownButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripDropDownButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.toolStripDropDownButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton6.Image")));
            this.toolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton6.Margin = new System.Windows.Forms.Padding(0, 2, 5, 2);
            this.toolStripDropDownButton6.Name = "toolStripDropDownButton6";
            this.toolStripDropDownButton6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripDropDownButton6.ShowDropDownArrow = false;
            this.toolStripDropDownButton6.Size = new System.Drawing.Size(33, 30);
            this.toolStripDropDownButton6.Text = "بيع";
            this.toolStripDropDownButton6.ToolTipText = "بيع";
            this.toolStripDropDownButton6.Click += new System.EventHandler(this.toolStripDropDownButton6_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بالصنفToolStripMenuItem,
            this.برقمالفاتورةToolStripMenuItem,
            this.فاتورةبيعToolStripMenuItem});
            this.toolStripDropDownButton3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripDropDownButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Margin = new System.Windows.Forms.Padding(0, 2, 5, 0);
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(50, 32);
            this.toolStripDropDownButton3.Text = "بحث";
            // 
            // بالصنفToolStripMenuItem
            // 
            this.بالصنفToolStripMenuItem.Name = "بالصنفToolStripMenuItem";
            this.بالصنفToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.بالصنفToolStripMenuItem.Text = "الأصناف";
            this.بالصنفToolStripMenuItem.Click += new System.EventHandler(this.بالصنفToolStripMenuItem_Click);
            // 
            // برقمالفاتورةToolStripMenuItem
            // 
            this.برقمالفاتورةToolStripMenuItem.Name = "برقمالفاتورةToolStripMenuItem";
            this.برقمالفاتورةToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.برقمالفاتورةToolStripMenuItem.Text = "فاتورة شراء";
            this.برقمالفاتورةToolStripMenuItem.Click += new System.EventHandler(this.برقمالفاتورةToolStripMenuItem_Click);
            // 
            // فاتورةبيعToolStripMenuItem
            // 
            this.فاتورةبيعToolStripMenuItem.Name = "فاتورةبيعToolStripMenuItem";
            this.فاتورةبيعToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.فاتورةبيعToolStripMenuItem.Text = "فاتورة بيع";
            this.فاتورةبيعToolStripMenuItem.Click += new System.EventHandler(this.فاتورةبيعToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton8
            // 
            this.toolStripDropDownButton8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مصاريفToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.toolStripDropDownButton8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripDropDownButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.toolStripDropDownButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton8.Image")));
            this.toolStripDropDownButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton8.Name = "toolStripDropDownButton8";
            this.toolStripDropDownButton8.Size = new System.Drawing.Size(70, 32);
            this.toolStripDropDownButton8.Text = "حسابات";
            // 
            // مصاريفToolStripMenuItem
            // 
            this.مصاريفToolStripMenuItem.Name = "مصاريفToolStripMenuItem";
            this.مصاريفToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.مصاريفToolStripMenuItem.Text = "مصاريف";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 26);
            this.toolStripMenuItem1.Text = "أصناف";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(134, 26);
            this.toolStripMenuItem2.Text = "عملاء";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsReport,
            this.ربحعنفترةToolStripMenuItem});
            this.toolStripDropDownButton2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripDropDownButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Margin = new System.Windows.Forms.Padding(0, 2, 5, 0);
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(59, 32);
            this.toolStripDropDownButton2.Text = "تقارير";
            this.toolStripDropDownButton2.ToolTipText = "تقارير";
            // 
            // itemsReport
            // 
            this.itemsReport.Name = "itemsReport";
            this.itemsReport.Size = new System.Drawing.Size(177, 26);
            this.itemsReport.Text = "جرد أصناف";
            this.itemsReport.Click += new System.EventHandler(this.itemsReport_Click);
            // 
            // ربحعنفترةToolStripMenuItem
            // 
            this.ربحعنفترةToolStripMenuItem.Name = "ربحعنفترةToolStripMenuItem";
            this.ربحعنفترةToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.ربحعنفترةToolStripMenuItem.Text = "مبيعات عن فترة";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.أسمصنفToolStripMenuItem,
            this.الوحدةToolStripMenuItem,
            this.سعرصنفToolStripMenuItem});
            this.toolStripDropDownButton4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripDropDownButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Margin = new System.Windows.Forms.Padding(0, 2, 5, 0);
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(69, 32);
            this.toolStripDropDownButton4.Text = "تعديلات";
            // 
            // أسمصنفToolStripMenuItem
            // 
            this.أسمصنفToolStripMenuItem.Name = "أسمصنفToolStripMenuItem";
            this.أسمصنفToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.أسمصنفToolStripMenuItem.Text = "أسماء";
            this.أسمصنفToolStripMenuItem.Click += new System.EventHandler(this.أسمصنفToolStripMenuItem_Click);
            // 
            // الوحدةToolStripMenuItem
            // 
            this.الوحدةToolStripMenuItem.Name = "الوحدةToolStripMenuItem";
            this.الوحدةToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.الوحدةToolStripMenuItem.Text = "الوحدة";
            this.الوحدةToolStripMenuItem.Click += new System.EventHandler(this.الوحدةToolStripMenuItem_Click);
            // 
            // سعرصنفToolStripMenuItem
            // 
            this.سعرصنفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("سعرصنفToolStripMenuItem.Image")));
            this.سعرصنفToolStripMenuItem.Name = "سعرصنفToolStripMenuItem";
            this.سعرصنفToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.سعرصنفToolStripMenuItem.Text = "سعر صنف";
            this.سعرصنفToolStripMenuItem.Click += new System.EventHandler(this.سعرصنفToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.المستخدمونToolStripMenuItem});
            this.toolStripDropDownButton5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripDropDownButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(71, 32);
            this.toolStripDropDownButton5.Text = "إعدادات";
            // 
            // المستخدمونToolStripMenuItem
            // 
            this.المستخدمونToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("المستخدمونToolStripMenuItem.Image")));
            this.المستخدمونToolStripMenuItem.Name = "المستخدمونToolStripMenuItem";
            this.المستخدمونToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.المستخدمونToolStripMenuItem.Text = "المستخدمون";
            this.المستخدمونToolStripMenuItem.Click += new System.EventHandler(this.المستخدمونToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton7
            // 
            this.toolStripDropDownButton7.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.toolStripDropDownButton7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripDropDownButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.toolStripDropDownButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripDropDownButton7.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripDropDownButton7.Name = "toolStripDropDownButton7";
            this.toolStripDropDownButton7.ShowDropDownArrow = false;
            this.toolStripDropDownButton7.Size = new System.Drawing.Size(51, 29);
            this.toolStripDropDownButton7.Text = "رجوع";
            this.toolStripDropDownButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripDropDownButton7.ToolTipText = "رجوع";
            this.toolStripDropDownButton7.Click += new System.EventHandler(this.toolStripDropDownButton7_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.ShowDropDownArrow = false;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 29);
            this.toolStripStatusLabel1.Text = "خروج";
            this.toolStripStatusLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.addItem);
            this.mainPanel.Controls.Add(this.login);
            this.mainPanel.Controls.Add(this.background);
            this.mainPanel.Controls.Add(this.customersPayments);
            this.mainPanel.Controls.Add(this.payments);
            this.mainPanel.Controls.Add(this.sale);
            this.mainPanel.Controls.Add(this.updatePrice);
            this.mainPanel.Controls.Add(this.itemSearch);
            this.mainPanel.Controls.Add(this.saleBillSearchDetails);
            this.mainPanel.Controls.Add(this.saleBillSearch);
            this.mainPanel.Controls.Add(this.itemsDetails);
            this.mainPanel.Controls.Add(this.updateNames);
            this.mainPanel.Controls.Add(this.buyBillSearchDetails);
            this.mainPanel.Controls.Add(this.units);
            this.mainPanel.Controls.Add(this.users);
            this.mainPanel.Controls.Add(this.buyBillSearch);
            this.mainPanel.Controls.Add(this.itemWithoutBill);
            this.mainPanel.Controls.Add(this.settings);
            this.mainPanel.Controls.Add(this.reports);
            this.mainPanel.Controls.Add(this.statusStrip1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1244, 749);
            this.mainPanel.TabIndex = 1;
            // 
            // addItem
            // 
            this.addItem.BackColor = System.Drawing.Color.White;
            this.addItem.Controls.Add(this.cancelBuyBill);
            this.addItem.Controls.Add(this.buyItemsDG);
            this.addItem.Controls.Add(this.label71);
            this.addItem.Controls.Add(this.buyTotalPriceCheck);
            this.addItem.Controls.Add(this.endBill);
            this.addItem.Controls.Add(this.groupBox2);
            this.addItem.Controls.Add(this.groupBox1);
            this.addItem.Controls.Add(this.label1);
            this.addItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addItem.Location = new System.Drawing.Point(0, 34);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(1244, 715);
            this.addItem.TabIndex = 0;
            // 
            // cancelBuyBill
            // 
            this.cancelBuyBill.BackColor = System.Drawing.Color.Red;
            this.cancelBuyBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBuyBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cancelBuyBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cancelBuyBill.Location = new System.Drawing.Point(86, 571);
            this.cancelBuyBill.Name = "cancelBuyBill";
            this.cancelBuyBill.Size = new System.Drawing.Size(121, 52);
            this.cancelBuyBill.TabIndex = 13;
            this.cancelBuyBill.Text = "إلغاء الفاتورة";
            this.cancelBuyBill.UseVisualStyleBackColor = false;
            this.cancelBuyBill.Click += new System.EventHandler(this.cancelBuyBill_Click);
            // 
            // buyItemsDG
            // 
            this.buyItemsDG.AllowUserToAddRows = false;
            this.buyItemsDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buyItemsDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buyItemsDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buyItemsDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.buyItemsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyItemsDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24});
            this.buyItemsDG.Location = new System.Drawing.Point(308, 486);
            this.buyItemsDG.MultiSelect = false;
            this.buyItemsDG.Name = "buyItemsDG";
            this.buyItemsDG.ReadOnly = true;
            this.buyItemsDG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arabic Transparent", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buyItemsDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arabic Transparent", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.buyItemsDG.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.buyItemsDG.Size = new System.Drawing.Size(926, 226);
            this.buyItemsDG.TabIndex = 12;
            this.buyItemsDG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buyItemsDG_CellDoubleClick);
            this.buyItemsDG.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.buyItemsDG_UserDeletingRow);
            // 
            // Column20
            // 
            this.Column20.HeaderText = "أسم الصنف";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "الكمية";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "الوحدة";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "سعر الشراء";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "سعر البيع";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(90, 511);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(114, 20);
            this.label71.TabIndex = 11;
            this.label71.Text = "إجمالى المشتريات";
            // 
            // buyTotalPriceCheck
            // 
            this.buyTotalPriceCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.buyTotalPriceCheck.Enabled = false;
            this.buyTotalPriceCheck.Font = new System.Drawing.Font("Arabic Transparent", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buyTotalPriceCheck.Location = new System.Drawing.Point(86, 538);
            this.buyTotalPriceCheck.Name = "buyTotalPriceCheck";
            this.buyTotalPriceCheck.ReadOnly = true;
            this.buyTotalPriceCheck.Size = new System.Drawing.Size(121, 26);
            this.buyTotalPriceCheck.TabIndex = 10;
            this.buyTotalPriceCheck.Text = "0";
            this.buyTotalPriceCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // endBill
            // 
            this.endBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.endBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            this.endBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.endBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.endBill.Location = new System.Drawing.Point(86, 623);
            this.endBill.Name = "endBill";
            this.endBill.Size = new System.Drawing.Size(121, 52);
            this.endBill.TabIndex = 9;
            this.endBill.Text = "إنهاء الفاتورة";
            this.endBill.UseVisualStyleBackColor = false;
            this.endBill.Click += new System.EventHandler(this.endBill_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.groupBox2.Controls.Add(this.quantity);
            this.groupBox2.Controls.Add(this.detailsLamp);
            this.groupBox2.Controls.Add(this.sPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.unit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.itemBtn);
            this.groupBox2.Controls.Add(this.bPrice);
            this.groupBox2.Controls.Add(this.itemName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.itemQuantity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1204, 201);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "أصناف الفاتورة       ";
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.quantity.Location = new System.Drawing.Point(280, 46);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(124, 26);
            this.quantity.TabIndex = 7;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // detailsLamp
            // 
            this.detailsLamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsLamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.detailsLamp.Location = new System.Drawing.Point(1086, 0);
            this.detailsLamp.Name = "detailsLamp";
            this.detailsLamp.Size = new System.Drawing.Size(15, 15);
            this.detailsLamp.TabIndex = 14;
            // 
            // sPrice
            // 
            this.sPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sPrice.Location = new System.Drawing.Point(943, 135);
            this.sPrice.Name = "sPrice";
            this.sPrice.Size = new System.Drawing.Size(146, 26);
            this.sPrice.TabIndex = 6;
            this.sPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1095, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "سعر البيع :";
            // 
            // unit
            // 
            this.unit.FormattingEnabled = true;
            this.unit.Location = new System.Drawing.Point(280, 105);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(120, 27);
            this.unit.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "الوحدة :";
            // 
            // itemBtn
            // 
            this.itemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(95)))), ((int)(((byte)(181)))));
            this.itemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.itemBtn.Location = new System.Drawing.Point(514, 154);
            this.itemBtn.Name = "itemBtn";
            this.itemBtn.Size = new System.Drawing.Size(96, 35);
            this.itemBtn.TabIndex = 9;
            this.itemBtn.Text = "إضافة صنف";
            this.itemBtn.UseVisualStyleBackColor = false;
            this.itemBtn.Click += new System.EventHandler(this.itemBtn_Click);
            // 
            // bPrice
            // 
            this.bPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.bPrice.Location = new System.Drawing.Point(943, 93);
            this.bPrice.Name = "bPrice";
            this.bPrice.Size = new System.Drawing.Size(146, 26);
            this.bPrice.TabIndex = 5;
            this.bPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemName
            // 
            this.itemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.itemName.Location = new System.Drawing.Point(798, 44);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(291, 26);
            this.itemName.TabIndex = 4;
            this.itemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1095, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "أسم الصنف :";
            // 
            // itemQuantity
            // 
            this.itemQuantity.AutoSize = true;
            this.itemQuantity.Location = new System.Drawing.Point(406, 49);
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.Size = new System.Drawing.Size(51, 19);
            this.itemQuantity.TabIndex = 1;
            this.itemQuantity.Text = "الكمية :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1095, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "سعر الشراء :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.picture);
            this.groupBox1.Controls.Add(this.billImage);
            this.groupBox1.Controls.Add(this.billLamp);
            this.groupBox1.Controls.Add(this.addBill);
            this.groupBox1.Controls.Add(this.billDate);
            this.groupBox1.Controls.Add(this.billPrice);
            this.groupBox1.Controls.Add(this.incName);
            this.groupBox1.Controls.Add(this.billNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1206, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة      ";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(58, 41);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(135, 142);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 12;
            this.picture.TabStop = false;
            // 
            // billImage
            // 
            this.billImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(95)))), ((int)(((byte)(181)))));
            this.billImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.billImage.Location = new System.Drawing.Point(58, 189);
            this.billImage.Name = "billImage";
            this.billImage.Size = new System.Drawing.Size(135, 34);
            this.billImage.TabIndex = 10;
            this.billImage.Text = "صورة الفاتورة";
            this.billImage.UseVisualStyleBackColor = false;
            this.billImage.Click += new System.EventHandler(this.billImage_Click);
            // 
            // billLamp
            // 
            this.billLamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.billLamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            this.billLamp.Location = new System.Drawing.Point(1094, 2);
            this.billLamp.Name = "billLamp";
            this.billLamp.Size = new System.Drawing.Size(15, 15);
            this.billLamp.TabIndex = 9;
            // 
            // addBill
            // 
            this.addBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(95)))), ((int)(((byte)(181)))));
            this.addBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.addBill.Location = new System.Drawing.Point(514, 188);
            this.addBill.Name = "addBill";
            this.addBill.Size = new System.Drawing.Size(96, 34);
            this.addBill.TabIndex = 7;
            this.addBill.Text = "إضافة فاتورة";
            this.addBill.UseVisualStyleBackColor = false;
            this.addBill.Click += new System.EventHandler(this.addBill_Click);
            // 
            // billDate
            // 
            this.billDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.billDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.billDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.billDate.Location = new System.Drawing.Point(317, 50);
            this.billDate.Name = "billDate";
            this.billDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.billDate.Size = new System.Drawing.Size(125, 26);
            this.billDate.TabIndex = 7;
            // 
            // billPrice
            // 
            this.billPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.billPrice.Location = new System.Drawing.Point(729, 146);
            this.billPrice.Name = "billPrice";
            this.billPrice.Size = new System.Drawing.Size(360, 26);
            this.billPrice.TabIndex = 6;
            this.billPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // incName
            // 
            this.incName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.incName.Location = new System.Drawing.Point(729, 97);
            this.incName.Name = "incName";
            this.incName.Size = new System.Drawing.Size(360, 26);
            this.incName.TabIndex = 5;
            this.incName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // billNumber
            // 
            this.billNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.billNumber.Location = new System.Drawing.Point(729, 53);
            this.billNumber.Name = "billNumber";
            this.billNumber.Size = new System.Drawing.Size(360, 26);
            this.billNumber.TabIndex = 4;
            this.billNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1095, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "رقم الفاتورة :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "التاريخ :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1095, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "سعر الفاتورة :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1095, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "إسم الشركة :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1223, 1);
            this.label1.TabIndex = 0;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login.BackgroundImage")));
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.Controls.Add(this.tableLayoutPanel1);
            this.login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login.Location = new System.Drawing.Point(0, 34);
            this.login.Name = "login";
            this.login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login.Size = new System.Drawing.Size(1244, 715);
            this.login.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.18971F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.37621F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.38585F));
            this.tableLayoutPanel1.Controls.Add(this.password, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label33, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label32, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.userName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.132867F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.531468F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 715);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // password
            // 
            this.password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(390, 535);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(346, 29);
            this.password.TabIndex = 1;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(97)))), ((int)(((byte)(199)))));
            this.label33.Location = new System.Drawing.Point(742, 532);
            this.label33.Name = "label33";
            this.label33.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label33.Size = new System.Drawing.Size(120, 24);
            this.label33.TabIndex = 3;
            this.label33.Text = "كلمــــة الســـر :";
            this.label33.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(97)))), ((int)(((byte)(199)))));
            this.label32.Location = new System.Drawing.Point(742, 461);
            this.label32.Name = "label32";
            this.label32.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label32.Size = new System.Drawing.Size(119, 24);
            this.label32.TabIndex = 2;
            this.label32.Text = "أسم المستخدم :";
            this.label32.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // userName
            // 
            this.userName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(390, 464);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(346, 29);
            this.userName.TabIndex = 0;
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dbSource, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label34, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.editDB, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.97102F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.02898F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(381, 136);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dbSource
            // 
            this.dbSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbSource.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dbSource.Location = new System.Drawing.Point(61, 48);
            this.dbSource.Name = "dbSource";
            this.dbSource.Size = new System.Drawing.Size(205, 26);
            this.dbSource.TabIndex = 8;
            this.dbSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dbSource.Visible = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Arabic Transparent", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label34.Location = new System.Drawing.Point(272, 45);
            this.label34.Name = "label34";
            this.label34.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label34.Size = new System.Drawing.Size(106, 33);
            this.label34.TabIndex = 7;
            this.label34.Text = "قاعدة البيانات :";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label34.Visible = false;
            // 
            // editDB
            // 
            this.editDB.BackColor = System.Drawing.Color.Lime;
            this.editDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editDB.Font = new System.Drawing.Font("Arabic Transparent", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.editDB.Location = new System.Drawing.Point(3, 48);
            this.editDB.Name = "editDB";
            this.editDB.Size = new System.Drawing.Size(52, 27);
            this.editDB.TabIndex = 9;
            this.editDB.Text = "تعديل";
            this.editDB.UseVisualStyleBackColor = false;
            this.editDB.Visible = false;
            this.editDB.Click += new System.EventHandler(this.editDB_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.68208F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.31792F));
            this.tableLayoutPanel3.Controls.Add(this.loginBtn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(390, 606);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(346, 44);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(122, 3);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(221, 38);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "دخول";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // background
            // 
            this.background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background.BackgroundImage")));
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 34);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1244, 715);
            this.background.TabIndex = 16;
            // 
            // customersPayments
            // 
            this.customersPayments.Controls.Add(this.button6);
            this.customersPayments.Controls.Add(this.button5);
            this.customersPayments.Controls.Add(this.label68);
            this.customersPayments.Controls.Add(this.groupBox13);
            this.customersPayments.Controls.Add(this.label67);
            this.customersPayments.Controls.Add(this.textBox9);
            this.customersPayments.Controls.Add(this.groupBox12);
            this.customersPayments.Controls.Add(this.button3);
            this.customersPayments.Controls.Add(this.label65);
            this.customersPayments.Controls.Add(this.label66);
            this.customersPayments.Controls.Add(this.textBox8);
            this.customersPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersPayments.Location = new System.Drawing.Point(0, 34);
            this.customersPayments.Name = "customersPayments";
            this.customersPayments.Size = new System.Drawing.Size(1244, 715);
            this.customersPayments.TabIndex = 28;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Font = new System.Drawing.Font("Arabic Transparent", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button6.Location = new System.Drawing.Point(209, 534);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 40);
            this.button6.TabIndex = 13;
            this.button6.Text = "(PDF) فواتير العميل";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Arabic Transparent", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(239, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 30);
            this.button5.TabIndex = 12;
            this.button5.Text = "حذف";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label68
            // 
            this.label68.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label68.BackColor = System.Drawing.Color.Black;
            this.label68.Location = new System.Drawing.Point(11, 120);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(1223, 1);
            this.label68.TabIndex = 11;
            // 
            // groupBox13
            // 
            this.groupBox13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox13.Controls.Add(this.payMoney);
            this.groupBox13.Controls.Add(this.button4);
            this.groupBox13.Controls.Add(this.label69);
            this.groupBox13.Font = new System.Drawing.Font("Arabic Transparent", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox13.Location = new System.Drawing.Point(52, 230);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox13.Size = new System.Drawing.Size(507, 187);
            this.groupBox13.TabIndex = 10;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "دفع حساب";
            // 
            // payMoney
            // 
            this.payMoney.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.payMoney.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payMoney.Location = new System.Drawing.Point(219, 85);
            this.payMoney.Name = "payMoney";
            this.payMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.payMoney.Size = new System.Drawing.Size(134, 27);
            this.payMoney.TabIndex = 9;
            this.payMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Font = new System.Drawing.Font("Arabic Transparent", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.Location = new System.Drawing.Point(100, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "دفع";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label69
            // 
            this.label69.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(352, 88);
            this.label69.Name = "label69";
            this.label69.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label69.Size = new System.Drawing.Size(60, 19);
            this.label69.TabIndex = 3;
            this.label69.Text = "المبلغ :";
            // 
            // label67
            // 
            this.label67.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Arabic Transparent", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label67.Location = new System.Drawing.Point(228, 154);
            this.label67.Name = "label67";
            this.label67.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label67.Size = new System.Drawing.Size(154, 24);
            this.label67.TabIndex = 9;
            this.label67.Text = "إجمالى حساب العميل";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(205, 184);
            this.textBox9.Name = "textBox9";
            this.textBox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox9.Size = new System.Drawing.Size(200, 27);
            this.textBox9.TabIndex = 8;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox12.Controls.Add(this.dataGridView4);
            this.groupBox12.Font = new System.Drawing.Font("Arabic Transparent", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox12.Location = new System.Drawing.Point(675, 132);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox12.Size = new System.Drawing.Size(508, 568);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "العمليات السابقة";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arabic Transparent", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column19,
            this.Column17,
            this.Column18});
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 22);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView4.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridView4.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView4.Size = new System.Drawing.Size(502, 543);
            this.dataGridView4.TabIndex = 5;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "التاريخ";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "قيمة الفاورة";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "المدفوع";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "إجمالى الحساب";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Arabic Transparent", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Location = new System.Drawing.Point(357, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "بحث";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(1104, 218);
            this.label65.Name = "label65";
            this.label65.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label65.Size = new System.Drawing.Size(0, 19);
            this.label65.TabIndex = 4;
            // 
            // label66
            // 
            this.label66.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(857, 68);
            this.label66.Name = "label66";
            this.label66.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label66.Size = new System.Drawing.Size(101, 19);
            this.label66.TabIndex = 2;
            this.label66.Text = "أسم العميل :";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(502, 65);
            this.textBox8.Name = "textBox8";
            this.textBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox8.Size = new System.Drawing.Size(349, 27);
            this.textBox8.TabIndex = 0;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // payments
            // 
            this.payments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.payments.Controls.Add(this.textBox10);
            this.payments.Controls.Add(this.label70);
            this.payments.Controls.Add(this.printSaleBill);
            this.payments.Controls.Add(this.payingAmount);
            this.payments.Controls.Add(this.label58);
            this.payments.Controls.Add(this.currentBill);
            this.payments.Controls.Add(this.label60);
            this.payments.Controls.Add(this.checkBox1);
            this.payments.Controls.Add(this.previousAmount);
            this.payments.Controls.Add(this.label56);
            this.payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payments.Location = new System.Drawing.Point(0, 34);
            this.payments.Name = "payments";
            this.payments.Size = new System.Drawing.Size(1244, 715);
            this.payments.TabIndex = 26;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox10.Location = new System.Drawing.Point(456, 365);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(199, 29);
            this.textBox10.TabIndex = 15;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label70
            // 
            this.label70.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label70.Location = new System.Drawing.Point(661, 368);
            this.label70.Name = "label70";
            this.label70.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label70.Size = new System.Drawing.Size(39, 22);
            this.label70.TabIndex = 14;
            this.label70.Text = "بيد :";
            // 
            // printSaleBill
            // 
            this.printSaleBill.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.printSaleBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            this.printSaleBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printSaleBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.printSaleBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.printSaleBill.Location = new System.Drawing.Point(493, 476);
            this.printSaleBill.Name = "printSaleBill";
            this.printSaleBill.Size = new System.Drawing.Size(121, 52);
            this.printSaleBill.TabIndex = 13;
            this.printSaleBill.Text = "طباعة الفاتورة";
            this.printSaleBill.UseVisualStyleBackColor = false;
            this.printSaleBill.Click += new System.EventHandler(this.printSaleBill_Click_1);
            // 
            // payingAmount
            // 
            this.payingAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.payingAmount.DecimalPlaces = 1;
            this.payingAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.payingAmount.Location = new System.Drawing.Point(284, 267);
            this.payingAmount.Maximum = new decimal(new int[] {
            9000000,
            0,
            0,
            0});
            this.payingAmount.Name = "payingAmount";
            this.payingAmount.Size = new System.Drawing.Size(120, 29);
            this.payingAmount.TabIndex = 12;
            this.payingAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.payingAmount.ThousandsSeparator = true;
            // 
            // label58
            // 
            this.label58.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label58.Location = new System.Drawing.Point(410, 269);
            this.label58.Name = "label58";
            this.label58.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label58.Size = new System.Drawing.Size(79, 22);
            this.label58.TabIndex = 11;
            this.label58.Text = "دفع نقدي :";
            // 
            // currentBill
            // 
            this.currentBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentBill.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.currentBill.Location = new System.Drawing.Point(661, 267);
            this.currentBill.Name = "currentBill";
            this.currentBill.ReadOnly = true;
            this.currentBill.Size = new System.Drawing.Size(171, 29);
            this.currentBill.TabIndex = 10;
            this.currentBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label60
            // 
            this.label60.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label60.Location = new System.Drawing.Point(838, 270);
            this.label60.Name = "label60";
            this.label60.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label60.Size = new System.Drawing.Size(113, 22);
            this.label60.TabIndex = 9;
            this.label60.Text = "الفاتورة الحالية :";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkBox1.Location = new System.Drawing.Point(533, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 26);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "آجل";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // previousAmount
            // 
            this.previousAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.previousAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.previousAmount.Location = new System.Drawing.Point(456, 155);
            this.previousAmount.Name = "previousAmount";
            this.previousAmount.ReadOnly = true;
            this.previousAmount.Size = new System.Drawing.Size(199, 29);
            this.previousAmount.TabIndex = 3;
            this.previousAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label56.Location = new System.Drawing.Point(661, 158);
            this.label56.Name = "label56";
            this.label56.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label56.Size = new System.Drawing.Size(148, 22);
            this.label56.TabIndex = 2;
            this.label56.Text = "إجمالى حساب العميل :";
            // 
            // sale
            // 
            this.sale.BackColor = System.Drawing.Color.White;
            this.sale.Controls.Add(this.cancelSaleBill);
            this.sale.Controls.Add(this.continueSaleBill);
            this.sale.Controls.Add(this.groupBox3);
            this.sale.Controls.Add(this.groupBox4);
            this.sale.Controls.Add(this.label21);
            this.sale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sale.Location = new System.Drawing.Point(0, 34);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(1244, 715);
            this.sale.TabIndex = 10;
            // 
            // cancelSaleBill
            // 
            this.cancelSaleBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelSaleBill.BackColor = System.Drawing.Color.Red;
            this.cancelSaleBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelSaleBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cancelSaleBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cancelSaleBill.Location = new System.Drawing.Point(1107, 629);
            this.cancelSaleBill.Name = "cancelSaleBill";
            this.cancelSaleBill.Size = new System.Drawing.Size(121, 52);
            this.cancelSaleBill.TabIndex = 9;
            this.cancelSaleBill.Text = "إلغاء الفاتورة";
            this.cancelSaleBill.UseVisualStyleBackColor = false;
            this.cancelSaleBill.Click += new System.EventHandler(this.cancelSaleBill_Click);
            // 
            // continueSaleBill
            // 
            this.continueSaleBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.continueSaleBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            this.continueSaleBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueSaleBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.continueSaleBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.continueSaleBill.Location = new System.Drawing.Point(22, 629);
            this.continueSaleBill.Name = "continueSaleBill";
            this.continueSaleBill.Size = new System.Drawing.Size(121, 52);
            this.continueSaleBill.TabIndex = 8;
            this.continueSaleBill.Text = "إستكمال الفاتورة";
            this.continueSaleBill.UseVisualStyleBackColor = false;
            this.continueSaleBill.Click += new System.EventHandler(this.printSaleBill_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.groupBox3.Controls.Add(this.saleQuantity);
            this.groupBox3.Controls.Add(this.discount);
            this.groupBox3.Controls.Add(this.label64);
            this.groupBox3.Controls.Add(this.saleBillGrid);
            this.groupBox3.Controls.Add(this.saleAddItem);
            this.groupBox3.Controls.Add(this.saleItemName);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1204, 374);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "أصناف الفاتورة";
            // 
            // saleQuantity
            // 
            this.saleQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.saleQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.saleQuantity.Location = new System.Drawing.Point(503, 38);
            this.saleQuantity.Name = "saleQuantity";
            this.saleQuantity.Size = new System.Drawing.Size(107, 26);
            this.saleQuantity.TabIndex = 5;
            this.saleQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discount
            // 
            this.discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discount.Location = new System.Drawing.Point(277, 37);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(107, 26);
            this.discount.TabIndex = 6;
            this.discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(388, 40);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(53, 19);
            this.label64.TabIndex = 11;
            this.label64.Text = "الخصم :";
            // 
            // saleBillGrid
            // 
            this.saleBillGrid.AllowUserToAddRows = false;
            this.saleBillGrid.AllowUserToResizeColumns = false;
            this.saleBillGrid.AllowUserToResizeRows = false;
            this.saleBillGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saleBillGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.saleBillGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleBillGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.saleBillGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleBillGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleGridItemName,
            this.saleGridQuantity,
            this.Column5,
            this.saleGridUnitPrice,
            this.Column4,
            this.saleGridTotalQuantity});
            this.saleBillGrid.Location = new System.Drawing.Point(48, 82);
            this.saleBillGrid.MultiSelect = false;
            this.saleBillGrid.Name = "saleBillGrid";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleBillGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.saleBillGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.saleBillGrid.Size = new System.Drawing.Size(1107, 286);
            this.saleBillGrid.TabIndex = 10;
            this.saleBillGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleBillGrid_CellDoubleClick);
            this.saleBillGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.saleBillGrid_UserDeletingRow);
            // 
            // saleGridItemName
            // 
            this.saleGridItemName.HeaderText = "اسم الصنف";
            this.saleGridItemName.Name = "saleGridItemName";
            // 
            // saleGridQuantity
            // 
            this.saleGridQuantity.HeaderText = "الكمية";
            this.saleGridQuantity.Name = "saleGridQuantity";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "الوحدة";
            this.Column5.Name = "Column5";
            // 
            // saleGridUnitPrice
            // 
            this.saleGridUnitPrice.HeaderText = "سعر الصنف";
            this.saleGridUnitPrice.Name = "saleGridUnitPrice";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الخصم";
            this.Column4.Name = "Column4";
            // 
            // saleGridTotalQuantity
            // 
            this.saleGridTotalQuantity.HeaderText = "إجمالى السعر";
            this.saleGridTotalQuantity.Name = "saleGridTotalQuantity";
            // 
            // saleAddItem
            // 
            this.saleAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(95)))), ((int)(((byte)(181)))));
            this.saleAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saleAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.saleAddItem.Location = new System.Drawing.Point(91, 30);
            this.saleAddItem.Name = "saleAddItem";
            this.saleAddItem.Size = new System.Drawing.Size(108, 35);
            this.saleAddItem.TabIndex = 7;
            this.saleAddItem.Text = "إضافة صنف";
            this.saleAddItem.UseVisualStyleBackColor = false;
            this.saleAddItem.Click += new System.EventHandler(this.saleAddItem_Click);
            // 
            // saleItemName
            // 
            this.saleItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saleItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.saleItemName.Location = new System.Drawing.Point(720, 40);
            this.saleItemName.Name = "saleItemName";
            this.saleItemName.Size = new System.Drawing.Size(306, 26);
            this.saleItemName.TabIndex = 4;
            this.saleItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1032, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "أسم الصنف :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(616, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 19);
            this.label14.TabIndex = 1;
            this.label14.Text = "الكمية :";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.groupBox4.Controls.Add(this.saleBillDate);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.addSaleBill);
            this.groupBox4.Controls.Add(this.saleTotalPrice);
            this.groupBox4.Controls.Add(this.customerName);
            this.groupBox4.Controls.Add(this.saleBillNumber);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(22, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(1206, 185);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بيانات الفاتورة";
            // 
            // saleBillDate
            // 
            this.saleBillDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.saleBillDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.saleBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.saleBillDate.Location = new System.Drawing.Point(380, 112);
            this.saleBillDate.Name = "saleBillDate";
            this.saleBillDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.saleBillDate.Size = new System.Drawing.Size(125, 26);
            this.saleBillDate.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(511, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 19);
            this.label18.TabIndex = 2;
            this.label18.Text = "التاريخ :";
            // 
            // addSaleBill
            // 
            this.addSaleBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addSaleBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(95)))), ((int)(((byte)(181)))));
            this.addSaleBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSaleBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.addSaleBill.Location = new System.Drawing.Point(144, 107);
            this.addSaleBill.Name = "addSaleBill";
            this.addSaleBill.Size = new System.Drawing.Size(108, 35);
            this.addSaleBill.TabIndex = 8;
            this.addSaleBill.Text = "فتح فاتورة جديدة";
            this.addSaleBill.UseVisualStyleBackColor = false;
            this.addSaleBill.Click += new System.EventHandler(this.addSaleBill_Click);
            // 
            // saleTotalPrice
            // 
            this.saleTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.saleTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.saleTotalPrice.Enabled = false;
            this.saleTotalPrice.Location = new System.Drawing.Point(187, 40);
            this.saleTotalPrice.Name = "saleTotalPrice";
            this.saleTotalPrice.Size = new System.Drawing.Size(251, 26);
            this.saleTotalPrice.TabIndex = 6;
            this.saleTotalPrice.Text = "0";
            this.saleTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerName
            // 
            this.customerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.customerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.customerName.Location = new System.Drawing.Point(667, 116);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(436, 26);
            this.customerName.TabIndex = 3;
            this.customerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saleBillNumber
            // 
            this.saleBillNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.saleBillNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.saleBillNumber.Enabled = false;
            this.saleBillNumber.Location = new System.Drawing.Point(744, 45);
            this.saleBillNumber.Name = "saleBillNumber";
            this.saleBillNumber.Size = new System.Drawing.Size(251, 26);
            this.saleBillNumber.TabIndex = 4;
            this.saleBillNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1001, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 19);
            this.label17.TabIndex = 3;
            this.label17.Text = "رقم الفاتورة :";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(444, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 19);
            this.label19.TabIndex = 1;
            this.label19.Text = "إجمالى سعر الفاتورة : ";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1109, 119);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "أسم العميل :";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.BackColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(11, 206);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(1223, 1);
            this.label21.TabIndex = 0;
            // 
            // updatePrice
            // 
            this.updatePrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updatePrice.Controls.Add(this.label39);
            this.updatePrice.Controls.Add(this.itemFilter);
            this.updatePrice.Controls.Add(this.updatePriceDG);
            this.updatePrice.Controls.Add(this.groupBox9);
            this.updatePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatePrice.Location = new System.Drawing.Point(0, 34);
            this.updatePrice.Name = "updatePrice";
            this.updatePrice.Size = new System.Drawing.Size(1244, 715);
            this.updatePrice.TabIndex = 22;
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label39.Location = new System.Drawing.Point(689, 283);
            this.label39.Name = "label39";
            this.label39.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label39.Size = new System.Drawing.Size(92, 22);
            this.label39.TabIndex = 4;
            this.label39.Text = "أسم الصنف :";
            // 
            // itemFilter
            // 
            this.itemFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itemFilter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemFilter.Location = new System.Drawing.Point(370, 280);
            this.itemFilter.Name = "itemFilter";
            this.itemFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemFilter.Size = new System.Drawing.Size(309, 29);
            this.itemFilter.TabIndex = 3;
            this.itemFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemFilter.TextChanged += new System.EventHandler(this.itemFilter_TextChanged);
            // 
            // updatePriceDG
            // 
            this.updatePriceDG.AllowUserToAddRows = false;
            this.updatePriceDG.AllowUserToDeleteRows = false;
            this.updatePriceDG.AllowUserToOrderColumns = true;
            this.updatePriceDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatePriceDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.updatePriceDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.updatePriceDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updatePriceDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12});
            this.updatePriceDG.Location = new System.Drawing.Point(166, 348);
            this.updatePriceDG.MultiSelect = false;
            this.updatePriceDG.Name = "updatePriceDG";
            this.updatePriceDG.ReadOnly = true;
            this.updatePriceDG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.updatePriceDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.updatePriceDG.RowHeadersVisible = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.updatePriceDG.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.updatePriceDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.updatePriceDG.Size = new System.Drawing.Size(855, 364);
            this.updatePriceDG.TabIndex = 1;
            this.updatePriceDG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updatePriceDG_CellDoubleClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "الصنف";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "سعر البيع";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.currcentName);
            this.groupBox9.Controls.Add(this.label40);
            this.groupBox9.Controls.Add(this.updatePriceBtn);
            this.groupBox9.Controls.Add(this.newPrice);
            this.groupBox9.Controls.Add(this.curentPrice);
            this.groupBox9.Controls.Add(this.label41);
            this.groupBox9.Controls.Add(this.label42);
            this.groupBox9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox9.Location = new System.Drawing.Point(34, 38);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox9.Size = new System.Drawing.Size(1171, 211);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "تعديل سعر صنف";
            // 
            // currcentName
            // 
            this.currcentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currcentName.Enabled = false;
            this.currcentName.Location = new System.Drawing.Point(611, 43);
            this.currcentName.Name = "currcentName";
            this.currcentName.Size = new System.Drawing.Size(180, 29);
            this.currcentName.TabIndex = 6;
            this.currcentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label40.Location = new System.Drawing.Point(797, 44);
            this.label40.Name = "label40";
            this.label40.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label40.Size = new System.Drawing.Size(92, 22);
            this.label40.TabIndex = 5;
            this.label40.Text = "أسم الصنف :";
            // 
            // updatePriceBtn
            // 
            this.updatePriceBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updatePriceBtn.Location = new System.Drawing.Point(352, 128);
            this.updatePriceBtn.Name = "updatePriceBtn";
            this.updatePriceBtn.Size = new System.Drawing.Size(98, 38);
            this.updatePriceBtn.TabIndex = 4;
            this.updatePriceBtn.Text = "تعديل";
            this.updatePriceBtn.UseVisualStyleBackColor = true;
            this.updatePriceBtn.Click += new System.EventHandler(this.updatePriceBtn_Click);
            // 
            // newPrice
            // 
            this.newPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newPrice.Location = new System.Drawing.Point(519, 135);
            this.newPrice.Name = "newPrice";
            this.newPrice.Size = new System.Drawing.Size(198, 29);
            this.newPrice.TabIndex = 3;
            this.newPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // curentPrice
            // 
            this.curentPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.curentPrice.Enabled = false;
            this.curentPrice.Location = new System.Drawing.Point(309, 41);
            this.curentPrice.Name = "curentPrice";
            this.curentPrice.Size = new System.Drawing.Size(180, 29);
            this.curentPrice.TabIndex = 2;
            this.curentPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(726, 138);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(99, 22);
            this.label41.TabIndex = 1;
            this.label41.Text = "السعر الجديد :";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(495, 44);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(99, 22);
            this.label42.TabIndex = 0;
            this.label42.Text = "السعر الحالى :";
            // 
            // itemSearch
            // 
            this.itemSearch.Controls.Add(this.itemsSearchGrid);
            this.itemSearch.Controls.Add(this.label11);
            this.itemSearch.Controls.Add(this.label7);
            this.itemSearch.Controls.Add(this.textBox1);
            this.itemSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemSearch.Location = new System.Drawing.Point(0, 34);
            this.itemSearch.Name = "itemSearch";
            this.itemSearch.Size = new System.Drawing.Size(1244, 715);
            this.itemSearch.TabIndex = 13;
            // 
            // itemsSearchGrid
            // 
            this.itemsSearchGrid.AllowUserToAddRows = false;
            this.itemsSearchGrid.AllowUserToDeleteRows = false;
            this.itemsSearchGrid.AllowUserToOrderColumns = true;
            this.itemsSearchGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsSearchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsSearchGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.itemsSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6});
            this.itemsSearchGrid.Location = new System.Drawing.Point(0, 174);
            this.itemsSearchGrid.Name = "itemsSearchGrid";
            this.itemsSearchGrid.ReadOnly = true;
            this.itemsSearchGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemsSearchGrid.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.itemsSearchGrid.Size = new System.Drawing.Size(1244, 541);
            this.itemsSearchGrid.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "أسم الصنف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "الكمية";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الوحدة";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "سعر البيع";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1104, 218);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(0, 19);
            this.label11.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(757, 82);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "أسم الصنف :";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(402, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(349, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saleBillSearchDetails
            // 
            this.saleBillSearchDetails.Controls.Add(this.printAgain);
            this.saleBillSearchDetails.Controls.Add(this.button2);
            this.saleBillSearchDetails.Controls.Add(this.saleBillSearchDetailsGrid);
            this.saleBillSearchDetails.Controls.Add(this.label22);
            this.saleBillSearchDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleBillSearchDetails.Location = new System.Drawing.Point(0, 34);
            this.saleBillSearchDetails.Name = "saleBillSearchDetails";
            this.saleBillSearchDetails.Size = new System.Drawing.Size(1244, 715);
            this.saleBillSearchDetails.TabIndex = 18;
            // 
            // printAgain
            // 
            this.printAgain.BackColor = System.Drawing.Color.Lime;
            this.printAgain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.printAgain.Location = new System.Drawing.Point(12, 43);
            this.printAgain.Name = "printAgain";
            this.printAgain.Size = new System.Drawing.Size(113, 36);
            this.printAgain.TabIndex = 7;
            this.printAgain.Text = "طباعة الفاتورة";
            this.printAgain.UseVisualStyleBackColor = false;
            this.printAgain.Click += new System.EventHandler(this.printAgain_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(581, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "رجوع";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saleBillSearchDetailsGrid
            // 
            this.saleBillSearchDetailsGrid.AllowUserToAddRows = false;
            this.saleBillSearchDetailsGrid.AllowUserToDeleteRows = false;
            this.saleBillSearchDetailsGrid.AllowUserToOrderColumns = true;
            this.saleBillSearchDetailsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saleBillSearchDetailsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleBillSearchDetailsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.saleBillSearchDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleBillSearchDetailsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.saleBillSearchDetailsGrid.DefaultCellStyle = dataGridViewCellStyle15;
            this.saleBillSearchDetailsGrid.Location = new System.Drawing.Point(0, 88);
            this.saleBillSearchDetailsGrid.MultiSelect = false;
            this.saleBillSearchDetailsGrid.Name = "saleBillSearchDetailsGrid";
            this.saleBillSearchDetailsGrid.ReadOnly = true;
            this.saleBillSearchDetailsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.saleBillSearchDetailsGrid.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.saleBillSearchDetailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.saleBillSearchDetailsGrid.Size = new System.Drawing.Size(1244, 627);
            this.saleBillSearchDetailsGrid.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "أسم الصنف";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "الكمية";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "سعر الوحدة";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "الخصم";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "السعر الكلى";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1104, 218);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(0, 19);
            this.label22.TabIndex = 4;
            // 
            // saleBillSearch
            // 
            this.saleBillSearch.Controls.Add(this.saleBillSearchGrid);
            this.saleBillSearch.Controls.Add(this.label24);
            this.saleBillSearch.Controls.Add(this.label25);
            this.saleBillSearch.Controls.Add(this.textBox3);
            this.saleBillSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleBillSearch.Location = new System.Drawing.Point(0, 34);
            this.saleBillSearch.Name = "saleBillSearch";
            this.saleBillSearch.Size = new System.Drawing.Size(1244, 715);
            this.saleBillSearch.TabIndex = 17;
            // 
            // saleBillSearchGrid
            // 
            this.saleBillSearchGrid.AllowUserToAddRows = false;
            this.saleBillSearchGrid.AllowUserToDeleteRows = false;
            this.saleBillSearchGrid.AllowUserToOrderColumns = true;
            this.saleBillSearchGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saleBillSearchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleBillSearchGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.saleBillSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleBillSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.dataGridViewTextBoxColumn8,
            this.Column7,
            this.Column8,
            this.Column9});
            this.saleBillSearchGrid.Location = new System.Drawing.Point(0, 173);
            this.saleBillSearchGrid.MultiSelect = false;
            this.saleBillSearchGrid.Name = "saleBillSearchGrid";
            this.saleBillSearchGrid.ReadOnly = true;
            this.saleBillSearchGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.saleBillSearchGrid.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.saleBillSearchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.saleBillSearchGrid.Size = new System.Drawing.Size(1244, 542);
            this.saleBillSearchGrid.TabIndex = 5;
            this.saleBillSearchGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleBillSearchGrid_CellDoubleClick);
            // 
            // Column10
            // 
            this.Column10.HeaderText = "رقم الفاتورة";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "أسم العميل";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "سعر الفاتورة";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "تاريخ الفاتورة";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "البائع";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(1104, 218);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label24.Size = new System.Drawing.Size(0, 19);
            this.label24.TabIndex = 4;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(754, 79);
            this.label25.Name = "label25";
            this.label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label25.Size = new System.Drawing.Size(101, 19);
            this.label25.TabIndex = 2;
            this.label25.Text = "أسم العميل :";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(403, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(348, 27);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // itemsDetails
            // 
            this.itemsDetails.Controls.Add(this.dataGridView3);
            this.itemsDetails.Controls.Add(this.label62);
            this.itemsDetails.Controls.Add(this.label63);
            this.itemsDetails.Controls.Add(this.textBox6);
            this.itemsDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsDetails.Location = new System.Drawing.Point(0, 34);
            this.itemsDetails.Name = "itemsDetails";
            this.itemsDetails.Size = new System.Drawing.Size(1244, 715);
            this.itemsDetails.TabIndex = 27;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.Column15,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.dataGridView3.Location = new System.Drawing.Point(0, 174);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView3.Size = new System.Drawing.Size(1244, 541);
            this.dataGridView3.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "أسم الصنف";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "الكمية";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "الوحدة";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "سعر البيع";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "عدد المبيعات";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "ثمن المبيعات";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "الربح";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(1104, 218);
            this.label62.Name = "label62";
            this.label62.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label62.Size = new System.Drawing.Size(0, 19);
            this.label62.TabIndex = 4;
            // 
            // label63
            // 
            this.label63.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(757, 82);
            this.label63.Name = "label63";
            this.label63.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label63.Size = new System.Drawing.Size(98, 19);
            this.label63.TabIndex = 2;
            this.label63.Text = "أسم الصنف :";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(402, 79);
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox6.Size = new System.Drawing.Size(349, 27);
            this.textBox6.TabIndex = 0;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // updateNames
            // 
            this.updateNames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateNames.Controls.Add(this.groupBox7);
            this.updateNames.Controls.Add(this.groupBox6);
            this.updateNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateNames.Location = new System.Drawing.Point(0, 34);
            this.updateNames.Name = "updateNames";
            this.updateNames.Size = new System.Drawing.Size(1244, 715);
            this.updateNames.TabIndex = 21;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.updateCustomerName);
            this.groupBox7.Controls.Add(this.customerNewName);
            this.groupBox7.Controls.Add(this.customerOldName);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Enabled = false;
            this.groupBox7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox7.Location = new System.Drawing.Point(34, 348);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox7.Size = new System.Drawing.Size(1171, 211);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "تعديل أسم  ... :";
            // 
            // updateCustomerName
            // 
            this.updateCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateCustomerName.Location = new System.Drawing.Point(58, 94);
            this.updateCustomerName.Name = "updateCustomerName";
            this.updateCustomerName.Size = new System.Drawing.Size(98, 38);
            this.updateCustomerName.TabIndex = 4;
            this.updateCustomerName.Text = "تعديل";
            this.updateCustomerName.UseVisualStyleBackColor = true;
            // 
            // customerNewName
            // 
            this.customerNewName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerNewName.Location = new System.Drawing.Point(238, 97);
            this.customerNewName.Name = "customerNewName";
            this.customerNewName.Size = new System.Drawing.Size(309, 29);
            this.customerNewName.TabIndex = 3;
            // 
            // customerOldName
            // 
            this.customerOldName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerOldName.Location = new System.Drawing.Point(717, 97);
            this.customerOldName.Name = "customerOldName";
            this.customerOldName.Size = new System.Drawing.Size(309, 29);
            this.customerOldName.TabIndex = 2;
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(553, 100);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(96, 22);
            this.label37.TabIndex = 1;
            this.label37.Text = "الأسم الجديد :";
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(1032, 100);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(96, 22);
            this.label38.TabIndex = 0;
            this.label38.Text = "الأسم الحالى :";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.updateItemName);
            this.groupBox6.Controls.Add(this.itemNewName);
            this.groupBox6.Controls.Add(this.itemOldName);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox6.Location = new System.Drawing.Point(34, 38);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(1171, 211);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "تعديل أسم الصنف :";
            // 
            // updateItemName
            // 
            this.updateItemName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateItemName.Location = new System.Drawing.Point(58, 94);
            this.updateItemName.Name = "updateItemName";
            this.updateItemName.Size = new System.Drawing.Size(98, 38);
            this.updateItemName.TabIndex = 4;
            this.updateItemName.Text = "تعديل";
            this.updateItemName.UseVisualStyleBackColor = true;
            this.updateItemName.Click += new System.EventHandler(this.updateItemName_Click);
            // 
            // itemNewName
            // 
            this.itemNewName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itemNewName.Location = new System.Drawing.Point(238, 97);
            this.itemNewName.Name = "itemNewName";
            this.itemNewName.Size = new System.Drawing.Size(309, 29);
            this.itemNewName.TabIndex = 3;
            // 
            // itemOldName
            // 
            this.itemOldName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itemOldName.Location = new System.Drawing.Point(720, 97);
            this.itemOldName.Name = "itemOldName";
            this.itemOldName.Size = new System.Drawing.Size(309, 29);
            this.itemOldName.TabIndex = 2;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(553, 100);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(96, 22);
            this.label36.TabIndex = 1;
            this.label36.Text = "الأسم الجديد :";
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(1035, 100);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(96, 22);
            this.label35.TabIndex = 0;
            this.label35.Text = "الأسم الحالى :";
            // 
            // buyBillSearchDetails
            // 
            this.buyBillSearchDetails.AutoScroll = true;
            this.buyBillSearchDetails.Controls.Add(this.button1);
            this.buyBillSearchDetails.Controls.Add(this.buyBillImage);
            this.buyBillSearchDetails.Controls.Add(this.label23);
            this.buyBillSearchDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buyBillSearchDetails.Location = new System.Drawing.Point(0, 34);
            this.buyBillSearchDetails.Name = "buyBillSearchDetails";
            this.buyBillSearchDetails.Size = new System.Drawing.Size(1244, 715);
            this.buyBillSearchDetails.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(891, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "رجوع";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buyBillImage
            // 
            this.buyBillImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buyBillImage.Location = new System.Drawing.Point(345, 13);
            this.buyBillImage.Name = "buyBillImage";
            this.buyBillImage.Size = new System.Drawing.Size(506, 659);
            this.buyBillImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buyBillImage.TabIndex = 6;
            this.buyBillImage.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1104, 218);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label23.Size = new System.Drawing.Size(0, 19);
            this.label23.TabIndex = 4;
            // 
            // units
            // 
            this.units.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.units.Controls.Add(this.groupBox10);
            this.units.Controls.Add(this.groupBox11);
            this.units.Dock = System.Windows.Forms.DockStyle.Fill;
            this.units.Location = new System.Drawing.Point(0, 34);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(1244, 715);
            this.units.TabIndex = 25;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.updateUnitBtn);
            this.groupBox10.Controls.Add(this.UunitNewName);
            this.groupBox10.Controls.Add(this.UunitOldName);
            this.groupBox10.Controls.Add(this.label50);
            this.groupBox10.Controls.Add(this.label55);
            this.groupBox10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox10.Location = new System.Drawing.Point(34, 348);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox10.Size = new System.Drawing.Size(1171, 211);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "تعديل وحدة";
            // 
            // updateUnitBtn
            // 
            this.updateUnitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateUnitBtn.BackColor = System.Drawing.Color.Yellow;
            this.updateUnitBtn.ForeColor = System.Drawing.Color.White;
            this.updateUnitBtn.Location = new System.Drawing.Point(58, 94);
            this.updateUnitBtn.Name = "updateUnitBtn";
            this.updateUnitBtn.Size = new System.Drawing.Size(98, 38);
            this.updateUnitBtn.TabIndex = 4;
            this.updateUnitBtn.Text = "تعديل";
            this.updateUnitBtn.UseVisualStyleBackColor = false;
            this.updateUnitBtn.Click += new System.EventHandler(this.updateUnitBtn_Click);
            // 
            // UunitNewName
            // 
            this.UunitNewName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UunitNewName.Location = new System.Drawing.Point(238, 97);
            this.UunitNewName.Name = "UunitNewName";
            this.UunitNewName.Size = new System.Drawing.Size(309, 29);
            this.UunitNewName.TabIndex = 3;
            // 
            // UunitOldName
            // 
            this.UunitOldName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UunitOldName.Location = new System.Drawing.Point(717, 97);
            this.UunitOldName.Name = "UunitOldName";
            this.UunitOldName.Size = new System.Drawing.Size(309, 29);
            this.UunitOldName.TabIndex = 2;
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(553, 100);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(96, 22);
            this.label50.TabIndex = 1;
            this.label50.Text = "الأسم الجديد :";
            // 
            // label55
            // 
            this.label55.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(1032, 100);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(96, 22);
            this.label55.TabIndex = 0;
            this.label55.Text = "الأسم الحالى :";
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.addUnitBtn);
            this.groupBox11.Controls.Add(this.AunitName);
            this.groupBox11.Controls.Add(this.label57);
            this.groupBox11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox11.Location = new System.Drawing.Point(34, 38);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox11.Size = new System.Drawing.Size(1171, 211);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "إضافة وحدة";
            // 
            // addUnitBtn
            // 
            this.addUnitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addUnitBtn.BackColor = System.Drawing.Color.Lime;
            this.addUnitBtn.ForeColor = System.Drawing.Color.White;
            this.addUnitBtn.Location = new System.Drawing.Point(290, 92);
            this.addUnitBtn.Name = "addUnitBtn";
            this.addUnitBtn.Size = new System.Drawing.Size(98, 38);
            this.addUnitBtn.TabIndex = 4;
            this.addUnitBtn.Text = "إضافة";
            this.addUnitBtn.UseVisualStyleBackColor = false;
            this.addUnitBtn.Click += new System.EventHandler(this.addUnitBtn_Click);
            // 
            // AunitName
            // 
            this.AunitName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AunitName.Location = new System.Drawing.Point(508, 101);
            this.AunitName.Name = "AunitName";
            this.AunitName.Size = new System.Drawing.Size(309, 29);
            this.AunitName.TabIndex = 2;
            // 
            // label57
            // 
            this.label57.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(823, 104);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(91, 22);
            this.label57.TabIndex = 0;
            this.label57.Text = "أسم الوحدة :";
            // 
            // users
            // 
            this.users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.users.Controls.Add(this.deleteUserBtn);
            this.users.Controls.Add(this.passwordBX);
            this.users.Controls.Add(this.label53);
            this.users.Controls.Add(this.userRoleX);
            this.users.Controls.Add(this.textBox4);
            this.users.Controls.Add(this.label52);
            this.users.Controls.Add(this.label51);
            this.users.Controls.Add(this.updateUser);
            this.users.Controls.Add(this.userRealNameX);
            this.users.Controls.Add(this.label49);
            this.users.Controls.Add(this.textBox7);
            this.users.Controls.Add(this.textBox2);
            this.users.Controls.Add(this.label43);
            this.users.Controls.Add(this.textBox5);
            this.users.Controls.Add(this.label47);
            this.users.Controls.Add(this.label48);
            this.users.Controls.Add(this.usersDG);
            this.users.Controls.Add(this.groupBox8);
            this.users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.users.Location = new System.Drawing.Point(0, 34);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(1244, 715);
            this.users.TabIndex = 23;
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteUserBtn.BackColor = System.Drawing.Color.Red;
            this.deleteUserBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deleteUserBtn.ForeColor = System.Drawing.Color.White;
            this.deleteUserBtn.Location = new System.Drawing.Point(571, 403);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(98, 38);
            this.deleteUserBtn.TabIndex = 26;
            this.deleteUserBtn.Text = "حذف";
            this.deleteUserBtn.UseVisualStyleBackColor = false;
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // passwordBX
            // 
            this.passwordBX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordBX.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passwordBX.Location = new System.Drawing.Point(604, 341);
            this.passwordBX.Name = "passwordBX";
            this.passwordBX.Size = new System.Drawing.Size(180, 29);
            this.passwordBX.TabIndex = 25;
            this.passwordBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label53
            // 
            this.label53.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(484, 340);
            this.label53.Name = "label53";
            this.label53.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label53.Size = new System.Drawing.Size(63, 22);
            this.label53.TabIndex = 24;
            this.label53.Text = "الدرجة :";
            // 
            // userRoleX
            // 
            this.userRoleX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userRoleX.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.userRoleX.FormattingEnabled = true;
            this.userRoleX.Items.AddRange(new object[] {
            "Admin",
            "Worker"});
            this.userRoleX.Location = new System.Drawing.Point(340, 335);
            this.userRoleX.Name = "userRoleX";
            this.userRoleX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userRoleX.Size = new System.Drawing.Size(135, 30);
            this.userRoleX.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox4.Location = new System.Drawing.Point(64, 278);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 29);
            this.textBox4.TabIndex = 22;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(209, 283);
            this.label52.Name = "label52";
            this.label52.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label52.Size = new System.Drawing.Size(63, 22);
            this.label52.TabIndex = 21;
            this.label52.Text = "الدرجة :";
            // 
            // label51
            // 
            this.label51.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(792, 340);
            this.label51.Name = "label51";
            this.label51.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label51.Size = new System.Drawing.Size(82, 22);
            this.label51.TabIndex = 20;
            this.label51.Text = "كلمة السر :";
            // 
            // updateUser
            // 
            this.updateUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateUser.BackColor = System.Drawing.Color.Lime;
            this.updateUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.updateUser.ForeColor = System.Drawing.Color.White;
            this.updateUser.Location = new System.Drawing.Point(123, 327);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(98, 38);
            this.updateUser.TabIndex = 19;
            this.updateUser.Text = "تعديل";
            this.updateUser.UseVisualStyleBackColor = false;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // userRealNameX
            // 
            this.userRealNameX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userRealNameX.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.userRealNameX.Location = new System.Drawing.Point(931, 342);
            this.userRealNameX.Name = "userRealNameX";
            this.userRealNameX.Size = new System.Drawing.Size(180, 29);
            this.userRealNameX.TabIndex = 18;
            this.userRealNameX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label49.Location = new System.Drawing.Point(1117, 343);
            this.label49.Name = "label49";
            this.label49.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label49.Size = new System.Drawing.Size(89, 22);
            this.label49.TabIndex = 17;
            this.label49.Text = "أسم العضو :";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox7.Location = new System.Drawing.Point(297, 282);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(180, 29);
            this.textBox7.TabIndex = 14;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.Location = new System.Drawing.Point(931, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 29);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label43.Location = new System.Drawing.Point(1117, 283);
            this.label43.Name = "label43";
            this.label43.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label43.Size = new System.Drawing.Size(89, 22);
            this.label43.TabIndex = 11;
            this.label43.Text = "أسم العضو :";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox5.Location = new System.Drawing.Point(604, 282);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 29);
            this.textBox5.TabIndex = 10;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(481, 286);
            this.label47.Name = "label47";
            this.label47.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label47.Size = new System.Drawing.Size(82, 22);
            this.label47.TabIndex = 9;
            this.label47.Text = "كلمة السر :";
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(790, 285);
            this.label48.Name = "label48";
            this.label48.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label48.Size = new System.Drawing.Size(107, 22);
            this.label48.TabIndex = 8;
            this.label48.Text = "أسم المستخدم :";
            // 
            // usersDG
            // 
            this.usersDG.AllowUserToAddRows = false;
            this.usersDG.AllowUserToDeleteRows = false;
            this.usersDG.AllowUserToOrderColumns = true;
            this.usersDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.usersDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.Column13,
            this.Column14});
            this.usersDG.Location = new System.Drawing.Point(34, 486);
            this.usersDG.MultiSelect = false;
            this.usersDG.Name = "usersDG";
            this.usersDG.ReadOnly = true;
            this.usersDG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.usersDG.RowHeadersVisible = false;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usersDG.RowsDefaultCellStyle = dataGridViewCellStyle23;
            this.usersDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDG.Size = new System.Drawing.Size(1171, 217);
            this.usersDG.TabIndex = 1;
            this.usersDG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDG_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "الأسم";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "أسم المستخدم";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "كلمة السر";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "الدرجة";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.label54);
            this.groupBox8.Controls.Add(this.passwordB);
            this.groupBox8.Controls.Add(this.userRole);
            this.groupBox8.Controls.Add(this.userRealName);
            this.groupBox8.Controls.Add(this.label44);
            this.groupBox8.Controls.Add(this.addUser);
            this.groupBox8.Controls.Add(this.userNameB);
            this.groupBox8.Controls.Add(this.label45);
            this.groupBox8.Controls.Add(this.label46);
            this.groupBox8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox8.Location = new System.Drawing.Point(34, 38);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox8.Size = new System.Drawing.Size(1171, 186);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "إضافة عضو جديد";
            // 
            // label54
            // 
            this.label54.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(447, 60);
            this.label54.Name = "label54";
            this.label54.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label54.Size = new System.Drawing.Size(82, 22);
            this.label54.TabIndex = 10;
            this.label54.Text = "كلمة السر :";
            // 
            // passwordB
            // 
            this.passwordB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordB.Location = new System.Drawing.Point(261, 56);
            this.passwordB.Name = "passwordB";
            this.passwordB.Size = new System.Drawing.Size(180, 29);
            this.passwordB.TabIndex = 8;
            this.passwordB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userRole
            // 
            this.userRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userRole.FormattingEnabled = true;
            this.userRole.Items.AddRange(new object[] {
            "Admin",
            "Worker"});
            this.userRole.Location = new System.Drawing.Point(30, 55);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(135, 30);
            this.userRole.TabIndex = 7;
            // 
            // userRealName
            // 
            this.userRealName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userRealName.Location = new System.Drawing.Point(872, 57);
            this.userRealName.Name = "userRealName";
            this.userRealName.Size = new System.Drawing.Size(180, 29);
            this.userRealName.TabIndex = 6;
            this.userRealName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label44.Location = new System.Drawing.Point(1058, 58);
            this.label44.Name = "label44";
            this.label44.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label44.Size = new System.Drawing.Size(89, 22);
            this.label44.TabIndex = 5;
            this.label44.Text = "أسم العضو :";
            // 
            // addUser
            // 
            this.addUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addUser.BackColor = System.Drawing.Color.Lime;
            this.addUser.ForeColor = System.Drawing.Color.White;
            this.addUser.Location = new System.Drawing.Point(547, 123);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(98, 38);
            this.addUser.TabIndex = 4;
            this.addUser.Text = "إضافة";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // userNameB
            // 
            this.userNameB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userNameB.Location = new System.Drawing.Point(558, 56);
            this.userNameB.Name = "userNameB";
            this.userNameB.Size = new System.Drawing.Size(180, 29);
            this.userNameB.TabIndex = 2;
            this.userNameB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label45
            // 
            this.label45.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(172, 59);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(63, 22);
            this.label45.TabIndex = 1;
            this.label45.Text = "الدرجة :";
            // 
            // label46
            // 
            this.label46.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(744, 59);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(107, 22);
            this.label46.TabIndex = 0;
            this.label46.Text = "أسم المستخدم :";
            // 
            // buyBillSearch
            // 
            this.buyBillSearch.Controls.Add(this.label16);
            this.buyBillSearch.Controls.Add(this.buyBillincNameSearch);
            this.buyBillSearch.Controls.Add(this.buyBillSearchGrid);
            this.buyBillSearch.Controls.Add(this.label12);
            this.buyBillSearch.Controls.Add(this.label15);
            this.buyBillSearch.Controls.Add(this.buyBillNumberSearch);
            this.buyBillSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buyBillSearch.Location = new System.Drawing.Point(0, 34);
            this.buyBillSearch.Name = "buyBillSearch";
            this.buyBillSearch.Size = new System.Drawing.Size(1244, 715);
            this.buyBillSearch.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(506, 83);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(106, 19);
            this.label16.TabIndex = 7;
            this.label16.Text = "أسم الشركة :";
            // 
            // buyBillincNameSearch
            // 
            this.buyBillincNameSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buyBillincNameSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBillincNameSearch.Location = new System.Drawing.Point(277, 80);
            this.buyBillincNameSearch.Name = "buyBillincNameSearch";
            this.buyBillincNameSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buyBillincNameSearch.Size = new System.Drawing.Size(223, 27);
            this.buyBillincNameSearch.TabIndex = 6;
            this.buyBillincNameSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buyBillincNameSearch.TextChanged += new System.EventHandler(this.buyBillincNameSearch_TextChanged);
            // 
            // buyBillSearchGrid
            // 
            this.buyBillSearchGrid.AllowUserToAddRows = false;
            this.buyBillSearchGrid.AllowUserToDeleteRows = false;
            this.buyBillSearchGrid.AllowUserToOrderColumns = true;
            this.buyBillSearchGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buyBillSearchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buyBillSearchGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.buyBillSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyBillSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.buyBillSearchGrid.Location = new System.Drawing.Point(0, 170);
            this.buyBillSearchGrid.MultiSelect = false;
            this.buyBillSearchGrid.Name = "buyBillSearchGrid";
            this.buyBillSearchGrid.ReadOnly = true;
            this.buyBillSearchGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buyBillSearchGrid.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.buyBillSearchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buyBillSearchGrid.Size = new System.Drawing.Size(1244, 545);
            this.buyBillSearchGrid.TabIndex = 5;
            this.buyBillSearchGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buySaleSearchGrid_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "رقم الفاتورة";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "أسم الشركة";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "سعر الفاتورة";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "تاريخ الفاتورة";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1104, 218);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(0, 19);
            this.label12.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(948, 85);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(96, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "رقم الفاتورة :";
            // 
            // buyBillNumberSearch
            // 
            this.buyBillNumberSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buyBillNumberSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBillNumberSearch.Location = new System.Drawing.Point(719, 82);
            this.buyBillNumberSearch.Name = "buyBillNumberSearch";
            this.buyBillNumberSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buyBillNumberSearch.Size = new System.Drawing.Size(223, 27);
            this.buyBillNumberSearch.TabIndex = 0;
            this.buyBillNumberSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buyBillNumberSearch.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // itemWithoutBill
            // 
            this.itemWithoutBill.BackColor = System.Drawing.Color.White;
            this.itemWithoutBill.Controls.Add(this.itemDateX);
            this.itemWithoutBill.Controls.Add(this.label26);
            this.itemWithoutBill.Controls.Add(this.groupBox5);
            this.itemWithoutBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemWithoutBill.Location = new System.Drawing.Point(0, 34);
            this.itemWithoutBill.Name = "itemWithoutBill";
            this.itemWithoutBill.Size = new System.Drawing.Size(1244, 715);
            this.itemWithoutBill.TabIndex = 19;
            // 
            // itemDateX
            // 
            this.itemDateX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemDateX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemDateX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.itemDateX.Location = new System.Drawing.Point(24, 158);
            this.itemDateX.Name = "itemDateX";
            this.itemDateX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemDateX.Size = new System.Drawing.Size(125, 26);
            this.itemDateX.TabIndex = 13;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label26.Location = new System.Drawing.Point(481, 82);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(308, 40);
            this.label26.TabIndex = 3;
            this.label26.Text = "أصناف بدون فاتورة شراء";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.groupBox5.Controls.Add(this.itemSalePriceX);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.itemUnitX);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.itemQuantityX);
            this.groupBox5.Controls.Add(this.addItemBtnX);
            this.groupBox5.Controls.Add(this.itemBuyPriceX);
            this.groupBox5.Controls.Add(this.itemNameX);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(22, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(1204, 244);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "أصناف الفاتورة";
            // 
            // itemSalePriceX
            // 
            this.itemSalePriceX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemSalePriceX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.itemSalePriceX.Location = new System.Drawing.Point(943, 135);
            this.itemSalePriceX.Name = "itemSalePriceX";
            this.itemSalePriceX.Size = new System.Drawing.Size(146, 26);
            this.itemSalePriceX.TabIndex = 6;
            this.itemSalePriceX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(1095, 138);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(70, 19);
            this.label27.TabIndex = 12;
            this.label27.Text = "سعر البيع :";
            // 
            // itemUnitX
            // 
            this.itemUnitX.FormattingEnabled = true;
            this.itemUnitX.Location = new System.Drawing.Point(280, 105);
            this.itemUnitX.Name = "itemUnitX";
            this.itemUnitX.Size = new System.Drawing.Size(120, 27);
            this.itemUnitX.TabIndex = 8;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(406, 107);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 19);
            this.label28.TabIndex = 10;
            this.label28.Text = "الوحدة :";
            // 
            // itemQuantityX
            // 
            this.itemQuantityX.DecimalPlaces = 1;
            this.itemQuantityX.Location = new System.Drawing.Point(280, 46);
            this.itemQuantityX.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.itemQuantityX.Name = "itemQuantityX";
            this.itemQuantityX.Size = new System.Drawing.Size(120, 26);
            this.itemQuantityX.TabIndex = 7;
            this.itemQuantityX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemQuantityX.ThousandsSeparator = true;
            // 
            // addItemBtnX
            // 
            this.addItemBtnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(95)))), ((int)(((byte)(181)))));
            this.addItemBtnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtnX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.addItemBtnX.Location = new System.Drawing.Point(582, 187);
            this.addItemBtnX.Name = "addItemBtnX";
            this.addItemBtnX.Size = new System.Drawing.Size(96, 35);
            this.addItemBtnX.TabIndex = 9;
            this.addItemBtnX.Text = "إضافة صنف";
            this.addItemBtnX.UseVisualStyleBackColor = false;
            this.addItemBtnX.Click += new System.EventHandler(this.addItemBtnX_Click);
            // 
            // itemBuyPriceX
            // 
            this.itemBuyPriceX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemBuyPriceX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.itemBuyPriceX.Location = new System.Drawing.Point(943, 93);
            this.itemBuyPriceX.Name = "itemBuyPriceX";
            this.itemBuyPriceX.Size = new System.Drawing.Size(146, 26);
            this.itemBuyPriceX.TabIndex = 5;
            this.itemBuyPriceX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemNameX
            // 
            this.itemNameX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.itemNameX.Location = new System.Drawing.Point(798, 44);
            this.itemNameX.Name = "itemNameX";
            this.itemNameX.Size = new System.Drawing.Size(291, 26);
            this.itemNameX.TabIndex = 4;
            this.itemNameX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(1095, 46);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(79, 19);
            this.label29.TabIndex = 3;
            this.label29.Text = "أسم الصنف :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(406, 49);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 19);
            this.label30.TabIndex = 1;
            this.label30.Text = "الكمية :";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(1095, 96);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(83, 19);
            this.label31.TabIndex = 0;
            this.label31.Text = "سعر الشراء :";
            // 
            // settings
            // 
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings.Controls.Add(this.label61);
            this.settings.Controls.Add(this.label59);
            this.settings.Controls.Add(this.dataGridView2);
            this.settings.Controls.Add(this.dataGridView1);
            this.settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings.Location = new System.Drawing.Point(0, 34);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(1244, 715);
            this.settings.TabIndex = 24;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label61.Location = new System.Drawing.Point(201, 166);
            this.label61.Name = "label61";
            this.label61.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label61.Size = new System.Drawing.Size(88, 22);
            this.label61.TabIndex = 18;
            this.label61.Text = "عمليات الدفع";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label59.Location = new System.Drawing.Point(918, 167);
            this.label59.Name = "label59";
            this.label59.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label59.Size = new System.Drawing.Size(103, 22);
            this.label59.TabIndex = 17;
            this.label59.Text = "الفواتير السابقة";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(32, 197);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(455, 352);
            this.dataGridView2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(706, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 349);
            this.dataGridView1.TabIndex = 15;
            // 
            // reports
            // 
            this.reports.BackColor = System.Drawing.Color.White;
            this.reports.Controls.Add(this.CRViewer);
            this.reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reports.Location = new System.Drawing.Point(0, 34);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(1244, 715);
            this.reports.TabIndex = 10;
            // 
            // CRViewer
            // 
            this.CRViewer.ActiveViewIndex = -1;
            this.CRViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRViewer.Location = new System.Drawing.Point(0, 37);
            this.CRViewer.Name = "CRViewer";
            this.CRViewer.Size = new System.Drawing.Size(1244, 675);
            this.CRViewer.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1244, 749);
            this.Controls.Add(this.mainPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أولاد شرف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.addItem.ResumeLayout(false);
            this.addItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyItemsDG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.login.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.customersPayments.ResumeLayout(false);
            this.customersPayments.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.payments.ResumeLayout(false);
            this.payments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payingAmount)).EndInit();
            this.sale.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBillGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.updatePrice.ResumeLayout(false);
            this.updatePrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatePriceDG)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.itemSearch.ResumeLayout(false);
            this.itemSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSearchGrid)).EndInit();
            this.saleBillSearchDetails.ResumeLayout(false);
            this.saleBillSearchDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBillSearchDetailsGrid)).EndInit();
            this.saleBillSearch.ResumeLayout(false);
            this.saleBillSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBillSearchGrid)).EndInit();
            this.itemsDetails.ResumeLayout(false);
            this.itemsDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.updateNames.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.buyBillSearchDetails.ResumeLayout(false);
            this.buyBillSearchDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyBillImage)).EndInit();
            this.units.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.users.ResumeLayout(false);
            this.users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDG)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.buyBillSearch.ResumeLayout(false);
            this.buyBillSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyBillSearchGrid)).EndInit();
            this.itemWithoutBill.ResumeLayout(false);
            this.itemWithoutBill.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantityX)).EndInit();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.reports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem صنفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشترياتToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem itemsReport;
        private System.Windows.Forms.Panel reports;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewer;
        private System.Windows.Forms.ToolStripMenuItem برقمالفاتورةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بالصنفToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton6;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        private System.Windows.Forms.Panel sale;
        private System.Windows.Forms.Button continueSaleBill;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker saleBillDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button saleAddItem;
        public System.Windows.Forms.TextBox saleItemName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox saleTotalPrice;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox saleBillNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView saleBillGrid;
        private System.Windows.Forms.Button addSaleBill;
        private System.Windows.Forms.Button cancelSaleBill;
        private System.Windows.Forms.Panel itemSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView itemsSearchGrid;
        private System.Windows.Forms.ToolStripMenuItem فاتورةبيعToolStripMenuItem;
        private System.Windows.Forms.Panel buyBillSearch;
        private System.Windows.Forms.DataGridView buyBillSearchGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox buyBillincNameSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox buyBillNumberSearch;
        private System.Windows.Forms.Panel buyBillSearchDetails;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox buyBillImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Panel saleBillSearch;
        private System.Windows.Forms.DataGridView saleBillSearchGrid;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel saleBillSearchDetails;
        private System.Windows.Forms.DataGridView saleBillSearchDetailsGrid;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem أسمصنفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المستخدمونToolStripMenuItem;
        private System.Windows.Forms.Panel addItem;
        private System.Windows.Forms.Button endBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label detailsLamp;
        private System.Windows.Forms.TextBox sPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox unit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button itemBtn;
        private System.Windows.Forms.TextBox bPrice;
        public System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label itemQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button billImage;
        private System.Windows.Forms.Label billLamp;
        private System.Windows.Forms.Button addBill;
        private System.Windows.Forms.DateTimePicker billDate;
        private System.Windows.Forms.TextBox billPrice;
        private System.Windows.Forms.TextBox incName;
        private System.Windows.Forms.TextBox billNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel itemWithoutBill;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox itemSalePriceX;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox itemUnitX;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown itemQuantityX;
        private System.Windows.Forms.Button addItemBtnX;
        private System.Windows.Forms.TextBox itemBuyPriceX;
        public System.Windows.Forms.TextBox itemNameX;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker itemDateX;
        private System.Windows.Forms.ToolStripMenuItem سعرصنفToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox dbSource;
        private System.Windows.Forms.Button editDB;
        private System.Windows.Forms.Panel login;
        private System.Windows.Forms.ToolStripDropDownButton toolStripStatusLabel1;
        private System.Windows.Forms.Panel updateNames;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button updateItemName;
        private System.Windows.Forms.TextBox itemNewName;
        private System.Windows.Forms.TextBox itemOldName;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button updateCustomerName;
        private System.Windows.Forms.TextBox customerNewName;
        private System.Windows.Forms.TextBox customerOldName;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button printAgain;
        private System.Windows.Forms.Panel updatePrice;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button updatePriceBtn;
        private System.Windows.Forms.TextBox newPrice;
        private System.Windows.Forms.TextBox curentPrice;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox itemFilter;
        private System.Windows.Forms.DataGridView updatePriceDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.TextBox currcentName;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Panel users;
        private System.Windows.Forms.DataGridView usersDG;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox userRealName;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.TextBox userNameB;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox userRole;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.TextBox userRealNameX;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox passwordBX;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.ComboBox userRoleX;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox passwordB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Button deleteUserBtn;
        private System.Windows.Forms.Panel settings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton7;
        private System.Windows.Forms.ToolStripMenuItem الوحدةToolStripMenuItem;
        private System.Windows.Forms.Panel units;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button updateUnitBtn;
        private System.Windows.Forms.TextBox UunitNewName;
        private System.Windows.Forms.TextBox UunitOldName;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button addUnitBtn;
        private System.Windows.Forms.TextBox AunitName;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Panel payments;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox previousAmount;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox currentBill;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown payingAmount;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Button printSaleBill;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel itemsDetails;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleGridItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleGridQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleGridUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleGridTotalQuantity;
        private System.Windows.Forms.TextBox saleQuantity;
        private System.Windows.Forms.Panel customersPayments;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.TextBox payMoney;
        private Button button5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private TextBox textBox10;
        private Label label70;
        private Label label71;
        private TextBox buyTotalPriceCheck;
        private DataGridView buyItemsDG;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column21;
        private DataGridViewTextBoxColumn Column22;
        private DataGridViewTextBoxColumn Column23;
        private DataGridViewTextBoxColumn Column24;
        private TextBox quantity;
        private ToolStripMenuItem مصاريفToolStripMenuItem;
        private ToolStripMenuItem ربحعنفترةToolStripMenuItem;
        private Button button6;
        private Button cancelBuyBill;
    }
}

