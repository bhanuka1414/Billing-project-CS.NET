namespace projectbp
{
    partial class new_user
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblprivrlege = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtprivilege = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(135, 43);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(286, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(134, 91);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(286, 24);
            this.txtpass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Type";
            // 
            // lblprivrlege
            // 
            this.lblprivrlege.AutoSize = true;
            this.lblprivrlege.ForeColor = System.Drawing.Color.Maroon;
            this.lblprivrlege.Location = new System.Drawing.Point(135, 166);
            this.lblprivrlege.Name = "lblprivrlege";
            this.lblprivrlege.Size = new System.Drawing.Size(98, 13);
            this.lblprivrlege.TabIndex = 6;
            this.lblprivrlege.Text = "Admin =1 ,   user=2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(245, 213);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 45);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtprivilege
            // 
            this.txtprivilege.Location = new System.Drawing.Point(134, 143);
            this.txtprivilege.Mask = "0";
            this.txtprivilege.Name = "txtprivilege";
            this.txtprivilege.Size = new System.Drawing.Size(286, 20);
            this.txtprivilege.TabIndex = 9;
            this.txtprivilege.MouseLeave += new System.EventHandler(this.txtprivilege_MouseLeave);
            this.txtprivilege.MouseHover += new System.EventHandler(this.txtprivilege_MouseHover);
            // 
            // new_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 270);
            this.Controls.Add(this.txtprivilege);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblprivrlege);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusername);
            this.Name = "new_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "new_user";
            this.Load += new System.EventHandler(this.new_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblprivrlege;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.MaskedTextBox txtprivilege;
    }
}