namespace projectbp
{
    partial class stock_view
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTxt_search = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripbtn_search = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceHighLowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceLowHighToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 462);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTxt_search,
            this.toolStripbtn_search});
            this.toolStrip1.Location = new System.Drawing.Point(126, 19);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(137, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTxt_search
            // 
            this.toolStripTxt_search.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripTxt_search.Name = "toolStripTxt_search";
            this.toolStripTxt_search.Size = new System.Drawing.Size(100, 25);
            this.toolStripTxt_search.Text = "search Item NO";
            this.toolStripTxt_search.Leave += new System.EventHandler(this.toolStripTextBox1_Leave);
            this.toolStripTxt_search.Click += new System.EventHandler(this.toolStripTxt_search_Click);
            // 
            // toolStripbtn_search
            // 
            this.toolStripbtn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripbtn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtn_search.Image = global::projectbp.Properties.Resources.search_icon_png_31;
            this.toolStripbtn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtn_search.Name = "toolStripbtn_search";
            this.toolStripbtn_search.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtn_search.Text = "toolStripButton1";
            this.toolStripbtn_search.Click += new System.EventHandler(this.toolStripbtn_search_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(12, 20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(87, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceHighLowToolStripMenuItem,
            this.priceLowHighToolStripMenuItem,
            this.sortByNameToolStripMenuItem});
            this.sortToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.sortToolStripMenuItem.Text = "Sort by:";
            // 
            // priceHighLowToolStripMenuItem
            // 
            this.priceHighLowToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.priceHighLowToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.priceHighLowToolStripMenuItem.Name = "priceHighLowToolStripMenuItem";
            this.priceHighLowToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.priceHighLowToolStripMenuItem.Text = "Price high - low";
            this.priceHighLowToolStripMenuItem.Click += new System.EventHandler(this.priceHighLowToolStripMenuItem_Click);
            // 
            // priceLowHighToolStripMenuItem
            // 
            this.priceLowHighToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.priceLowHighToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.priceLowHighToolStripMenuItem.Name = "priceLowHighToolStripMenuItem";
            this.priceLowHighToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.priceLowHighToolStripMenuItem.Text = "Price low - high";
            this.priceLowHighToolStripMenuItem.Click += new System.EventHandler(this.priceLowHighToolStripMenuItem_Click);
            // 
            // sortByNameToolStripMenuItem
            // 
            this.sortByNameToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sortByNameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.sortByNameToolStripMenuItem.Name = "sortByNameToolStripMenuItem";
            this.sortByNameToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.sortByNameToolStripMenuItem.Text = "Sort by Name";
            this.sortByNameToolStripMenuItem.Click += new System.EventHandler(this.sortByNameToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 98);
            this.panel1.TabIndex = 4;
            // 
            // stock_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(741, 578);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "stock_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stock_view";
            this.Load += new System.EventHandler(this.stock_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTxt_search;
        private System.Windows.Forms.ToolStripButton toolStripbtn_search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceHighLowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceLowHighToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByNameToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}