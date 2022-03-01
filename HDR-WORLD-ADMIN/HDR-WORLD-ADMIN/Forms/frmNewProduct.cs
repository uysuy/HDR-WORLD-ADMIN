using HDR_WORLD_ADMIN.Helpers;
using HDR_WORLD_ADMIN.Models;
using Newtonsoft.Json;

namespace HDR_WORLD_ADMIN.Forms
{
	public partial class frmNewProduct : Form
	{
		List<Panel> ColorPanels;
		List<PictureBox> Images;
		PictureBox currentPB;
		public frmNewProduct()
		{
			InitializeComponent();
			ColorPanels = new List<Panel>();
			Images = new List<PictureBox>();
		}

		private void frmNewProduct_Load(object sender, EventArgs e)
		{
			//create colors
			var cp = new Panel
			{
				Size = new Size(21, 21)
				,Location = new Point(3, 5)
				,BackColor = Color.Maroon
			};
			cp.Click += Cp_Click;
			ColorPanels.Add(cp);
			Images.Add(pbimages);
			pColors.Controls.Add(cp);
			pColors.Invalidate();
		}

		private void Cp_Click(object? sender, EventArgs e)
		{
			var mouseEvent = e as MouseEventArgs;
			colorDialog1.ShowDialog();
			if (ColorPanels.Where(x => x.BackColor == colorDialog1.Color).Count() > 0)
				return;
			if (mouseEvent != null)
				if(mouseEvent.Button == MouseButtons.Left)
				{
					((sender as Panel)).BackColor = colorDialog1.Color;
				}
				else
				{
					var lastPn = ColorPanels.LastOrDefault();
					var cp = new Panel
					{
						Size = new Size(21, 21)
						,Location = new Point(lastPn.Location.X+25, 5)//increase 25 to X
						,BackColor = colorDialog1.Color
					};
					cp.Click += Cp_Click;
					ColorPanels.Add(cp);

					pColors.Controls.Add(cp);
					pColors.Invalidate();
				}
		}

		private void pbThumnail_Click(object sender, EventArgs e)
		{
			var mouseEvent = e as MouseEventArgs;
			if(mouseEvent?.Button == MouseButtons.Right)
			{
				var fd = new OpenFileDialog
				{
					Multiselect = false,
					Filter = "Images|*.png;*.jpg"
				};
				if(fd.ShowDialog() == DialogResult.OK)
				{
					pbThumnail.Image = Image.FromFile(fd.FileName);
				}
			}
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			currentPB = sender as PictureBox;
			var mouseEvent = e as MouseEventArgs;
			if(mouseEvent != null)
				if(mouseEvent.Button == MouseButtons.Left)
				{
					var fd = new OpenFileDialog
					{
						Multiselect = false,
						Filter = "Images|*.png;*.jpg"
					};
					if (fd.ShowDialog() == DialogResult.OK)
					{
						//pbimages.Image = Image.FromFile(fd.FileName);
						(sender as PictureBox).Image = Image.FromFile(fd.FileName);
					}
				}
		}
		//int count=0;
		private void AddImgCMS_Click(object sender, EventArgs e)
		{
			var fd = new OpenFileDialog
			{
				Multiselect = false,
				Filter = "Images|*.png;*.jpg"
			};
			if (fd.ShowDialog() == DialogResult.OK)
			{
				//if (count == 2)
				//{

				//	count = 0;
				//}
				var lastImg = Images.LastOrDefault();
				var pb = new PictureBox
				{
					Image = Image.FromFile(fd.FileName),
					Size = new Size(151, 166),
					Location = new Point(lastImg.Location.X + 157, 3),
					SizeMode = PictureBoxSizeMode.StretchImage,
					ContextMenuStrip = contextMenuStrip1
				};
				pb.MouseDown += pbimages_MouseDown;
				pb.Click += pictureBox1_Click;
				pnImages.Controls.Add(pb);
				Images.Add(pb);
				//count++;
			}
		}

		private void pbimages_MouseDown(object sender, MouseEventArgs e)
		{
			currentPB = sender as PictureBox;
		}

		private void removeCMS_Click(object sender, EventArgs e)
		{
			pnImages.Controls.Remove(currentPB);
		}

		private async void frmNewProduct_Shown(object sender, EventArgs e)
		{
			var api = new APIHelper();
			var result = await api.PostAPIStringAsync(ConstantHelper.Url + "currency/api/v1/getList", null);
			if(result.Status == ConstantHelper.Success)
			{
				var ccy = JsonConvert.DeserializeObject<Currency>(result.JsonResult);
				cboCCY.DataSource = ccy.data;
				cboCCY.DisplayMember = "ccy";
				cboCCY.ValueMember = "ccy";
			}
			var sizeReq = await api.PostAPIStringAsync(ConstantHelper.Url + "sizes/api/v1/getList", null);
			if(sizeReq.Status == ConstantHelper.Success)
			{
				var sizeRes = JsonConvert.DeserializeObject<Sizes>(sizeReq.JsonResult);
					chklSize.Items.AddRange(sizeRes.data.sizes.ToArray());
			}
		}

		private async void txtDescription_TextChanged(object sender, EventArgs e)
		{
			//var txt = txtDescription.Text;
			//Translate.Google.Translate_Get("", "fr", "Hi");
			//MsgHelper.MsgInfo(Translate.Google.translate);

		}
	}
}
