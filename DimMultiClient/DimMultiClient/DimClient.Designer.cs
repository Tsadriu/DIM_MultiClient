using Microsoft.Web.WebView2.Core;
using TsadriuUtilities;

namespace DimMultiClient
{
    partial class DimClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DimClient));
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.dimMenuStrip = new System.Windows.Forms.MenuStrip();
            this.reloadPageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolbarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.dimMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = false;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.DarkGray;
            this.webView.Location = new System.Drawing.Point(-1, 0);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1266, 682);
            this.webView.TabIndex = 1;
            this.webView.ZoomFactor = 1D;
            this.webView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.webView_KeyDown);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "(Press F11 to hide/show)";
            // 
            // dimMenuStrip
            // 
            this.dimMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.reloadPageMenuItem,
            this.hideToolbarMenuItem});
            this.dimMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.dimMenuStrip.Name = "dimMenuStrip";
            this.dimMenuStrip.Size = new System.Drawing.Size(1264, 24);
            this.dimMenuStrip.TabIndex = 2;
            this.dimMenuStrip.Text = "DIM Helper";
            // 
            // reloadPageMenuItem
            // 
            this.reloadPageMenuItem.Name = "reloadPageMenuItem";
            this.reloadPageMenuItem.Size = new System.Drawing.Size(84, 20);
            this.reloadPageMenuItem.Text = "Reload page";
            this.reloadPageMenuItem.Click += new System.EventHandler(this.reloadPageMenuItem_Click);
            // 
            // hideToolbarMenuItem
            // 
            this.hideToolbarMenuItem.Name = "hideToolbarMenuItem";
            this.hideToolbarMenuItem.Size = new System.Drawing.Size(78, 20);
            this.hideToolbarMenuItem.Text = "Hide menu";
            this.hideToolbarMenuItem.Click += new System.EventHandler(this.hideToolbarMenuItem_Click);
            // 
            // DimClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dimMenuStrip);
            this.Controls.Add(this.webView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.dimMenuStrip;
            this.Name = "DimClient";
            this.Text = "DIM MultiClient - ";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.dimMenuStrip.ResumeLayout(false);
            this.dimMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private ToolStripTextBox toolStripTextBox1;
        private MenuStrip dimMenuStrip;
        private ToolStripMenuItem hideToolbarMenuItem;
        private ToolStripMenuItem reloadPageMenuItem;
    }
}