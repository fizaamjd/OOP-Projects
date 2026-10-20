
namespace thiscmsapp2.Forms
{
    partial class Adminopt9
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
            this.opt9panel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retail_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Added_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Button();
            this.opt9panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // opt9panel
            // 
            this.opt9panel.AutoSize = true;
            this.opt9panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.opt9panel.ColumnCount = 4;
            this.opt9panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.404873F));
            this.opt9panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.59512F));
            this.opt9panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.opt9panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.opt9panel.Controls.Add(this.dataGridView1, 1, 1);
            this.opt9panel.Controls.Add(this.back, 2, 3);
            this.opt9panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opt9panel.Location = new System.Drawing.Point(0, 0);
            this.opt9panel.Name = "opt9panel";
            this.opt9panel.RowCount = 5;
            this.opt9panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.526806F));
            this.opt9panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.47319F));
            this.opt9panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.opt9panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.opt9panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.opt9panel.Size = new System.Drawing.Size(1278, 486);
            this.opt9panel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Type,
            this.Wear,
            this.Product_Name,
            this.Quantity,
            this.Retail_Price,
            this.Cost_Price,
            this.Added_Date,
            this.Profit});
            this.dataGridView1.Location = new System.Drawing.Point(50, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Wear
            // 
            this.Wear.HeaderText = "Wear";
            this.Wear.Name = "Wear";
            this.Wear.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product_Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Retail_Price
            // 
            this.Retail_Price.HeaderText = "Retail_Price";
            this.Retail_Price.Name = "Retail_Price";
            this.Retail_Price.ReadOnly = true;
            // 
            // Cost_Price
            // 
            this.Cost_Price.HeaderText = "Cost_Price";
            this.Cost_Price.Name = "Cost_Price";
            this.Cost_Price.ReadOnly = true;
            // 
            // Added_Date
            // 
            this.Added_Date.HeaderText = "Added_Date";
            this.Added_Date.Name = "Added_Date";
            this.Added_Date.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(1076, 360);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(127, 34);
            this.back.TabIndex = 16;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Adminopt9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1278, 486);
            this.Controls.Add(this.opt9panel);
            this.Name = "Adminopt9";
            this.Text = "Adminopt9";
            this.Load += new System.EventHandler(this.Adminopt9_Load);
            this.opt9panel.ResumeLayout(false);
            this.opt9panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel opt9panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retail_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Added_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.Button back;
    }
}