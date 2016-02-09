﻿namespace NppGit.Forms
{
    partial class SnippetsManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnippetsManagerForm));
            this.contextMenuSnippets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSnippets = new System.Windows.Forms.ListBox();
            this.contextMenuSnippets.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuSnippets
            // 
            this.contextMenuSnippets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miInsert,
            this.toolStripMenuItem1,
            this.miAdd,
            this.miEdit,
            this.miDelete});
            this.contextMenuSnippets.Name = "contextMenuSnippets";
            this.contextMenuSnippets.Size = new System.Drawing.Size(108, 98);
            this.contextMenuSnippets.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuSnippets_Opening);
            // 
            // miInsert
            // 
            this.miInsert.Image = ((System.Drawing.Image)(resources.GetObject("miInsert.Image")));
            this.miInsert.Name = "miInsert";
            this.miInsert.Size = new System.Drawing.Size(107, 22);
            this.miInsert.Text = "Insert";
            this.miInsert.Click += new System.EventHandler(this.miInsert_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 6);
            // 
            // miAdd
            // 
            this.miAdd.Image = ((System.Drawing.Image)(resources.GetObject("miAdd.Image")));
            this.miAdd.Name = "miAdd";
            this.miAdd.Size = new System.Drawing.Size(107, 22);
            this.miAdd.Text = "Add";
            this.miAdd.Click += new System.EventHandler(this.miAdd_Click);
            // 
            // miEdit
            // 
            this.miEdit.Image = ((System.Drawing.Image)(resources.GetObject("miEdit.Image")));
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(107, 22);
            this.miEdit.Text = "Edit";
            this.miEdit.Click += new System.EventHandler(this.miEdit_Click);
            // 
            // miDelete
            // 
            this.miDelete.Image = ((System.Drawing.Image)(resources.GetObject("miDelete.Image")));
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(107, 22);
            this.miDelete.Text = "Delete";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // lbSnippets
            // 
            this.lbSnippets.ContextMenuStrip = this.contextMenuSnippets;
            this.lbSnippets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSnippets.FormattingEnabled = true;
            this.lbSnippets.Location = new System.Drawing.Point(0, 0);
            this.lbSnippets.Name = "lbSnippets";
            this.lbSnippets.Size = new System.Drawing.Size(405, 373);
            this.lbSnippets.TabIndex = 1;
            this.lbSnippets.DoubleClick += new System.EventHandler(this.lbSnippets_DoubleClick);
            // 
            // SnippetsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 373);
            this.Controls.Add(this.lbSnippets);
            this.Name = "SnippetsManagerForm";
            this.Text = "SnippetsManagerForm";
            this.VisibleChanged += new System.EventHandler(this.SnippetsManagerForm_VisibleChanged);
            this.contextMenuSnippets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuSnippets;
        private System.Windows.Forms.ToolStripMenuItem miInsert;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.ListBox lbSnippets;
    }
}