namespace Rdd_Convertor_GUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Calc_Worth = new System.Windows.Forms.Button();
            this.btn_Load_Config = new System.Windows.Forms.Button();
            this.btn_Save_Config = new System.Windows.Forms.Button();
            this.tb_Coins_Held = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Sat_Per_Rdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_BTC_Value = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Currency = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Get_BTC_Price = new System.Windows.Forms.Button();
            this.btn_Get_Rdd_Price = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Calc_Worth = new System.Windows.Forms.TextBox();
            this.tb_Calc_Need_Out = new System.Windows.Forms.TextBox();
            this.btn_Calc_Need = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_Calc_Need_In = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Calc_Worth
            // 
            this.btn_Calc_Worth.Location = new System.Drawing.Point(18, 24);
            this.btn_Calc_Worth.Name = "btn_Calc_Worth";
            this.btn_Calc_Worth.Size = new System.Drawing.Size(75, 23);
            this.btn_Calc_Worth.TabIndex = 0;
            this.btn_Calc_Worth.Text = "Calculate";
            this.btn_Calc_Worth.UseVisualStyleBackColor = true;
            this.btn_Calc_Worth.Click += new System.EventHandler(this.btn_Calc_Worth_Click);
            // 
            // btn_Load_Config
            // 
            this.btn_Load_Config.Location = new System.Drawing.Point(16, 101);
            this.btn_Load_Config.Name = "btn_Load_Config";
            this.btn_Load_Config.Size = new System.Drawing.Size(50, 23);
            this.btn_Load_Config.TabIndex = 1;
            this.btn_Load_Config.Text = "Load";
            this.btn_Load_Config.UseVisualStyleBackColor = true;
            this.btn_Load_Config.Click += new System.EventHandler(this.btn_Load_Config_Click);
            // 
            // btn_Save_Config
            // 
            this.btn_Save_Config.Location = new System.Drawing.Point(73, 101);
            this.btn_Save_Config.Name = "btn_Save_Config";
            this.btn_Save_Config.Size = new System.Drawing.Size(50, 23);
            this.btn_Save_Config.TabIndex = 2;
            this.btn_Save_Config.Text = "Save";
            this.btn_Save_Config.UseVisualStyleBackColor = true;
            this.btn_Save_Config.Click += new System.EventHandler(this.btn_Save_Config_Click);
            // 
            // tb_Coins_Held
            // 
            this.tb_Coins_Held.Location = new System.Drawing.Point(131, 17);
            this.tb_Coins_Held.Name = "tb_Coins_Held";
            this.tb_Coins_Held.Size = new System.Drawing.Size(122, 20);
            this.tb_Coins_Held.TabIndex = 3;
            this.tb_Coins_Held.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Coins Held";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Satoshi per Rdd";
            // 
            // tb_Sat_Per_Rdd
            // 
            this.tb_Sat_Per_Rdd.Location = new System.Drawing.Point(131, 43);
            this.tb_Sat_Per_Rdd.Name = "tb_Sat_Per_Rdd";
            this.tb_Sat_Per_Rdd.Size = new System.Drawing.Size(122, 20);
            this.tb_Sat_Per_Rdd.TabIndex = 5;
            this.tb_Sat_Per_Rdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "BTC Fiat Value";
            // 
            // tb_BTC_Value
            // 
            this.tb_BTC_Value.Location = new System.Drawing.Point(131, 69);
            this.tb_BTC_Value.Name = "tb_BTC_Value";
            this.tb_BTC_Value.Size = new System.Drawing.Size(122, 20);
            this.tb_BTC_Value.TabIndex = 7;
            this.tb_BTC_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Currency);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Get_BTC_Price);
            this.groupBox1.Controls.Add(this.btn_Get_Rdd_Price);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_BTC_Value);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_Sat_Per_Rdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Coins_Held);
            this.groupBox1.Controls.Add(this.btn_Save_Config);
            this.groupBox1.Controls.Add(this.btn_Load_Config);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // cb_Currency
            // 
            this.cb_Currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Currency.FormattingEnabled = true;
            this.cb_Currency.Items.AddRange(new object[] {
            "GBP",
            "USD",
            "EUR"});
            this.cb_Currency.Location = new System.Drawing.Point(65, 132);
            this.cb_Currency.Name = "cb_Currency";
            this.cb_Currency.Size = new System.Drawing.Size(57, 21);
            this.cb_Currency.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Currency";
            // 
            // btn_Get_BTC_Price
            // 
            this.btn_Get_BTC_Price.Location = new System.Drawing.Point(131, 130);
            this.btn_Get_BTC_Price.Name = "btn_Get_BTC_Price";
            this.btn_Get_BTC_Price.Size = new System.Drawing.Size(122, 23);
            this.btn_Get_BTC_Price.TabIndex = 10;
            this.btn_Get_BTC_Price.Text = "Get 24hr BTC";
            this.btn_Get_BTC_Price.UseVisualStyleBackColor = true;
            this.btn_Get_BTC_Price.Click += new System.EventHandler(this.btn_Get_BTC_Price_Click);
            // 
            // btn_Get_Rdd_Price
            // 
            this.btn_Get_Rdd_Price.Location = new System.Drawing.Point(132, 101);
            this.btn_Get_Rdd_Price.Name = "btn_Get_Rdd_Price";
            this.btn_Get_Rdd_Price.Size = new System.Drawing.Size(122, 23);
            this.btn_Get_Rdd_Price.TabIndex = 9;
            this.btn_Get_Rdd_Price.Text = "Get Latest Rdd";
            this.btn_Get_Rdd_Price.UseVisualStyleBackColor = true;
            this.btn_Get_Rdd_Price.Click += new System.EventHandler(this.btn_Get_Rdd_Price_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Calc_Worth);
            this.groupBox2.Controls.Add(this.btn_Calc_Worth);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 61);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "How Much Are My Coins Worth?";
            // 
            // tb_Calc_Worth
            // 
            this.tb_Calc_Worth.Location = new System.Drawing.Point(131, 27);
            this.tb_Calc_Worth.Name = "tb_Calc_Worth";
            this.tb_Calc_Worth.Size = new System.Drawing.Size(122, 20);
            this.tb_Calc_Worth.TabIndex = 9;
            this.tb_Calc_Worth.Text = "----------------------------------------------------";
            this.tb_Calc_Worth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Calc_Need_Out
            // 
            this.tb_Calc_Need_Out.Location = new System.Drawing.Point(184, 27);
            this.tb_Calc_Need_Out.Name = "tb_Calc_Need_Out";
            this.tb_Calc_Need_Out.Size = new System.Drawing.Size(69, 20);
            this.tb_Calc_Need_Out.TabIndex = 9;
            this.tb_Calc_Need_Out.Text = "--------------------------------------------------";
            this.tb_Calc_Need_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Calc_Need
            // 
            this.btn_Calc_Need.Location = new System.Drawing.Point(95, 25);
            this.btn_Calc_Need.Name = "btn_Calc_Need";
            this.btn_Calc_Need.Size = new System.Drawing.Size(75, 23);
            this.btn_Calc_Need.TabIndex = 0;
            this.btn_Calc_Need.Text = "Calculate";
            this.btn_Calc_Need.UseVisualStyleBackColor = true;
            this.btn_Calc_Need.Click += new System.EventHandler(this.btn_Calc_Need_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_Calc_Need_In);
            this.groupBox3.Controls.Add(this.tb_Calc_Need_Out);
            this.groupBox3.Controls.Add(this.btn_Calc_Need);
            this.groupBox3.Location = new System.Drawing.Point(13, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 61);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "What Do I Need The Rate To Be To Have ...";
            // 
            // tb_Calc_Need_In
            // 
            this.tb_Calc_Need_In.Location = new System.Drawing.Point(17, 27);
            this.tb_Calc_Need_In.Name = "tb_Calc_Need_In";
            this.tb_Calc_Need_In.Size = new System.Drawing.Size(69, 20);
            this.tb_Calc_Need_In.TabIndex = 10;
            this.tb_Calc_Need_In.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 316);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rdd Currency Convertor v1.2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Calc_Worth;
        private System.Windows.Forms.Button btn_Load_Config;
        private System.Windows.Forms.Button btn_Save_Config;
        private System.Windows.Forms.TextBox tb_Coins_Held;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Sat_Per_Rdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_BTC_Value;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Calc_Worth;
        private System.Windows.Forms.TextBox tb_Calc_Need_Out;
        private System.Windows.Forms.Button btn_Calc_Need;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_Calc_Need_In;
        private System.Windows.Forms.Button btn_Get_BTC_Price;
        private System.Windows.Forms.Button btn_Get_Rdd_Price;
        private System.Windows.Forms.ComboBox cb_Currency;
        private System.Windows.Forms.Label label4;
    }
}

