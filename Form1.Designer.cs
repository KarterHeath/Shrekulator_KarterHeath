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
            IblTitle = new Label();
            SuspendLayout();
            // 
            // IblTitle
            // 
            IblTitle.AutoSize = true;
            IblTitle.BackColor = Color.Transparent;
            IblTitle.Font = new Font("Sans Serif Collection", 20.0999985F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            IblTitle.Location = new Point(157, -25);
            IblTitle.Name = "IblTitle";
            IblTitle.Size = new Size(507, 228);
            IblTitle.TabIndex = 0;
            IblTitle.Text = "Shrekculator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 1464);
            Controls.Add(IblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IblTitle;
    }
}
