
namespace SimCardApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addSIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleSIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upgradedSIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateSIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 384);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSIMToolStripMenuItem,
            this.validateSIMToolStripMenuItem,
            this.balanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addSIMToolStripMenuItem
            // 
            this.addSIMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleSIMToolStripMenuItem,
            this.upgradedSIMToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.addSIMToolStripMenuItem.Name = "addSIMToolStripMenuItem";
            this.addSIMToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.addSIMToolStripMenuItem.Text = "Add SIM";
            // 
            // simpleSIMToolStripMenuItem
            // 
            this.simpleSIMToolStripMenuItem.Name = "simpleSIMToolStripMenuItem";
            this.simpleSIMToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.simpleSIMToolStripMenuItem.Text = "Simple SIM";
            this.simpleSIMToolStripMenuItem.Click += new System.EventHandler(this.simpleSIMToolStripMenuItem_Click);
            // 
            // upgradedSIMToolStripMenuItem
            // 
            this.upgradedSIMToolStripMenuItem.Name = "upgradedSIMToolStripMenuItem";
            this.upgradedSIMToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.upgradedSIMToolStripMenuItem.Text = "Upgraded SIM";
            this.upgradedSIMToolStripMenuItem.Click += new System.EventHandler(this.upgradedSIMToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // validateSIMToolStripMenuItem
            // 
            this.validateSIMToolStripMenuItem.Name = "validateSIMToolStripMenuItem";
            this.validateSIMToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.validateSIMToolStripMenuItem.Text = "Validate SIM";
            this.validateSIMToolStripMenuItem.Click += new System.EventHandler(this.validateSIMToolStripMenuItem_Click);
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.balanceToolStripMenuItem.Text = "Balance";
            this.balanceToolStripMenuItem.Click += new System.EventHandler(this.balanceToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIM cards";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addSIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleSIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upgradedSIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateSIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
    }
}

