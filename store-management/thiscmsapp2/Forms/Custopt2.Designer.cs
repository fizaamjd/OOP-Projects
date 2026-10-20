
namespace thiscmsapp2.Forms
{
    partial class Custopt2
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
            this.back = new System.Windows.Forms.Button();
            this.dataGridList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opt9panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).BeginInit();
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
            this.opt9panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.opt9panel.Controls.Add(this.back, 2, 3);
            this.opt9panel.Controls.Add(this.dataGridList, 1, 1);
            this.opt9panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opt9panel.Location = new System.Drawing.Point(0, 0);
            this.opt9panel.Name = "opt9panel";
            this.opt9panel.RowCount = 5;
            this.opt9panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.526806F));
            this.opt9panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.47319F));
            this.opt9panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.opt9panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.opt9panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.opt9panel.Size = new System.Drawing.Size(1278, 509);
            this.opt9panel.TabIndex = 1;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(1075, 288);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(127, 52);
            this.back.TabIndex = 16;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridList
            // 
            this.dataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Type,
            this.Wear,
            this.ProductName,
            this.AddedQuantity,
            this.Price});
            this.dataGridList.Location = new System.Drawing.Point(50, 20);
            this.dataGridList.Name = "dataGridList";
            this.dataGridList.Size = new System.Drawing.Size(862, 237);
            this.dataGridList.TabIndex = 18;
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
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // AddedQuantity
            // 
            this.AddedQuantity.HeaderText = "AddedQuantity";
            this.AddedQuantity.Name = "AddedQuantity";
            this.AddedQuantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Custopt2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1278, 509);
            this.Controls.Add(this.opt9panel);
            this.Name = "Custopt2";
            this.Text = "Custopt2";
            this.Load += new System.EventHandler(this.Custopt2_Load);
            this.opt9panel.ResumeLayout(false);
            this.opt9panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel opt9panel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}