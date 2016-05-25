/*
Copyright (c) 2015-2016, Schadin Alexey (schadin@gmail.com)
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted 
provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice, this list of conditions 
and the following disclaimer.

2. Redistributions in binary form must reproduce the above copyright notice, this list of conditions 
and the following disclaimer in the documentation and/or other materials provided with 
the distribution.

3. Neither the name of the copyright holder nor the names of its contributors may be used to endorse 
or promote products derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR 
IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND 
FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR 
CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL 
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, 
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER 
IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF 
THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

namespace NppKate.Forms
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
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvSnippets = new System.Windows.Forms.TreeView();
            this.contextMenuSnippets.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuSnippets
            // 
            this.contextMenuSnippets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miInsert,
            this.miAdd,
            this.miEdit,
            this.miDelete});
            this.contextMenuSnippets.Name = "contextMenuSnippets";
            this.contextMenuSnippets.Size = new System.Drawing.Size(153, 114);
            this.contextMenuSnippets.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuSnippets_Opening);
            // 
            // miInsert
            // 
            this.miInsert.Image = ((System.Drawing.Image)(resources.GetObject("miInsert.Image")));
            this.miInsert.Name = "miInsert";
            this.miInsert.Size = new System.Drawing.Size(152, 22);
            this.miInsert.Text = "Insert";
            this.miInsert.Click += new System.EventHandler(this.miInsert_Click);
            // 
            // miAdd
            // 
            this.miAdd.Image = ((System.Drawing.Image)(resources.GetObject("miAdd.Image")));
            this.miAdd.Name = "miAdd";
            this.miAdd.Size = new System.Drawing.Size(152, 22);
            this.miAdd.Text = "Add";
            this.miAdd.Click += new System.EventHandler(this.miAdd_Click);
            // 
            // miEdit
            // 
            this.miEdit.Image = ((System.Drawing.Image)(resources.GetObject("miEdit.Image")));
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(152, 22);
            this.miEdit.Text = "Edit";
            this.miEdit.Click += new System.EventHandler(this.miEdit_Click);
            // 
            // miDelete
            // 
            this.miDelete.Image = ((System.Drawing.Image)(resources.GetObject("miDelete.Image")));
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(152, 22);
            this.miDelete.Text = "Delete";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvSnippets);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 373);
            this.panel1.TabIndex = 3;
            // 
            // tvSnippets
            // 
            this.tvSnippets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSnippets.Location = new System.Drawing.Point(0, 0);
            this.tvSnippets.Name = "tvSnippets";
            this.tvSnippets.Size = new System.Drawing.Size(405, 373);
            this.tvSnippets.TabIndex = 0;
            // 
            // SnippetsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 373);
            this.Controls.Add(this.panel1);
            this.Name = "SnippetsManagerForm";
            this.Text = "SnippetsManagerForm";
            this.VisibleChanged += new System.EventHandler(this.SnippetsManagerForm_VisibleChanged);
            this.contextMenuSnippets.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuSnippets;
        private System.Windows.Forms.ToolStripMenuItem miInsert;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvSnippets;
    }
}