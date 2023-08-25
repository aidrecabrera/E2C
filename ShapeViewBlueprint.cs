using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Experiment2C
{
    public partial class ShapeViewBlueprint : Form
    {
        public ShapeViewBlueprint(string imgurl, string edgeLabel, string verticesLabel, string areaLabel, string perimeterLabel, string shapeLabel, int width)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(imgurl))
            {
                string resourceName = "E2C.Properties.Resources." + imgurl;
                object resource = global::E2C.Properties.Resources.ResourceManager.GetObject(imgurl);

                if (resource != null && resource is Image)
                {
                    showImage.Image = (Image)resource;
                }
            }
            this.Text = imgurl;
            this.Icon = global::E2C.Properties.Resources.mmcmlogo;
            this.showImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.edgeLabel.Text = edgeLabel;
            this.verticesLabel.Text = verticesLabel;
            this.areaLabel.Text = areaLabel;
            this.perimeterLabel.Text = perimeterLabel;
            this.shapeLabel.Text = shapeLabel;
            this.Size = new Size(width, 286);
            this.FormClosed += ShapeViewBlueprint_FormClosed;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void ShapeViewBlueprint_FormClosed(object sender, FormClosedEventArgs e)
        {
            E2CForm e2CForm = new E2CForm();
            e2CForm.Show();
        }

    }
}
