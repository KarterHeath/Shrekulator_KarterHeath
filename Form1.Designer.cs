namespace Calculator_KarterHeath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCalculate = new Button();
            lblTitle = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            cmbOperator = new ComboBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackgroundImage = Properties.Resources.Donkay;
            btnCalculate.Font = new Font("Times New Roman", 26.1F);
            btnCalculate.Location = new Point(187, 1206);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(649, 197);
            btnCalculate.TabIndex = 15;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 20F);
            lblTitle.Location = new Point(317, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(344, 76);
            lblTitle.TabIndex = 18;
            lblTitle.Text = "Shrekulator";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(90, 430);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(249, 47);
            txtNumber1.TabIndex = 19;
            txtNumber1.Tag = "";
            txtNumber1.Text = "(empty)";
            txtNumber1.TextChanged += textBox1_TextChanged;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(636, 432);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(250, 47);
            txtNumber2.TabIndex = 20;
            txtNumber2.Tag = "";
            txtNumber2.Text = "(empty)";
            // 
            // cmbOperator
            // 
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperator.Location = new Point(390, 430);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(166, 49);
            cmbOperator.TabIndex = 21;
            cmbOperator.Text = "(empty)";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Times New Roman", 20F);
            lblResult.Image = Properties.Resources.cute_boots_removebg_preview;
            lblResult.Location = new Point(212, 218);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(221, 76);
            lblResult.TabIndex = 22;
            lblResult.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 211, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 1403);
            Controls.Add(lblResult);
            Controls.Add(cmbOperator);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(lblTitle);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button btnCalculate;
        private Button button16;
        private Label lblResult;
        private Label lblTitle;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private ComboBox cmbOperator;
        private Button Decimal;
    }
}
