namespace HDR_WORLD_ADMIN.Forms
{
	partial class frmNewProduct
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewProduct));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pbimages = new System.Windows.Forms.PictureBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AddImgCMS = new System.Windows.Forms.ToolStripMenuItem();
			this.removeCMS = new System.Windows.Forms.ToolStripMenuItem();
			this.pnImages = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.pbThumnail = new System.Windows.Forms.PictureBox();
			this.chklSize = new System.Windows.Forms.CheckedListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cboCCY = new System.Windows.Forms.ComboBox();
			this.pColors = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pbimages)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.pnImages.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbThumnail)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Item Name";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(85, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(284, 23);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Item Code";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(85, 50);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(284, 23);
			this.textBox2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Item Color";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Description";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(86, 117);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(283, 206);
			this.txtDescription.TabIndex = 5;
			this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(432, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "Image";
			// 
			// pbimages
			// 
			this.pbimages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbimages.ContextMenuStrip = this.contextMenuStrip1;
			this.pbimages.Image = ((System.Drawing.Image)(resources.GetObject("pbimages.Image")));
			this.pbimages.Location = new System.Drawing.Point(3, 3);
			this.pbimages.Name = "pbimages";
			this.pbimages.Size = new System.Drawing.Size(151, 166);
			this.pbimages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbimages.TabIndex = 7;
			this.pbimages.TabStop = false;
			this.pbimages.Click += new System.EventHandler(this.pictureBox1_Click);
			this.pbimages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbimages_MouseDown);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddImgCMS,
            this.removeCMS});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
			// 
			// AddImgCMS
			// 
			this.AddImgCMS.Name = "AddImgCMS";
			this.AddImgCMS.Size = new System.Drawing.Size(153, 22);
			this.AddImgCMS.Text = "Add Image";
			this.AddImgCMS.Click += new System.EventHandler(this.AddImgCMS_Click);
			// 
			// removeCMS
			// 
			this.removeCMS.Name = "removeCMS";
			this.removeCMS.Size = new System.Drawing.Size(153, 22);
			this.removeCMS.Text = "Remove Image";
			this.removeCMS.Click += new System.EventHandler(this.removeCMS_Click);
			// 
			// pnImages
			// 
			this.pnImages.AutoScroll = true;
			this.pnImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnImages.Controls.Add(this.pbimages);
			this.pnImages.Location = new System.Drawing.Point(478, 12);
			this.pnImages.Name = "pnImages";
			this.pnImages.Size = new System.Drawing.Size(484, 302);
			this.pnImages.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 336);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 15);
			this.label6.TabIndex = 9;
			this.label6.Text = "Thumnail";
			// 
			// pbThumnail
			// 
			this.pbThumnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbThumnail.Location = new System.Drawing.Point(86, 336);
			this.pbThumnail.Name = "pbThumnail";
			this.pbThumnail.Size = new System.Drawing.Size(151, 166);
			this.pbThumnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbThumnail.TabIndex = 8;
			this.pbThumnail.TabStop = false;
			this.pbThumnail.Click += new System.EventHandler(this.pbThumnail_Click);
			// 
			// chklSize
			// 
			this.chklSize.CheckOnClick = true;
			this.chklSize.FormattingEnabled = true;
			this.chklSize.Location = new System.Drawing.Point(478, 320);
			this.chklSize.Name = "chklSize";
			this.chklSize.Size = new System.Drawing.Size(484, 112);
			this.chklSize.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(432, 327);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 15);
			this.label7.TabIndex = 11;
			this.label7.Text = "Sizes";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(420, 446);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 15);
			this.label8.TabIndex = 12;
			this.label8.Text = "Currency";
			// 
			// cboCCY
			// 
			this.cboCCY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCCY.FormattingEnabled = true;
			this.cboCCY.Location = new System.Drawing.Point(478, 442);
			this.cboCCY.Name = "cboCCY";
			this.cboCCY.Size = new System.Drawing.Size(243, 23);
			this.cboCCY.TabIndex = 13;
			// 
			// pColors
			// 
			this.pColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pColors.Location = new System.Drawing.Point(86, 78);
			this.pColors.Name = "pColors";
			this.pColors.Size = new System.Drawing.Size(283, 33);
			this.pColors.TabIndex = 14;
			// 
			// frmNewProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(974, 601);
			this.Controls.Add(this.pColors);
			this.Controls.Add(this.cboCCY);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.chklSize);
			this.Controls.Add(this.pbThumnail);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pnImages);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "frmNewProduct";
			this.Text = "New Product Creation";
			this.Load += new System.EventHandler(this.frmNewProduct_Load);
			this.Shown += new System.EventHandler(this.frmNewProduct_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pbimages)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.pnImages.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbThumnail)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private TextBox textBox2;
		private ColorDialog colorDialog1;
		private Label label3;
		private Label label4;
		private TextBox txtDescription;
		private Label label5;
		private PictureBox pbimages;
		private Panel pnImages;
		private Label label6;
		private PictureBox pbThumnail;
		private CheckedListBox chklSize;
		private Label label7;
		private Label label8;
		private ComboBox cboCCY;
		private Panel pColors;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem addImageToolStripMenuItem;
		private ToolStripMenuItem removeCMS;
		private ToolStripMenuItem AddImgCMS;
	}
}