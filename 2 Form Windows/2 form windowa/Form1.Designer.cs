namespace _2_form_windowa
{
    partial class frmlogin
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
            this.btnok = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpasword = new System.Windows.Forms.Label();
            this.lblacounttype = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpasword = new System.Windows.Forms.TextBox();
            this.txtacounttype = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(37, 299);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 90);
            this.btnok.TabIndex = 0;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(363, 299);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 90);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(37, 35);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(60, 13);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "User Name";
            // 
            // lblpasword
            // 
            this.lblpasword.AutoSize = true;
            this.lblpasword.Location = new System.Drawing.Point(34, 103);
            this.lblpasword.Name = "lblpasword";
            this.lblpasword.Size = new System.Drawing.Size(48, 13);
            this.lblpasword.TabIndex = 3;
            this.lblpasword.Text = "Pasword";
            // 
            // lblacounttype
            // 
            this.lblacounttype.AutoSize = true;
            this.lblacounttype.Location = new System.Drawing.Point(34, 165);
            this.lblacounttype.Name = "lblacounttype";
            this.lblacounttype.Size = new System.Drawing.Size(68, 13);
            this.lblacounttype.TabIndex = 4;
            this.lblacounttype.Text = "Acount Type";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(338, 35);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 5;
            // 
            // txtpasword
            // 
            this.txtpasword.Location = new System.Drawing.Point(338, 96);
            this.txtpasword.Name = "txtpasword";
            this.txtpasword.Size = new System.Drawing.Size(100, 20);
            this.txtpasword.TabIndex = 6;
            // 
            // txtacounttype
            // 
            this.txtacounttype.Location = new System.Drawing.Point(338, 158);
            this.txtacounttype.Name = "txtacounttype";
            this.txtacounttype.Size = new System.Drawing.Size(100, 20);
            this.txtacounttype.TabIndex = 7;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 412);
            this.Controls.Add(this.txtacounttype);
            this.Controls.Add(this.txtpasword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblacounttype);
            this.Controls.Add(this.lblpasword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnok);
            this.Name = "frmlogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpasword;
        private System.Windows.Forms.Label lblacounttype;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpasword;
        private System.Windows.Forms.TextBox txtacounttype;
    }
}

