
namespace thiscmsapp2.Forms
{
    partial class Signinform
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
            this.signuppanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblname = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtxnamebox = new System.Windows.Forms.TextBox();
            this.txtpswbox = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.signuppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signuppanel
            // 
            this.signuppanel.AutoSize = true;
            this.signuppanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signuppanel.BackgroundImage = global::thiscmsapp2.Properties.Resources.WhatsApp_Image_2023_07_23_at_9_20_14_AM;
            this.signuppanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signuppanel.ColumnCount = 5;
            this.signuppanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.signuppanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.signuppanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.signuppanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.signuppanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 554F));
            this.signuppanel.Controls.Add(this.lblname, 1, 1);
            this.signuppanel.Controls.Add(this.lblpassword, 1, 3);
            this.signuppanel.Controls.Add(this.txtxnamebox, 3, 1);
            this.signuppanel.Controls.Add(this.txtpswbox, 3, 3);
            this.signuppanel.Controls.Add(this.lbltitle, 0, 0);
            this.signuppanel.Controls.Add(this.back, 3, 5);
            this.signuppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signuppanel.Location = new System.Drawing.Point(0, 0);
            this.signuppanel.Name = "signuppanel";
            this.signuppanel.RowCount = 7;
            this.signuppanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.signuppanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.signuppanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.signuppanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.signuppanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.signuppanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.signuppanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.signuppanel.Size = new System.Drawing.Size(1272, 508);
            this.signuppanel.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Black;
            this.lblname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblname.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(203, 170);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(231, 50);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "username";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpassword
            // 
            this.lblpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Black;
            this.lblpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblpassword.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.White;
            this.lblpassword.Location = new System.Drawing.Point(203, 230);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(231, 50);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "password";
            this.lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtxnamebox
            // 
            this.txtxnamebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtxnamebox.BackColor = System.Drawing.Color.Black;
            this.txtxnamebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtxnamebox.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxnamebox.ForeColor = System.Drawing.Color.White;
            this.txtxnamebox.Location = new System.Drawing.Point(508, 173);
            this.txtxnamebox.Name = "txtxnamebox";
            this.txtxnamebox.Size = new System.Drawing.Size(207, 32);
            this.txtxnamebox.TabIndex = 5;
            this.txtxnamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtxnamebox.UseWaitCursor = true;
            // 
            // txtpswbox
            // 
            this.txtpswbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpswbox.BackColor = System.Drawing.Color.Black;
            this.txtpswbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpswbox.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpswbox.ForeColor = System.Drawing.Color.White;
            this.txtpswbox.Location = new System.Drawing.Point(508, 233);
            this.txtpswbox.Name = "txtpswbox";
            this.txtpswbox.PasswordChar = '*';
            this.txtpswbox.Size = new System.Drawing.Size(207, 32);
            this.txtpswbox.TabIndex = 6;
            this.txtpswbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpswbox.UseSystemPasswordChar = true;
            this.txtpswbox.UseWaitCursor = true;
            this.txtpswbox.Leave += new System.EventHandler(this.txtpswbox_Leave);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltitle.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(3, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(194, 170);
            this.lbltitle.TabIndex = 8;
            this.lbltitle.Text = "Lets signin!";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back.AutoSize = true;
            this.back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(508, 293);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(207, 41);
            this.back.TabIndex = 10;
            this.back.Text = "Next";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Signinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1272, 508);
            this.Controls.Add(this.signuppanel);
            this.Name = "Signinform";
            this.Text = "Signinform";
            this.Load += new System.EventHandler(this.Signinform_Load);
            this.signuppanel.ResumeLayout(false);
            this.signuppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox txtpswbox;
        private System.Windows.Forms.TextBox txtxnamebox;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TableLayoutPanel signuppanel;
    }
}