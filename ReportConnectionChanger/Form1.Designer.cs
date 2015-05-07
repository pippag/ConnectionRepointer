namespace ReportConnectionChanger
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.folderDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newConnString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.origConn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.connName = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.origInitCat = new System.Windows.Forms.TextBox();
            this.newInitCat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Repointer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // folderDir
            // 
            this.folderDir.Location = new System.Drawing.Point(169, 42);
            this.folderDir.Name = "folderDir";
            this.folderDir.Size = new System.Drawing.Size(267, 20);
            this.folderDir.TabIndex = 1;
            this.folderDir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder Directory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Data Source";
            // 
            // newConnString
            // 
            this.newConnString.Location = new System.Drawing.Point(169, 135);
            this.newConnString.Name = "newConnString";
            this.newConnString.Size = new System.Drawing.Size(267, 20);
            this.newConnString.TabIndex = 4;
            this.newConnString.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Original Data Source";
            // 
            // origConn
            // 
            this.origConn.Location = new System.Drawing.Point(169, 102);
            this.origConn.Name = "origConn";
            this.origConn.Size = new System.Drawing.Size(267, 20);
            this.origConn.TabIndex = 6;
            this.origConn.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Connection Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // connName
            // 
            this.connName.Location = new System.Drawing.Point(169, 70);
            this.connName.Name = "connName";
            this.connName.Size = new System.Drawing.Size(267, 20);
            this.connName.TabIndex = 8;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Original Initial Catalog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "New Initial Catalog";
            // 
            // origInitCat
            // 
            this.origInitCat.Location = new System.Drawing.Point(169, 172);
            this.origInitCat.Name = "origInitCat";
            this.origInitCat.Size = new System.Drawing.Size(267, 20);
            this.origInitCat.TabIndex = 11;
            // 
            // newInitCat
            // 
            this.newInitCat.Location = new System.Drawing.Point(169, 209);
            this.newInitCat.Name = "newInitCat";
            this.newInitCat.Size = new System.Drawing.Size(267, 20);
            this.newInitCat.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 299);
            this.Controls.Add(this.newInitCat);
            this.Controls.Add(this.origInitCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.connName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.origConn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newConnString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderDir);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Connection Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox folderDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newConnString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox origConn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox connName;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox origInitCat;
        private System.Windows.Forms.TextBox newInitCat;
    }
}

