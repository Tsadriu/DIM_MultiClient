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
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            toolStripTextBox1 = new ToolStripTextBox();
            dimMenuStrip = new MenuStrip();
            reloadPageMenuItem = new ToolStripMenuItem();
            hideToolbarMenuItem = new ToolStripMenuItem();
            closeClientToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            dimMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.DarkGray;
            webView.Location = new Point(-1, 0);
            webView.Name = "webView";
            webView.Size = new Size(1266, 682);
            webView.TabIndex = 1;
            webView.ZoomFactor = 1D;
            webView.KeyDown += webView_KeyDown;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Overflow = ToolStripItemOverflow.Always;
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Text = "(Press F11 to hide/show)";
            // 
            // dimMenuStrip
            // 
            dimMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, reloadPageMenuItem, closeClientToolStripMenuItem, hideToolbarMenuItem });
            dimMenuStrip.Location = new Point(0, 0);
            dimMenuStrip.Name = "dimMenuStrip";
            dimMenuStrip.Size = new Size(1264, 24);
            dimMenuStrip.TabIndex = 2;
            dimMenuStrip.Text = "DIM Helper";
            // 
            // reloadPageMenuItem
            // 
            reloadPageMenuItem.Name = "reloadPageMenuItem";
            reloadPageMenuItem.Size = new Size(84, 20);
            reloadPageMenuItem.Text = "Reload page";
            reloadPageMenuItem.Click += reloadPageMenuItem_Click;
            // 
            // hideToolbarMenuItem
            // 
            hideToolbarMenuItem.Name = "hideToolbarMenuItem";
            hideToolbarMenuItem.Size = new Size(78, 20);
            hideToolbarMenuItem.Text = "Hide menu";
            hideToolbarMenuItem.Click += hideToolbarMenuItem_Click;
            // 
            // closeClientToolStripMenuItem
            // 
            closeClientToolStripMenuItem.Name = "closeClientToolStripMenuItem";
            closeClientToolStripMenuItem.Size = new Size(80, 20);
            closeClientToolStripMenuItem.Text = "Close client";
            closeClientToolStripMenuItem.Click += closeClientToolStripMenuItem_Click;
            // 
            // DimClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1264, 681);
            Controls.Add(dimMenuStrip);
            Controls.Add(webView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = dimMenuStrip;
            Name = "DimClient";
            Text = "DIM MultiClient - ";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            dimMenuStrip.ResumeLayout(false);
            dimMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private ToolStripTextBox toolStripTextBox1;
        private MenuStrip dimMenuStrip;
        private ToolStripMenuItem hideToolbarMenuItem;
        private ToolStripMenuItem reloadPageMenuItem;
        private ToolStripMenuItem closeClientToolStripMenuItem;
    }
}