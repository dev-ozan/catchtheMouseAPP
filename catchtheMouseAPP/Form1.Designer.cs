namespace catchtheMouseAPP
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
            btnTikla = new Button();
            SuspendLayout();
            // 
            // btnTikla
            // 
            btnTikla.Location = new Point(254, 179);
            btnTikla.Name = "btnTikla";
            btnTikla.Size = new Size(179, 80);
            btnTikla.TabIndex = 0;
            btnTikla.Text = "Tikla";
            btnTikla.UseVisualStyleBackColor = true;
            btnTikla.MouseClick += btnTikla_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTikla);
            Name = "Form1";
            Text = "catchTheMouse";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTikla;
    }
}