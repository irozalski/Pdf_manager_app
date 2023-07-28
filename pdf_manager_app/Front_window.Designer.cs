namespace pdf_manager_app
{
    partial class Front_window
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Front_window));
            circularPictureBox1 = new CircularPictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.Image = (Image)resources.GetObject("circularPictureBox1.Image");
            circularPictureBox1.Location = new Point(39, 17);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(167, 160);
            circularPictureBox1.TabIndex = 1;
            circularPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(circularPictureBox1);
            panel1.Location = new Point(48, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 271);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 208);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";            
            // 
            // Front_window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            Controls.Add(panel1);
            Name = "Front_window";
            Size = new Size(703, 443);
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CircularPictureBox circularPictureBox1;
        private Panel panel1;
        private Label label1;
    }
}
