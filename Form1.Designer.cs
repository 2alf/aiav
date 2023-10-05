namespace aiav
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(22, 22, 22);
            button1.Font = new Font("Red Hat Display", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(799, 25);
            button1.Name = "button1";
            button1.Size = new Size(168, 84);
            button1.TabIndex = 0;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(22, 22, 22);
            button2.Font = new Font("Red Hat Display", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(799, 134);
            button2.Name = "button2";
            button2.Size = new Size(168, 84);
            button2.TabIndex = 1;
            button2.Text = "Scan";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(22, 22, 22);
            button3.Font = new Font("Red Hat Display", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(799, 243);
            button3.Name = "button3";
            button3.Size = new Size(168, 84);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(64, 64, 64);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Red Hat Display", 8.999999F, FontStyle.Italic, GraphicsUnit.Point);
            listBox1.ForeColor = Color.FromArgb(0, 192, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 16;
            listBox1.Location = new Point(57, 477);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(910, 82);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(57, 446);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(910, 25);
            progressBar1.TabIndex = 4;
            progressBar1.Click += progressBar1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(22, 22, 22);
            label1.Font = new Font("Red Hat Display SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(57, 25);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 5;
            label1.Text = "Dir:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Red Hat Display SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(57, 46);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 6;
            label2.Text = "Detected:";
            label2.Click += label2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            BackgroundImage = Properties.Resources.AVBAN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(979, 571);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Red Hat Display Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "avai";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private ContextMenuStrip contextMenuStrip1;
    }
}