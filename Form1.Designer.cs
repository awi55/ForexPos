using System;
using System.Windows.Forms;

namespace myPos
{
    partial class Form1
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

        private void ShowMessage(object sender, System.EventArgs e)
        {
            MessageBox.Show("Button Click");
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.FlatFeeConverted = new System.Windows.Forms.Label();
            this.FlatFee = new System.Windows.Forms.Label();
            this.FlatFeeTextBox = new System.Windows.Forms.TextBox();
            this.FlatFeeLabel = new System.Windows.Forms.Label();
            this.BuyTitle = new System.Windows.Forms.Label();
            this.BuyingPrintButton = new System.Windows.Forms.Button();
            this.BuyingGo = new System.Windows.Forms.Button();
            this.CommissionValue = new System.Windows.Forms.Label();
            this.Commission = new System.Windows.Forms.Label();
            this.Converted = new System.Windows.Forms.Label();
            this.ConvertLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBox10 = new System.Windows.Forms.TextBox();
            this.TextBox9 = new System.Windows.Forms.TextBox();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.FlatFeeSellingTextBox = new System.Windows.Forms.TextBox();
            this.FlatLabel = new System.Windows.Forms.Label();
            this.FlatFeeSellingConv = new System.Windows.Forms.Label();
            this.FlatFeeSell = new System.Windows.Forms.Label();
            this.SellingPrintButton = new System.Windows.Forms.Button();
            this.SellTitle = new System.Windows.Forms.Label();
            this.SellingGo = new System.Windows.Forms.Button();
            this.SellCommValue = new System.Windows.Forms.Label();
            this.SellConverted = new System.Windows.Forms.Label();
            this.SellComm = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.conForex = new System.Windows.Forms.Label();
            this.MenuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TextBox16 = new System.Windows.Forms.TextBox();
            this.TextBox17 = new System.Windows.Forms.TextBox();
            this.TextBox18 = new System.Windows.Forms.TextBox();
            this.TextBox19 = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CompanyTextBox = new System.Windows.Forms.TextBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ACNTextBox = new System.Windows.Forms.TextBox();
            this.ACNLabel = new System.Windows.Forms.Label();
            this.StoreAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.StoreAddressLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uploadButton = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TransactionPwdTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTransLabel = new System.Windows.Forms.Label();
            this.ClearTransactionsButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableDataGrid1 = new System.Windows.Forms.DataGridView();
            this.TextBox11 = new System.Windows.Forms.TextBox();
            this.TextBox12 = new System.Windows.Forms.TextBox();
            this.TextBox13 = new System.Windows.Forms.TextBox();
            this.TextBox14 = new System.Windows.Forms.TextBox();
            this.TextBox15 = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Controls.Add(this.tabPage4);
            this.TabControl1.Location = new System.Drawing.Point(0, 2);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(704, 361);
            this.TabControl1.TabIndex = 11;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.DarkGreen;
            this.TabPage1.Controls.Add(this.FlatFeeConverted);
            this.TabPage1.Controls.Add(this.FlatFee);
            this.TabPage1.Controls.Add(this.FlatFeeTextBox);
            this.TabPage1.Controls.Add(this.FlatFeeLabel);
            this.TabPage1.Controls.Add(this.BuyTitle);
            this.TabPage1.Controls.Add(this.BuyingPrintButton);
            this.TabPage1.Controls.Add(this.BuyingGo);
            this.TabPage1.Controls.Add(this.CommissionValue);
            this.TabPage1.Controls.Add(this.Commission);
            this.TabPage1.Controls.Add(this.Converted);
            this.TabPage1.Controls.Add(this.ConvertLabel);
            this.TabPage1.Controls.Add(this.comboBox1);
            this.TabPage1.Controls.Add(this.TextBox10);
            this.TabPage1.Controls.Add(this.TextBox9);
            this.TabPage1.Controls.Add(this.TextBox8);
            this.TabPage1.Controls.Add(this.TextBox7);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.MenuStrip1);
            this.TabPage1.ForeColor = System.Drawing.Color.Transparent;
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(696, 335);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Buy";
            // 
            // FlatFeeConverted
            // 
            this.FlatFeeConverted.AutoSize = true;
            this.FlatFeeConverted.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatFeeConverted.Location = new System.Drawing.Point(558, 134);
            this.FlatFeeConverted.Name = "FlatFeeConverted";
            this.FlatFeeConverted.Size = new System.Drawing.Size(14, 13);
            this.FlatFeeConverted.TabIndex = 22;
            this.FlatFeeConverted.Text = "0";
            // 
            // FlatFee
            // 
            this.FlatFee.AutoSize = true;
            this.FlatFee.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatFee.Location = new System.Drawing.Point(452, 134);
            this.FlatFee.Name = "FlatFee";
            this.FlatFee.Size = new System.Drawing.Size(56, 13);
            this.FlatFee.TabIndex = 21;
            this.FlatFee.Text = "Flat Fee:";
            // 
            // FlatFeeTextBox
            // 
            this.FlatFeeTextBox.Location = new System.Drawing.Point(124, 190);
            this.FlatFeeTextBox.Name = "FlatFeeTextBox";
            this.FlatFeeTextBox.Size = new System.Drawing.Size(121, 20);
            this.FlatFeeTextBox.TabIndex = 20;
            this.FlatFeeTextBox.TextChanged += new System.EventHandler(this.FlatFeeTextBox_TextChanged);
            // 
            // FlatFeeLabel
            // 
            this.FlatFeeLabel.AutoSize = true;
            this.FlatFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatFeeLabel.Location = new System.Drawing.Point(8, 193);
            this.FlatFeeLabel.Name = "FlatFeeLabel";
            this.FlatFeeLabel.Size = new System.Drawing.Size(57, 15);
            this.FlatFeeLabel.TabIndex = 19;
            this.FlatFeeLabel.Text = "Flat Fee: ";
            // 
            // BuyTitle
            // 
            this.BuyTitle.AutoSize = true;
            this.BuyTitle.BackColor = System.Drawing.Color.White;
            this.BuyTitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.BuyTitle.Location = new System.Drawing.Point(298, 10);
            this.BuyTitle.Name = "BuyTitle";
            this.BuyTitle.Size = new System.Drawing.Size(47, 23);
            this.BuyTitle.TabIndex = 18;
            this.BuyTitle.Text = "BUY";
            // 
            // BuyingPrintButton
            // 
            this.BuyingPrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyingPrintButton.ForeColor = System.Drawing.Color.Black;
            this.BuyingPrintButton.Location = new System.Drawing.Point(455, 175);
            this.BuyingPrintButton.Name = "BuyingPrintButton";
            this.BuyingPrintButton.Size = new System.Drawing.Size(196, 33);
            this.BuyingPrintButton.TabIndex = 17;
            this.BuyingPrintButton.Text = "Print";
            this.BuyingPrintButton.UseVisualStyleBackColor = true;
            this.BuyingPrintButton.Click += new System.EventHandler(this.BuyingPrintButton_Click);
            // 
            // BuyingGo
            // 
            this.BuyingGo.ForeColor = System.Drawing.Color.Black;
            this.BuyingGo.Location = new System.Drawing.Point(278, 244);
            this.BuyingGo.Name = "BuyingGo";
            this.BuyingGo.Size = new System.Drawing.Size(67, 21);
            this.BuyingGo.TabIndex = 16;
            this.BuyingGo.Text = "Convert";
            this.BuyingGo.UseVisualStyleBackColor = true;
            this.BuyingGo.Click += new System.EventHandler(this.BuyingGo_Click);
            // 
            // CommissionValue
            // 
            this.CommissionValue.AutoSize = true;
            this.CommissionValue.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommissionValue.Location = new System.Drawing.Point(558, 102);
            this.CommissionValue.Name = "CommissionValue";
            this.CommissionValue.Size = new System.Drawing.Size(14, 13);
            this.CommissionValue.TabIndex = 15;
            this.CommissionValue.Text = "0";
            // 
            // Commission
            // 
            this.Commission.AutoSize = true;
            this.Commission.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commission.Location = new System.Drawing.Point(452, 102);
            this.Commission.Name = "Commission";
            this.Commission.Size = new System.Drawing.Size(82, 13);
            this.Commission.TabIndex = 14;
            this.Commission.Text = "Commission:";
            // 
            // Converted
            // 
            this.Converted.AutoSize = true;
            this.Converted.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Converted.Location = new System.Drawing.Point(558, 69);
            this.Converted.Name = "Converted";
            this.Converted.Size = new System.Drawing.Size(14, 13);
            this.Converted.TabIndex = 13;
            this.Converted.Text = "0";
            // 
            // ConvertLabel
            // 
            this.ConvertLabel.AutoSize = true;
            this.ConvertLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertLabel.Location = new System.Drawing.Point(452, 69);
            this.ConvertLabel.Name = "ConvertLabel";
            this.ConvertLabel.Size = new System.Drawing.Size(76, 13);
            this.ConvertLabel.TabIndex = 12;
            this.ConvertLabel.Text = "Converted: ";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TextBox10
            // 
            this.TextBox10.Location = new System.Drawing.Point(124, 245);
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.Size = new System.Drawing.Size(121, 20);
            this.TextBox10.TabIndex = 9;
            // 
            // TextBox9
            // 
            this.TextBox9.Location = new System.Drawing.Point(124, 159);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.Size = new System.Drawing.Size(121, 20);
            this.TextBox9.TabIndex = 8;
            this.TextBox9.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // TextBox8
            // 
            this.TextBox8.Location = new System.Drawing.Point(124, 127);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(121, 20);
            this.TextBox8.TabIndex = 7;
            this.TextBox8.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // TextBox7
            // 
            this.TextBox7.Location = new System.Drawing.Point(124, 95);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(121, 20);
            this.TextBox7.TabIndex = 6;
            this.TextBox7.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(7, 245);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(53, 21);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "Total:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(8, 159);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(82, 15);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Commission: ";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(8, 127);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(39, 15);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "Rate: ";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(8, 95);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(55, 15);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "Amount: ";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(8, 62);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(98, 15);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Select Currency: ";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.AutoSize = false;
            this.MenuStrip1.BackColor = System.Drawing.Color.White;
            this.MenuStrip1.Location = new System.Drawing.Point(3, 3);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(690, 40);
            this.MenuStrip1.TabIndex = 10;
            this.MenuStrip1.Text = "Hello";
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.Maroon;
            this.TabPage2.Controls.Add(this.FlatFeeSellingTextBox);
            this.TabPage2.Controls.Add(this.FlatLabel);
            this.TabPage2.Controls.Add(this.FlatFeeSellingConv);
            this.TabPage2.Controls.Add(this.FlatFeeSell);
            this.TabPage2.Controls.Add(this.SellingPrintButton);
            this.TabPage2.Controls.Add(this.SellTitle);
            this.TabPage2.Controls.Add(this.SellingGo);
            this.TabPage2.Controls.Add(this.SellCommValue);
            this.TabPage2.Controls.Add(this.SellConverted);
            this.TabPage2.Controls.Add(this.SellComm);
            this.TabPage2.Controls.Add(this.comboBox2);
            this.TabPage2.Controls.Add(this.conForex);
            this.TabPage2.Controls.Add(this.MenuStrip2);
            this.TabPage2.Controls.Add(this.TextBox16);
            this.TabPage2.Controls.Add(this.TextBox17);
            this.TabPage2.Controls.Add(this.TextBox18);
            this.TabPage2.Controls.Add(this.TextBox19);
            this.TabPage2.Controls.Add(this.Label15);
            this.TabPage2.Controls.Add(this.Label16);
            this.TabPage2.Controls.Add(this.Label17);
            this.TabPage2.Controls.Add(this.Label18);
            this.TabPage2.Controls.Add(this.Label19);
            this.TabPage2.ForeColor = System.Drawing.Color.White;
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(696, 335);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Sell";
            // 
            // FlatFeeSellingTextBox
            // 
            this.FlatFeeSellingTextBox.Location = new System.Drawing.Point(124, 190);
            this.FlatFeeSellingTextBox.Name = "FlatFeeSellingTextBox";
            this.FlatFeeSellingTextBox.Size = new System.Drawing.Size(121, 20);
            this.FlatFeeSellingTextBox.TabIndex = 32;
            this.FlatFeeSellingTextBox.TextChanged += new System.EventHandler(this.FlatFeeSellingTextBox_TextChanged);
            // 
            // FlatLabel
            // 
            this.FlatLabel.AutoSize = true;
            this.FlatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatLabel.Location = new System.Drawing.Point(8, 193);
            this.FlatLabel.Name = "FlatLabel";
            this.FlatLabel.Size = new System.Drawing.Size(57, 15);
            this.FlatLabel.TabIndex = 31;
            this.FlatLabel.Text = "Flat Fee: ";
            // 
            // FlatFeeSellingConv
            // 
            this.FlatFeeSellingConv.AutoSize = true;
            this.FlatFeeSellingConv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatFeeSellingConv.Location = new System.Drawing.Point(558, 134);
            this.FlatFeeSellingConv.Name = "FlatFeeSellingConv";
            this.FlatFeeSellingConv.Size = new System.Drawing.Size(14, 13);
            this.FlatFeeSellingConv.TabIndex = 30;
            this.FlatFeeSellingConv.Text = "0";
            // 
            // FlatFeeSell
            // 
            this.FlatFeeSell.AutoSize = true;
            this.FlatFeeSell.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatFeeSell.Location = new System.Drawing.Point(452, 134);
            this.FlatFeeSell.Name = "FlatFeeSell";
            this.FlatFeeSell.Size = new System.Drawing.Size(56, 13);
            this.FlatFeeSell.TabIndex = 29;
            this.FlatFeeSell.Text = "Flat Fee:";
            // 
            // SellingPrintButton
            // 
            this.SellingPrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingPrintButton.ForeColor = System.Drawing.Color.Black;
            this.SellingPrintButton.Location = new System.Drawing.Point(455, 175);
            this.SellingPrintButton.Name = "SellingPrintButton";
            this.SellingPrintButton.Size = new System.Drawing.Size(196, 33);
            this.SellingPrintButton.TabIndex = 28;
            this.SellingPrintButton.Text = "Print";
            this.SellingPrintButton.UseVisualStyleBackColor = true;
            this.SellingPrintButton.Click += new System.EventHandler(this.SellingPrintButton_Click);
            // 
            // SellTitle
            // 
            this.SellTitle.AutoSize = true;
            this.SellTitle.BackColor = System.Drawing.Color.White;
            this.SellTitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellTitle.ForeColor = System.Drawing.Color.Maroon;
            this.SellTitle.Location = new System.Drawing.Point(298, 10);
            this.SellTitle.Name = "SellTitle";
            this.SellTitle.Size = new System.Drawing.Size(56, 23);
            this.SellTitle.TabIndex = 27;
            this.SellTitle.Text = "SELL";
            // 
            // SellingGo
            // 
            this.SellingGo.ForeColor = System.Drawing.Color.Black;
            this.SellingGo.Location = new System.Drawing.Point(278, 244);
            this.SellingGo.Name = "SellingGo";
            this.SellingGo.Size = new System.Drawing.Size(67, 21);
            this.SellingGo.TabIndex = 26;
            this.SellingGo.Text = "Convert";
            this.SellingGo.UseVisualStyleBackColor = true;
            this.SellingGo.Click += new System.EventHandler(this.SellingGo_Click);
            // 
            // SellCommValue
            // 
            this.SellCommValue.AutoSize = true;
            this.SellCommValue.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellCommValue.Location = new System.Drawing.Point(558, 102);
            this.SellCommValue.Name = "SellCommValue";
            this.SellCommValue.Size = new System.Drawing.Size(14, 13);
            this.SellCommValue.TabIndex = 25;
            this.SellCommValue.Text = "0";
            // 
            // SellConverted
            // 
            this.SellConverted.AutoSize = true;
            this.SellConverted.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellConverted.Location = new System.Drawing.Point(558, 69);
            this.SellConverted.Name = "SellConverted";
            this.SellConverted.Size = new System.Drawing.Size(14, 13);
            this.SellConverted.TabIndex = 24;
            this.SellConverted.Text = "0";
            // 
            // SellComm
            // 
            this.SellComm.AutoSize = true;
            this.SellComm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellComm.Location = new System.Drawing.Point(452, 102);
            this.SellComm.Name = "SellComm";
            this.SellComm.Size = new System.Drawing.Size(82, 13);
            this.SellComm.TabIndex = 23;
            this.SellComm.Text = "Commission:";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(124, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // conForex
            // 
            this.conForex.AutoSize = true;
            this.conForex.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conForex.Location = new System.Drawing.Point(452, 69);
            this.conForex.Name = "conForex";
            this.conForex.Size = new System.Drawing.Size(76, 13);
            this.conForex.TabIndex = 21;
            this.conForex.Text = "Converted: ";
            // 
            // MenuStrip2
            // 
            this.MenuStrip2.AutoSize = false;
            this.MenuStrip2.BackColor = System.Drawing.Color.White;
            this.MenuStrip2.Location = new System.Drawing.Point(3, 3);
            this.MenuStrip2.Name = "MenuStrip2";
            this.MenuStrip2.Size = new System.Drawing.Size(690, 40);
            this.MenuStrip2.TabIndex = 20;
            this.MenuStrip2.Text = "Hello";
            // 
            // TextBox16
            // 
            this.TextBox16.Location = new System.Drawing.Point(124, 245);
            this.TextBox16.Name = "TextBox16";
            this.TextBox16.Size = new System.Drawing.Size(121, 20);
            this.TextBox16.TabIndex = 19;
            // 
            // TextBox17
            // 
            this.TextBox17.Location = new System.Drawing.Point(124, 159);
            this.TextBox17.Name = "TextBox17";
            this.TextBox17.Size = new System.Drawing.Size(121, 20);
            this.TextBox17.TabIndex = 18;
            this.TextBox17.TextChanged += new System.EventHandler(this.TextBox17_TextChanged);
            // 
            // TextBox18
            // 
            this.TextBox18.Location = new System.Drawing.Point(124, 127);
            this.TextBox18.Name = "TextBox18";
            this.TextBox18.Size = new System.Drawing.Size(121, 20);
            this.TextBox18.TabIndex = 17;
            this.TextBox18.TextChanged += new System.EventHandler(this.TextBox18_TextChanged);
            // 
            // TextBox19
            // 
            this.TextBox19.Location = new System.Drawing.Point(124, 95);
            this.TextBox19.Name = "TextBox19";
            this.TextBox19.Size = new System.Drawing.Size(121, 20);
            this.TextBox19.TabIndex = 16;
            this.TextBox19.TextChanged += new System.EventHandler(this.TextBox19_TextChanged);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(7, 245);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(53, 21);
            this.Label15.TabIndex = 14;
            this.Label15.Text = "Total:";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(8, 159);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(82, 15);
            this.Label16.TabIndex = 13;
            this.Label16.Text = "Commission: ";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(8, 127);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(39, 15);
            this.Label17.TabIndex = 12;
            this.Label17.Text = "Rate: ";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.Location = new System.Drawing.Point(8, 95);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(55, 15);
            this.Label18.TabIndex = 11;
            this.Label18.Text = "Amount: ";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(8, 62);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(98, 15);
            this.Label19.TabIndex = 10;
            this.Label19.Text = "Select Currency: ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SaddleBrown;
            this.tabPage3.Controls.Add(this.SearchButton);
            this.tabPage3.Controls.Add(this.CompanyTextBox);
            this.tabPage3.Controls.Add(this.CompanyLabel);
            this.tabPage3.Controls.Add(this.PasswordLabel);
            this.tabPage3.Controls.Add(this.PasswordTextBox);
            this.tabPage3.Controls.Add(this.ACNTextBox);
            this.tabPage3.Controls.Add(this.ACNLabel);
            this.tabPage3.Controls.Add(this.StoreAddressTextBox);
            this.tabPage3.Controls.Add(this.StoreAddressLabel);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.uploadButton);
            this.tabPage3.Controls.Add(this.textBoxPath);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(696, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Admin";
            this.tabPage3.Leave += new System.EventHandler(this.tabPage3_Leave);
            // 
            // SearchButton
            // 
            this.SearchButton.ForeColor = System.Drawing.Color.Black;
            this.SearchButton.Location = new System.Drawing.Point(292, 9);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CompanyTextBox
            // 
            this.CompanyTextBox.Enabled = false;
            this.CompanyTextBox.Location = new System.Drawing.Point(462, 63);
            this.CompanyTextBox.Name = "CompanyTextBox";
            this.CompanyTextBox.Size = new System.Drawing.Size(208, 20);
            this.CompanyTextBox.TabIndex = 12;
            this.CompanyTextBox.TextChanged += new System.EventHandler(this.CompanyTextBox_TextChanged);
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.Location = new System.Drawing.Point(459, 41);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(112, 15);
            this.CompanyLabel.TabIndex = 11;
            this.CompanyLabel.Text = "Company Name:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(459, 256);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(73, 15);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(462, 276);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(208, 20);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // ACNTextBox
            // 
            this.ACNTextBox.Enabled = false;
            this.ACNTextBox.Location = new System.Drawing.Point(462, 217);
            this.ACNTextBox.Name = "ACNTextBox";
            this.ACNTextBox.Size = new System.Drawing.Size(208, 20);
            this.ACNTextBox.TabIndex = 7;
            this.ACNTextBox.TextChanged += new System.EventHandler(this.ACNTextBox_TextChanged);
            // 
            // ACNLabel
            // 
            this.ACNLabel.AutoSize = true;
            this.ACNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACNLabel.Location = new System.Drawing.Point(459, 196);
            this.ACNLabel.Name = "ACNLabel";
            this.ACNLabel.Size = new System.Drawing.Size(46, 15);
            this.ACNLabel.TabIndex = 6;
            this.ACNLabel.Text = "A.C.N:";
            // 
            // StoreAddressTextBox
            // 
            this.StoreAddressTextBox.Enabled = false;
            this.StoreAddressTextBox.Location = new System.Drawing.Point(462, 126);
            this.StoreAddressTextBox.Name = "StoreAddressTextBox";
            this.StoreAddressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StoreAddressTextBox.Size = new System.Drawing.Size(209, 49);
            this.StoreAddressTextBox.TabIndex = 5;
            this.StoreAddressTextBox.Text = "";
            this.StoreAddressTextBox.TextChanged += new System.EventHandler(this.StoreAddressTextBox_TextChanged);
            // 
            // StoreAddressLabel
            // 
            this.StoreAddressLabel.AutoSize = true;
            this.StoreAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreAddressLabel.Location = new System.Drawing.Point(459, 105);
            this.StoreAddressLabel.Name = "StoreAddressLabel";
            this.StoreAddressLabel.Size = new System.Drawing.Size(100, 15);
            this.StoreAddressLabel.TabIndex = 4;
            this.StoreAddressLabel.Text = "Store Address:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 255);
            this.dataGridView1.TabIndex = 3;
            // 
            // uploadButton
            // 
            this.uploadButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uploadButton.Location = new System.Drawing.Point(377, 9);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(75, 23);
            this.uploadButton.TabIndex = 2;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(73, 11);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(213, 20);
            this.textBoxPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path: ";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage4.Controls.Add(this.TransactionPwdTextBox);
            this.tabPage4.Controls.Add(this.PasswordTransLabel);
            this.tabPage4.Controls.Add(this.ClearTransactionsButton);
            this.tabPage4.Controls.Add(this.dateTimePicker1);
            this.tabPage4.Controls.Add(this.tableDataGrid1);
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(696, 335);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transactions";
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            this.tabPage4.Leave += new System.EventHandler(this.tabPage4_Leave);
            // 
            // TransactionPwdTextBox
            // 
            this.TransactionPwdTextBox.Location = new System.Drawing.Point(338, 16);
            this.TransactionPwdTextBox.Name = "TransactionPwdTextBox";
            this.TransactionPwdTextBox.PasswordChar = '*';
            this.TransactionPwdTextBox.Size = new System.Drawing.Size(100, 20);
            this.TransactionPwdTextBox.TabIndex = 4;
            this.TransactionPwdTextBox.TextChanged += new System.EventHandler(this.TransactionPwdTextBox_TextChanged);
            // 
            // PasswordTransLabel
            // 
            this.PasswordTransLabel.AutoSize = true;
            this.PasswordTransLabel.Location = new System.Drawing.Point(279, 19);
            this.PasswordTransLabel.Name = "PasswordTransLabel";
            this.PasswordTransLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordTransLabel.TabIndex = 3;
            this.PasswordTransLabel.Text = "Password:";
            // 
            // ClearTransactionsButton
            // 
            this.ClearTransactionsButton.Enabled = false;
            this.ClearTransactionsButton.Location = new System.Drawing.Point(516, 14);
            this.ClearTransactionsButton.Name = "ClearTransactionsButton";
            this.ClearTransactionsButton.Size = new System.Drawing.Size(118, 23);
            this.ClearTransactionsButton.TabIndex = 2;
            this.ClearTransactionsButton.Text = "Clear Transactions";
            this.ClearTransactionsButton.UseVisualStyleBackColor = true;
            this.ClearTransactionsButton.Click += new System.EventHandler(this.ClearTransactionsButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2016, 12, 16, 18, 0, 56, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tableDataGrid1
            // 
            this.tableDataGrid1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.tableDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGrid1.Location = new System.Drawing.Point(8, 54);
            this.tableDataGrid1.Name = "tableDataGrid1";
            this.tableDataGrid1.Size = new System.Drawing.Size(626, 245);
            this.tableDataGrid1.TabIndex = 0;
            // 
            // TextBox11
            // 
            this.TextBox11.Location = new System.Drawing.Point(124, 182);
            this.TextBox11.Name = "TextBox11";
            this.TextBox11.Size = new System.Drawing.Size(121, 20);
            this.TextBox11.TabIndex = 9;
            // 
            // TextBox12
            // 
            this.TextBox12.Location = new System.Drawing.Point(124, 145);
            this.TextBox12.Name = "TextBox12";
            this.TextBox12.Size = new System.Drawing.Size(121, 20);
            this.TextBox12.TabIndex = 8;
            // 
            // TextBox13
            // 
            this.TextBox13.Location = new System.Drawing.Point(124, 113);
            this.TextBox13.Name = "TextBox13";
            this.TextBox13.Size = new System.Drawing.Size(121, 20);
            this.TextBox13.TabIndex = 7;
            // 
            // TextBox14
            // 
            this.TextBox14.Location = new System.Drawing.Point(124, 81);
            this.TextBox14.Name = "TextBox14";
            this.TextBox14.Size = new System.Drawing.Size(121, 20);
            this.TextBox14.TabIndex = 6;
            // 
            // TextBox15
            // 
            this.TextBox15.Location = new System.Drawing.Point(124, 48);
            this.TextBox15.Name = "TextBox15";
            this.TextBox15.Size = new System.Drawing.Size(121, 20);
            this.TextBox15.TabIndex = 5;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(8, 182);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(53, 21);
            this.Label10.TabIndex = 4;
            this.Label10.Text = "Total:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(8, 145);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(82, 15);
            this.Label11.TabIndex = 3;
            this.Label11.Text = "Commission: ";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(8, 113);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(39, 15);
            this.Label12.TabIndex = 2;
            this.Label12.Text = "Rate: ";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(8, 81);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(55, 15);
            this.Label13.TabIndex = 1;
            this.Label13.Text = "Amount: ";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(8, 48);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(98, 15);
            this.Label14.TabIndex = 0;
            this.Label14.Text = "Select Currency: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 360);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "POS";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing");
        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TextBox TextBox10;
        internal System.Windows.Forms.TextBox TextBox9;
        internal System.Windows.Forms.TextBox TextBox8;
        internal System.Windows.Forms.TextBox TextBox7;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TextBox TextBox16;
        internal System.Windows.Forms.TextBox TextBox17;
        internal System.Windows.Forms.TextBox TextBox18;
        internal System.Windows.Forms.TextBox TextBox19;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox TextBox11;
        internal System.Windows.Forms.TextBox TextBox12;
        internal System.Windows.Forms.TextBox TextBox13;
        internal System.Windows.Forms.TextBox TextBox14;
        internal System.Windows.Forms.TextBox TextBox15;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        private ComboBox comboBox1;
        private ErrorProvider errorProvider1;
        private Label Converted;
        private Label ConvertLabel;
        private Label CommissionValue;
        private Label Commission;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private Button uploadButton;
        private TextBox textBoxPath;
        private Label label1;
        private TabPage tabPage4;
        private Label SellCommValue;
        private Label SellConverted;
        private Label SellComm;
        private ComboBox comboBox2;
        private Label conForex;
        private Button SellingGo;
        private Button BuyingGo;
        private Button BuyingPrintButton;
        private DataGridView tableDataGrid1;
        private DateTimePicker dateTimePicker1;
        private Label BuyTitle;
        internal MenuStrip MenuStrip1;
        private Label SellTitle;
        internal MenuStrip MenuStrip2;
        private Button SellingPrintButton;
        private RichTextBox StoreAddressTextBox;
        private Label StoreAddressLabel;
        private Label ACNLabel;
        private TextBox ACNTextBox;
        private TextBox CompanyTextBox;
        private Label CompanyLabel;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        internal TextBox FlatFeeTextBox;
        internal Label FlatFeeLabel;
        private Label FlatFee;
        private Label FlatFeeConverted;
        private Label FlatFeeSellingConv;
        private Label FlatFeeSell;
        internal TextBox FlatFeeSellingTextBox;
        internal Label FlatLabel;
        private TextBox TransactionPwdTextBox;
        private Label PasswordTransLabel;
        private Button ClearTransactionsButton;
        private Button SearchButton;
        //private object bindingSourceCurrency;
    }
}

