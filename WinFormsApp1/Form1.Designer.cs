namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			startValue = new TextBox();
			calculate = new Button();
			label1 = new Label();
			label4 = new Label();
			periodicAdditions = new TextBox();
			label5 = new Label();
			label8 = new Label();
			projectedValue = new TextBox();
			label2 = new Label();
			label3 = new Label();
			attivocosts = new TextBox();
			label6 = new Label();
			alltrustcosts = new TextBox();
			label7 = new Label();
			brewincosts = new TextBox();
			label9 = new Label();
			label10 = new Label();
			label11 = new Label();
			totalcosts = new TextBox();
			label12 = new Label();
			label13 = new Label();
			label14 = new Label();
			y1 = new TextBox();
			label15 = new Label();
			label16 = new Label();
			label17 = new Label();
			label18 = new Label();
			y2 = new TextBox();
			label19 = new Label();
			label20 = new Label();
			y3 = new TextBox();
			label21 = new Label();
			label22 = new Label();
			y4 = new TextBox();
			label23 = new Label();
			label24 = new Label();
			y5 = new TextBox();
			label25 = new Label();
			label26 = new Label();
			y10 = new TextBox();
			label27 = new Label();
			label28 = new Label();
			y9 = new TextBox();
			label29 = new Label();
			label30 = new Label();
			y8 = new TextBox();
			label31 = new Label();
			label32 = new Label();
			y7 = new TextBox();
			label33 = new Label();
			label34 = new Label();
			y6 = new TextBox();
			label35 = new Label();
			comboBox1 = new ComboBox();
			SuspendLayout();
			// 
			// startValue
			// 
			startValue.BackColor = Color.DeepSkyBlue;
			startValue.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			startValue.Location = new Point(260, 69);
			startValue.Margin = new Padding(4);
			startValue.Name = "startValue";
			startValue.Size = new Size(197, 34);
			startValue.TabIndex = 0;
			startValue.Text = "1,000,000.00";
			startValue.TextChanged += startValue_TextChanged;
			startValue.Enter += startValue_Enter;
			startValue.KeyPress += startValue_KeyPress;
			startValue.Leave += startValue_Leave;
			// 
			// calculate
			// 
			calculate.Location = new Point(963, 746);
			calculate.Margin = new Padding(4);
			calculate.Name = "calculate";
			calculate.Size = new Size(139, 77);
			calculate.TabIndex = 1;
			calculate.Text = "Calculate";
			calculate.UseVisualStyleBackColor = true;
			calculate.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(100, 73);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(133, 28);
			label1.TabIndex = 2;
			label1.Text = "Starting Value";
			label1.TextAlign = ContentAlignment.TopCenter;
			label1.Click += label1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(57, 128);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(172, 28);
			label4.TabIndex = 8;
			label4.Text = "Periodic Additions";
			label4.TextAlign = ContentAlignment.TopCenter;
			// 
			// periodicAdditions
			// 
			periodicAdditions.BackColor = Color.DeepSkyBlue;
			periodicAdditions.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			periodicAdditions.Location = new Point(260, 124);
			periodicAdditions.Margin = new Padding(4);
			periodicAdditions.Name = "periodicAdditions";
			periodicAdditions.Size = new Size(197, 34);
			periodicAdditions.TabIndex = 7;
			periodicAdditions.Text = "1";
			periodicAdditions.KeyPress += periodicAdditions_KeyPress;
			periodicAdditions.Leave += periodicAdditions_Leave;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(468, 69);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(36, 28);
			label5.TabIndex = 9;
			label5.Text = "£'s";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(84, 185);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(147, 28);
			label8.TabIndex = 14;
			label8.Text = "Projected Value";
			label8.TextAlign = ContentAlignment.TopCenter;
			// 
			// projectedValue
			// 
			projectedValue.BackColor = Color.White;
			projectedValue.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			projectedValue.Location = new Point(260, 181);
			projectedValue.Margin = new Padding(4);
			projectedValue.Name = "projectedValue";
			projectedValue.ReadOnly = true;
			projectedValue.Size = new Size(197, 34);
			projectedValue.TabIndex = 13;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(468, 131);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(36, 28);
			label2.TabIndex = 15;
			label2.Text = "£'s";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(87, 433);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(141, 28);
			label3.TabIndex = 17;
			label3.Text = "Attivo Costs(£)";
			// 
			// attivocosts
			// 
			attivocosts.BackColor = Color.White;
			attivocosts.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			attivocosts.Location = new Point(260, 430);
			attivocosts.Margin = new Padding(4);
			attivocosts.Name = "attivocosts";
			attivocosts.ReadOnly = true;
			attivocosts.Size = new Size(197, 34);
			attivocosts.TabIndex = 16;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(87, 493);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(151, 28);
			label6.TabIndex = 19;
			label6.Text = "AllTrust Costs(£)";
			// 
			// alltrustcosts
			// 
			alltrustcosts.BackColor = Color.White;
			alltrustcosts.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			alltrustcosts.Location = new Point(260, 489);
			alltrustcosts.Margin = new Padding(4);
			alltrustcosts.Name = "alltrustcosts";
			alltrustcosts.ReadOnly = true;
			alltrustcosts.Size = new Size(197, 34);
			alltrustcosts.TabIndex = 18;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(87, 560);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(145, 28);
			label7.TabIndex = 21;
			label7.Text = "Brewin Costs(£)";
			// 
			// brewincosts
			// 
			brewincosts.BackColor = Color.White;
			brewincosts.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			brewincosts.Location = new Point(260, 556);
			brewincosts.Margin = new Padding(4);
			brewincosts.Name = "brewincosts";
			brewincosts.ReadOnly = true;
			brewincosts.Size = new Size(197, 34);
			brewincosts.TabIndex = 20;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(478, 493);
			label9.Margin = new Padding(4, 0, 4, 0);
			label9.Name = "label9";
			label9.Size = new Size(235, 28);
			label9.TabIndex = 22;
			label9.Text = "(Fixed @ £2400/annually)";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(478, 433);
			label10.Margin = new Padding(4, 0, 4, 0);
			label10.Name = "label10";
			label10.Size = new Size(244, 28);
			label10.TabIndex = 23;
			label10.Text = "(0.5% annually start value )";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label11.Location = new Point(130, 250);
			label11.Margin = new Padding(4, 0, 4, 0);
			label11.Name = "label11";
			label11.Size = new Size(106, 28);
			label11.TabIndex = 25;
			label11.Text = "Total Costs";
			label11.TextAlign = ContentAlignment.TopCenter;
			// 
			// totalcosts
			// 
			totalcosts.BackColor = Color.White;
			totalcosts.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			totalcosts.Location = new Point(260, 246);
			totalcosts.Margin = new Padding(4);
			totalcosts.Name = "totalcosts";
			totalcosts.ReadOnly = true;
			totalcosts.Size = new Size(197, 34);
			totalcosts.TabIndex = 24;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label12.Location = new Point(478, 563);
			label12.Margin = new Padding(4, 0, 4, 0);
			label12.Name = "label12";
			label12.Size = new Size(485, 28);
			label12.TabIndex = 26;
			label12.Text = "(0.7% <£1m, 0.6% >£1m - EoY deducted after growth)";
			label12.Click += label12_Click;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(468, 189);
			label13.Margin = new Padding(4, 0, 4, 0);
			label13.Name = "label13";
			label13.Size = new Size(36, 28);
			label13.TabIndex = 27;
			label13.Text = "£'s";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(468, 250);
			label14.Margin = new Padding(4, 0, 4, 0);
			label14.Name = "label14";
			label14.Size = new Size(36, 28);
			label14.TabIndex = 28;
			label14.Text = "£'s";
			// 
			// y1
			// 
			y1.BackColor = SystemColors.ActiveCaptionText;
			y1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			y1.ForeColor = SystemColors.Menu;
			y1.Location = new Point(759, 73);
			y1.Margin = new Padding(4);
			y1.MaxLength = 2;
			y1.Multiline = true;
			y1.Name = "y1";
			y1.Size = new Size(53, 34);
			y1.TabIndex = 29;
			y1.Text = "5";
			y1.Enter += y1_Enter;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label15.Location = new Point(687, 74);
			label15.Margin = new Padding(4, 0, 4, 0);
			label15.Name = "label15";
			label15.Size = new Size(64, 28);
			label15.TabIndex = 30;
			label15.Text = "Year 1";
			label15.TextAlign = ContentAlignment.TopCenter;
			label15.Click += label15_Click;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label16.Location = new Point(814, 74);
			label16.Margin = new Padding(4, 0, 4, 0);
			label16.Name = "label16";
			label16.Size = new Size(28, 28);
			label16.TabIndex = 31;
			label16.Text = "%";
			label16.TextAlign = ContentAlignment.TopCenter;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label17.Location = new Point(814, 116);
			label17.Margin = new Padding(4, 0, 4, 0);
			label17.Name = "label17";
			label17.Size = new Size(28, 28);
			label17.TabIndex = 34;
			label17.Text = "%";
			label17.TextAlign = ContentAlignment.TopCenter;
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label18.Location = new Point(687, 116);
			label18.Margin = new Padding(4, 0, 4, 0);
			label18.Name = "label18";
			label18.Size = new Size(64, 28);
			label18.TabIndex = 33;
			label18.Text = "Year 2";
			label18.TextAlign = ContentAlignment.TopCenter;
			// 
			// y2
			// 
			y2.BackColor = SystemColors.ActiveCaptionText;
			y2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			y2.ForeColor = SystemColors.Menu;
			y2.Location = new Point(759, 114);
			y2.Margin = new Padding(4);
			y2.MaxLength = 2;
			y2.Multiline = true;
			y2.Name = "y2";
			y2.Size = new Size(53, 34);
			y2.TabIndex = 32;
			y2.Text = "6";
			y2.Enter += y2_Enter;
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label19.Location = new Point(814, 157);
			label19.Margin = new Padding(4, 0, 4, 0);
			label19.Name = "label19";
			label19.Size = new Size(28, 28);
			label19.TabIndex = 37;
			label19.Text = "%";
			label19.TextAlign = ContentAlignment.TopCenter;
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label20.Location = new Point(687, 157);
			label20.Margin = new Padding(4, 0, 4, 0);
			label20.Name = "label20";
			label20.Size = new Size(64, 28);
			label20.TabIndex = 36;
			label20.Text = "Year 3";
			label20.TextAlign = ContentAlignment.TopCenter;
			// 
			// y3
			// 
			y3.BackColor = SystemColors.ActiveCaptionText;
			y3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			y3.ForeColor = SystemColors.Menu;
			y3.Location = new Point(759, 156);
			y3.Margin = new Padding(4);
			y3.MaxLength = 2;
			y3.Multiline = true;
			y3.Name = "y3";
			y3.Size = new Size(53, 34);
			y3.TabIndex = 35;
			y3.Text = "6";
			y3.Enter += y3_Enter;
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label21.Location = new Point(814, 198);
			label21.Margin = new Padding(4, 0, 4, 0);
			label21.Name = "label21";
			label21.Size = new Size(28, 28);
			label21.TabIndex = 40;
			label21.Text = "%";
			label21.TextAlign = ContentAlignment.TopCenter;
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label22.Location = new Point(687, 198);
			label22.Margin = new Padding(4, 0, 4, 0);
			label22.Name = "label22";
			label22.Size = new Size(64, 28);
			label22.TabIndex = 39;
			label22.Text = "Year 4";
			label22.TextAlign = ContentAlignment.TopCenter;
			// 
			// y4
			// 
			y4.BackColor = SystemColors.ActiveCaptionText;
			y4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			y4.ForeColor = SystemColors.Menu;
			y4.Location = new Point(759, 197);
			y4.Margin = new Padding(4);
			y4.MaxLength = 2;
			y4.Multiline = true;
			y4.Name = "y4";
			y4.Size = new Size(53, 34);
			y4.TabIndex = 38;
			y4.Text = "0";
			y4.Enter += y4_Enter;
			// 
			// label23
			// 
			label23.AutoSize = true;
			label23.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label23.Location = new Point(814, 240);
			label23.Margin = new Padding(4, 0, 4, 0);
			label23.Name = "label23";
			label23.Size = new Size(28, 28);
			label23.TabIndex = 43;
			label23.Text = "%";
			label23.TextAlign = ContentAlignment.TopCenter;
			// 
			// label24
			// 
			label24.AutoSize = true;
			label24.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label24.Location = new Point(687, 240);
			label24.Margin = new Padding(4, 0, 4, 0);
			label24.Name = "label24";
			label24.Size = new Size(64, 28);
			label24.TabIndex = 42;
			label24.Text = "Year 5";
			label24.TextAlign = ContentAlignment.TopCenter;
			// 
			// y5
			// 
			y5.BackColor = SystemColors.ActiveCaptionText;
			y5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			y5.ForeColor = SystemColors.Menu;
			y5.Location = new Point(759, 239);
			y5.Margin = new Padding(4);
			y5.MaxLength = 2;
			y5.Multiline = true;
			y5.Name = "y5";
			y5.Size = new Size(53, 34);
			y5.TabIndex = 41;
			y5.Text = "0";
			y5.Enter += y5_Enter;
			// 
			// label25
			// 
			label25.AutoSize = true;
			label25.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label25.Location = new Point(1040, 241);
			label25.Margin = new Padding(4, 0, 4, 0);
			label25.Name = "label25";
			label25.Size = new Size(28, 28);
			label25.TabIndex = 58;
			label25.Text = "%";
			label25.TextAlign = ContentAlignment.TopCenter;
			// 
			// label26
			// 
			label26.AutoSize = true;
			label26.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label26.Location = new Point(902, 241);
			label26.Margin = new Padding(4, 0, 4, 0);
			label26.Name = "label26";
			label26.Size = new Size(75, 28);
			label26.TabIndex = 57;
			label26.Text = "Year 10";
			label26.TextAlign = ContentAlignment.TopCenter;
			// 
			// y10
			// 
			y10.BackColor = SystemColors.ActiveCaptionText;
			y10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			y10.ForeColor = SystemColors.Menu;
			y10.Location = new Point(984, 240);
			y10.Margin = new Padding(4);
			y10.MaxLength = 2;
			y10.Multiline = true;
			y10.Name = "y10";
			y10.Size = new Size(53, 34);
			y10.TabIndex = 56;
			y10.Text = "0";
			y10.Enter += y10_Enter;
			// 
			// label27
			// 
			label27.AutoSize = true;
			label27.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label27.Location = new Point(1040, 200);
			label27.Margin = new Padding(4, 0, 4, 0);
			label27.Name = "label27";
			label27.Size = new Size(28, 28);
			label27.TabIndex = 55;
			label27.Text = "%";
			label27.TextAlign = ContentAlignment.TopCenter;
			// 
			// label28
			// 
			label28.AutoSize = true;
			label28.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label28.Location = new Point(912, 200);
			label28.Margin = new Padding(4, 0, 4, 0);
			label28.Name = "label28";
			label28.Size = new Size(64, 28);
			label28.TabIndex = 54;
			label28.Text = "Year 9";
			label28.TextAlign = ContentAlignment.TopCenter;
			// 
			// y9
			// 
			y9.BackColor = SystemColors.ActiveCaptionText;
			y9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			y9.ForeColor = SystemColors.Menu;
			y9.Location = new Point(984, 198);
			y9.Margin = new Padding(4);
			y9.MaxLength = 2;
			y9.Multiline = true;
			y9.Name = "y9";
			y9.Size = new Size(53, 34);
			y9.TabIndex = 53;
			y9.Text = "0";
			y9.Enter += y9_Enter;
			// 
			// label29
			// 
			label29.AutoSize = true;
			label29.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label29.Location = new Point(1040, 158);
			label29.Margin = new Padding(4, 0, 4, 0);
			label29.Name = "label29";
			label29.Size = new Size(28, 28);
			label29.TabIndex = 52;
			label29.Text = "%";
			label29.TextAlign = ContentAlignment.TopCenter;
			// 
			// label30
			// 
			label30.AutoSize = true;
			label30.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label30.Location = new Point(912, 158);
			label30.Margin = new Padding(4, 0, 4, 0);
			label30.Name = "label30";
			label30.Size = new Size(64, 28);
			label30.TabIndex = 51;
			label30.Text = "Year 8";
			label30.TextAlign = ContentAlignment.TopCenter;
			// 
			// y8
			// 
			y8.BackColor = SystemColors.ActiveCaptionText;
			y8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			y8.ForeColor = SystemColors.Menu;
			y8.Location = new Point(984, 157);
			y8.Margin = new Padding(4);
			y8.MaxLength = 2;
			y8.Multiline = true;
			y8.Name = "y8";
			y8.Size = new Size(53, 34);
			y8.TabIndex = 50;
			y8.Text = "0";
			y8.Enter += y8_Enter;
			// 
			// label31
			// 
			label31.AutoSize = true;
			label31.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label31.Location = new Point(1040, 117);
			label31.Margin = new Padding(4, 0, 4, 0);
			label31.Name = "label31";
			label31.Size = new Size(28, 28);
			label31.TabIndex = 49;
			label31.Text = "%";
			label31.TextAlign = ContentAlignment.TopCenter;
			// 
			// label32
			// 
			label32.AutoSize = true;
			label32.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label32.Location = new Point(912, 117);
			label32.Margin = new Padding(4, 0, 4, 0);
			label32.Name = "label32";
			label32.Size = new Size(64, 28);
			label32.TabIndex = 48;
			label32.Text = "Year 7";
			label32.TextAlign = ContentAlignment.TopCenter;
			// 
			// y7
			// 
			y7.BackColor = SystemColors.ActiveCaptionText;
			y7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			y7.ForeColor = SystemColors.Menu;
			y7.Location = new Point(984, 116);
			y7.Margin = new Padding(4);
			y7.MaxLength = 2;
			y7.Multiline = true;
			y7.Name = "y7";
			y7.Size = new Size(53, 34);
			y7.TabIndex = 47;
			y7.Text = "0";
			y7.Enter += y7_Enter;
			// 
			// label33
			// 
			label33.AutoSize = true;
			label33.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label33.Location = new Point(1040, 75);
			label33.Margin = new Padding(4, 0, 4, 0);
			label33.Name = "label33";
			label33.Size = new Size(28, 28);
			label33.TabIndex = 46;
			label33.Text = "%";
			label33.TextAlign = ContentAlignment.TopCenter;
			// 
			// label34
			// 
			label34.AutoSize = true;
			label34.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label34.Location = new Point(912, 75);
			label34.Margin = new Padding(4, 0, 4, 0);
			label34.Name = "label34";
			label34.Size = new Size(64, 28);
			label34.TabIndex = 45;
			label34.Text = "Year 6";
			label34.TextAlign = ContentAlignment.TopCenter;
			// 
			// y6
			// 
			y6.BackColor = SystemColors.ActiveCaptionText;
			y6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			y6.ForeColor = SystemColors.Menu;
			y6.Location = new Point(984, 74);
			y6.Margin = new Padding(4);
			y6.MaxLength = 2;
			y6.Multiline = true;
			y6.Name = "y6";
			y6.Size = new Size(53, 34);
			y6.TabIndex = 44;
			y6.Text = "0";
			y6.Enter += y6_Enter;
			// 
			// label35
			// 
			label35.AutoSize = true;
			label35.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label35.Location = new Point(835, 25);
			label35.Margin = new Padding(4, 0, 4, 0);
			label35.Name = "label35";
			label35.Size = new Size(114, 28);
			label35.TabIndex = 59;
			label35.Text = "Annual APR";
			label35.TextAlign = ContentAlignment.TopCenter;
			label35.Click += label35_Click;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(877, 397);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(182, 36);
			comboBox1.TabIndex = 60;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1583, 835);
			Controls.Add(comboBox1);
			Controls.Add(label35);
			Controls.Add(label25);
			Controls.Add(label26);
			Controls.Add(y10);
			Controls.Add(label27);
			Controls.Add(label28);
			Controls.Add(y9);
			Controls.Add(label29);
			Controls.Add(label30);
			Controls.Add(y8);
			Controls.Add(label31);
			Controls.Add(label32);
			Controls.Add(y7);
			Controls.Add(label33);
			Controls.Add(label34);
			Controls.Add(y6);
			Controls.Add(label23);
			Controls.Add(label24);
			Controls.Add(y5);
			Controls.Add(label21);
			Controls.Add(label22);
			Controls.Add(y4);
			Controls.Add(label19);
			Controls.Add(label20);
			Controls.Add(y3);
			Controls.Add(label17);
			Controls.Add(label18);
			Controls.Add(y2);
			Controls.Add(label16);
			Controls.Add(label15);
			Controls.Add(y1);
			Controls.Add(label14);
			Controls.Add(label13);
			Controls.Add(label12);
			Controls.Add(label11);
			Controls.Add(totalcosts);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label7);
			Controls.Add(brewincosts);
			Controls.Add(label6);
			Controls.Add(alltrustcosts);
			Controls.Add(label3);
			Controls.Add(attivocosts);
			Controls.Add(label2);
			Controls.Add(label8);
			Controls.Add(projectedValue);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(periodicAdditions);
			Controls.Add(label1);
			Controls.Add(calculate);
			Controls.Add(startValue);
			Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "Form1";
			Text = "Compund Interest Calculator";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox startValue;
        private Button calculate;
        private Label label1;
        private Label label4;
        private TextBox periodicAdditions;
        private Label label5;
        private Label label8;
        private TextBox projectedValue;
        private Label label2;
        private Label label3;
        private TextBox attivocosts;
        private Label label6;
        private TextBox alltrustcosts;
        private Label label7;
        private TextBox brewincosts;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox totalcosts;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox y1;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox y2;
        private Label label19;
        private Label label20;
        private TextBox y3;
        private Label label21;
        private Label label22;
        private TextBox y4;
        private Label label23;
        private Label label24;
        private TextBox y5;
        private Label label25;
        private Label label26;
        private TextBox y10;
        private Label label27;
        private Label label28;
        private TextBox y9;
        private Label label29;
        private Label label30;
        private TextBox y8;
        private Label label31;
        private Label label32;
        private TextBox y7;
        private Label label33;
        private Label label34;
        private TextBox y6;
        private Label label35;
		private ComboBox comboBox1;
	}
}
