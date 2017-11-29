namespace projectbp
{
    partial class add_new_emp
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
            this.txteno = new System.Windows.Forms.TextBox();
            this.txtename = new System.Windows.Forms.TextBox();
            this.txteadd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ane_insert = new System.Windows.Forms.Button();
            this.btn_ane_update = new System.Windows.Forms.Button();
            this.btn_ane_claer = new System.Windows.Forms.Button();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.mtxt_pno = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txteno
            // 
            this.txteno.Location = new System.Drawing.Point(184, 38);
            this.txteno.Name = "txteno";
            this.txteno.Size = new System.Drawing.Size(237, 20);
            this.txteno.TabIndex = 0;
            // 
            // txtename
            // 
            this.txtename.Location = new System.Drawing.Point(184, 102);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(237, 20);
            this.txtename.TabIndex = 2;
            // 
            // txteadd
            // 
            this.txteadd.Location = new System.Drawing.Point(184, 159);
            this.txteadd.Name = "txteadd";
            this.txteadd.Size = new System.Drawing.Size(237, 20);
            this.txteadd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employee Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employee PhoneNO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date Of Birth:";
            // 
            // btn_ane_insert
            // 
            this.btn_ane_insert.Location = new System.Drawing.Point(339, 348);
            this.btn_ane_insert.Name = "btn_ane_insert";
            this.btn_ane_insert.Size = new System.Drawing.Size(82, 40);
            this.btn_ane_insert.TabIndex = 10;
            this.btn_ane_insert.Text = "INSERT";
            this.btn_ane_insert.UseVisualStyleBackColor = true;
            this.btn_ane_insert.Click += new System.EventHandler(this.btn_ane_insert_Click);
            // 
            // btn_ane_update
            // 
            this.btn_ane_update.Location = new System.Drawing.Point(236, 348);
            this.btn_ane_update.Name = "btn_ane_update";
            this.btn_ane_update.Size = new System.Drawing.Size(75, 40);
            this.btn_ane_update.TabIndex = 11;
            this.btn_ane_update.Text = "UPDATE";
            this.btn_ane_update.UseVisualStyleBackColor = true;
            this.btn_ane_update.Click += new System.EventHandler(this.btn_ane_update_Click);
            // 
            // btn_ane_claer
            // 
            this.btn_ane_claer.Location = new System.Drawing.Point(125, 348);
            this.btn_ane_claer.Name = "btn_ane_claer";
            this.btn_ane_claer.Size = new System.Drawing.Size(75, 40);
            this.btn_ane_claer.TabIndex = 12;
            this.btn_ane_claer.Text = "CLEAR";
            this.btn_ane_claer.UseVisualStyleBackColor = true;
            this.btn_ane_claer.Click += new System.EventHandler(this.btn_ane_claer_Click);
            // 
            // dtp_dob
            // 
            this.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dob.Location = new System.Drawing.Point(184, 282);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(237, 20);
            this.dtp_dob.TabIndex = 13;
            // 
            // mtxt_pno
            // 
            this.mtxt_pno.Location = new System.Drawing.Point(184, 217);
            this.mtxt_pno.Mask = "9990000000";
            this.mtxt_pno.Name = "mtxt_pno";
            this.mtxt_pno.Size = new System.Drawing.Size(237, 20);
            this.mtxt_pno.TabIndex = 14;
            this.mtxt_pno.Text = "0";
            // 
            // add_new_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 424);
            this.Controls.Add(this.mtxt_pno);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.btn_ane_claer);
            this.Controls.Add(this.btn_ane_update);
            this.Controls.Add(this.btn_ane_insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txteadd);
            this.Controls.Add(this.txtename);
            this.Controls.Add(this.txteno);
            this.Name = "add_new_emp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_new_emp";
            this.Load += new System.EventHandler(this.add_new_emp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txteno;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.TextBox txteadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btn_ane_insert;
        public System.Windows.Forms.Button btn_ane_update;
        public System.Windows.Forms.Button btn_ane_claer;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.MaskedTextBox mtxt_pno;
    }
}