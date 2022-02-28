namespace HDR_WORLD_ADMIN.Forms
{
	partial class frmLogin
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsr = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnLogin.Location = new System.Drawing.Point(118, 194);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(388, 32);
			this.btnLogin.TabIndex = 11;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtPwd
			// 
			this.txtPwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtPwd.Location = new System.Drawing.Point(118, 151);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(388, 29);
			this.txtPwd.TabIndex = 1;
			this.txtPwd.Tag = "Please enter password!";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(60, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 21);
			this.label3.TabIndex = 9;
			this.label3.Text = "Pass";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(167, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(246, 45);
			this.label2.TabIndex = 8;
			this.label2.Text = "Login to system";
			// 
			// txtUsr
			// 
			this.txtUsr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtUsr.Location = new System.Drawing.Point(118, 105);
			this.txtUsr.Name = "txtUsr";
			this.txtUsr.Size = new System.Drawing.Size(388, 29);
			this.txtUsr.TabIndex = 0;
			this.txtUsr.Tag = "Please enter user!";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(60, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 21);
			this.label1.TabIndex = 6;
			this.label1.Text = "User";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 254);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUsr);
			this.Controls.Add(this.label1);
			this.Name = "frmLogin";
			this.Text = "frmLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnLogin;
		private TextBox txtPwd;
		private Label label3;
		private Label label2;
		private TextBox txtUsr;
		private Label label1;
	}
}