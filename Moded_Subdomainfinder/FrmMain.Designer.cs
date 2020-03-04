namespace Moded_Subdomainfinder
{
    partial class FrmMain
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
            this.txt_logs = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_website = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_copyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.btn_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_execute = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_logs
            // 
            this.txt_logs.Location = new System.Drawing.Point(325, 41);
            this.txt_logs.Multiline = true;
            this.txt_logs.Name = "txt_logs";
            this.txt_logs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_logs.Size = new System.Drawing.Size(246, 199);
            this.txt_logs.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(298, 199);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Url";
            this.columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ip";
            this.columnHeader2.Width = 126;
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(78, 11);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(429, 20);
            this.txt_website.TabIndex = 5;
            this.txt_website.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Website : ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 249);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(582, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_status
            // 
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(74, 17);
            this.lbl_status.Text = "Status: None";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_copyAll,
            this.saveToToolStripMenuItem,
            this.btn_saveAs});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 54);
            // 
            // btn_copyAll
            // 
            this.btn_copyAll.Name = "btn_copyAll";
            this.btn_copyAll.Size = new System.Drawing.Size(119, 22);
            this.btn_copyAll.Text = "Copy All";
            this.btn_copyAll.Click += new System.EventHandler(this.Btn_copyAll_Click);
            // 
            // saveToToolStripMenuItem
            // 
            this.saveToToolStripMenuItem.Name = "saveToToolStripMenuItem";
            this.saveToToolStripMenuItem.Size = new System.Drawing.Size(116, 6);
            // 
            // btn_saveAs
            // 
            this.btn_saveAs.Name = "btn_saveAs";
            this.btn_saveAs.Size = new System.Drawing.Size(119, 22);
            this.btn_saveAs.Text = "Save as";
            this.btn_saveAs.Click += new System.EventHandler(this.Btn_saveAs_Click);
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(513, 9);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(58, 23);
            this.btn_execute.TabIndex = 10;
            this.btn_execute.Text = "Execute";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.Btn_execute_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 271);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txt_logs);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txt_website);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Subdomain finder";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_logs;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_copyAll;
        private System.Windows.Forms.ToolStripSeparator saveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_saveAs;
        private System.Windows.Forms.Button btn_execute;
    }
}

