namespace PatchApplicatoin
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
            btnCreateXML = new Button();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            openfile = new Button();
            btnEsc = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateXML
            // 
            btnCreateXML.ForeColor = Color.Black;
            btnCreateXML.Location = new Point(20, 31);
            btnCreateXML.Name = "btnCreateXML";
            btnCreateXML.Size = new Size(140, 44);
            btnCreateXML.TabIndex = 0;
            btnCreateXML.Text = "Create XML";
            btnCreateXML.UseVisualStyleBackColor = true;
            btnCreateXML.Click += btnCreateXML_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(openfile);
            groupBox1.Controls.Add(btnCreateXML);
            groupBox1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1082, 526);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "XML Patching Features";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(20, 82);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1042, 436);
            listBox1.TabIndex = 2;
            // 
            // openfile
            // 
            openfile.ForeColor = Color.Black;
            openfile.Location = new Point(918, 31);
            openfile.Name = "openfile";
            openfile.Size = new Size(144, 44);
            openfile.TabIndex = 1;
            openfile.Text = "Patch";
            openfile.UseVisualStyleBackColor = true;
            openfile.Click += openfile_Click;
            // 
            // btnEsc
            // 
            btnEsc.Location = new Point(1064, 18);
            btnEsc.Name = "btnEsc";
            btnEsc.Size = new Size(30, 23);
            btnEsc.TabIndex = 2;
            btnEsc.Text = "X";
            btnEsc.UseVisualStyleBackColor = true;
            btnEsc.Click += btnEsc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1106, 582);
            Controls.Add(btnEsc);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Patcher";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateXML;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button openfile;
        private Button btnEsc;
    }
}
