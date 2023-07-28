namespace pdf_manager_app
{
    partial class Create_catalog
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
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            panel1 = new Panel();
            button1 = new Button();
            txt_description = new TextBox();
            txt_album_name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(txt_album_name);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(742, 364);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Catalog";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(430, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(197, 19);
            listBox1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(444, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 149);
            panel1.TabIndex = 1;
            panel1.DragDrop += panel1_DragDrop;
            panel1.DragEnter += panel1_DragEnter;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(180, 289);
            button1.Name = "button1";
            button1.Size = new Size(145, 23);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(128, 69);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(197, 23);
            txt_description.TabIndex = 9;
            txt_description.Enter += txt_description_Enter;
            txt_description.Leave += txt_description_Leave;
            // 
            // txt_album_name
            // 
            txt_album_name.Location = new Point(128, 24);
            txt_album_name.Name = "txt_album_name";
            txt_album_name.Size = new Size(197, 23);
            txt_album_name.TabIndex = 5;
            txt_album_name.Enter += txt_album_name_Enter;
            txt_album_name.Leave += txt_album_name_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 72);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 4;
            label5.Text = "description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 32);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Image";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Catalog Name";
            // 
            // Create_catalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            Controls.Add(groupBox1);
            Name = "Create_catalog";
            Size = new Size(827, 456);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
        private TextBox txt_description;
        private TextBox txt_album_name;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private ListBox listBox1;
    }
}
