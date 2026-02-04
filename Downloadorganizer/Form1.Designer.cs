namespace Downloadorganizer
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
            orgnaise = new Button();
            label1 = new Label();
            txtPath = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // orgnaise
            // 
            orgnaise.BackColor = SystemColors.ActiveCaptionText;
            orgnaise.Cursor = Cursors.Hand;
            orgnaise.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            orgnaise.ForeColor = SystemColors.ButtonHighlight;
            orgnaise.Location = new Point(214, 266);
            orgnaise.Name = "orgnaise";
            orgnaise.Size = new Size(350, 114);
            orgnaise.TabIndex = 0;
            orgnaise.Text = "Orgnaise";
            orgnaise.UseVisualStyleBackColor = false;
            orgnaise.Click += orgnaise_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(758, 54);
            label1.TabIndex = 1;
            label1.Text = "Choose folder path you want to orgnaise ";
            // 
            // txtPath
            // 
            txtPath.Cursor = Cursors.IBeam;
            txtPath.Font = new Font("Segoe UI", 18F);
            txtPath.Location = new Point(145, 144);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(639, 47);
            txtPath.TabIndex = 2;
            txtPath.Text = "click on Orgnaize to choose\r\n\r\n";
            txtPath.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 22F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(26, 143);
            label2.Name = "label2";
            label2.Size = new Size(113, 50);
            label2.TabIndex = 3;
            label2.Text = "Path :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtPath);
            Controls.Add(label1);
            Controls.Add(orgnaise);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orgnaizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button orgnaise;
        private Label label1;
        private TextBox txtPath;
        private Label label2;
    }
}
