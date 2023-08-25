using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.PortableExecutable;

namespace Experiment2C
{
    partial class E2CForm
    {
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(E2CForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            viewCircle = new System.Windows.Forms.Button();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            viewRectangle = new System.Windows.Forms.Button();
            viewCylinder = new System.Windows.Forms.Button();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = E2C.Properties.Resources.Circle;
            pictureBox1.Location = new Point(64, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = E2C.Properties.Resources.Rectangle;
            pictureBox2.Location = new Point(348, 230);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 250);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = E2C.Properties.Resources.Cylinder;
            pictureBox3.Location = new Point(634, 230);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 250);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // viewCircle
            // 
            viewCircle.Location = new Point(152, 486);
            viewCircle.Name = "viewCircle";
            viewCircle.Size = new Size(75, 23);
            viewCircle.TabIndex = 3;
            viewCircle.Text = "Circle";
            viewCircle.UseVisualStyleBackColor = true;
            viewCircle.Click += viewCircle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans", 18F, FontStyle.Bold);
            label1.Location = new Point(305, 141);
            label1.Name = "label1";
            label1.Size = new Size(328, 35);
            label1.TabIndex = 6;
            label1.Text = "Shape Information Gallery";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = E2C.Properties.Resources.MMCM;
            pictureBox4.Location = new Point(372, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(188, 138);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 176);
            label2.Name = "label2";
            label2.Size = new Size(255, 27);
            label2.TabIndex = 8;
            label2.Text = "Authored by Aidre Cabrera";
            // 
            // viewRectangle
            // 
            viewRectangle.Location = new Point(436, 486);
            viewRectangle.Name = "viewRectangle";
            viewRectangle.Size = new Size(75, 23);
            viewRectangle.TabIndex = 9;
            viewRectangle.Text = "Rectangle";
            viewRectangle.UseVisualStyleBackColor = true;
            viewRectangle.Click += viewRectangle_Click;
            // 
            // viewCylinder
            // 
            viewCylinder.Location = new Point(723, 486);
            viewCylinder.Name = "viewCylinder";
            viewCylinder.Size = new Size(75, 23);
            viewCylinder.TabIndex = 10;
            viewCylinder.Text = "Cylinder";
            viewCylinder.UseVisualStyleBackColor = true;
            viewCylinder.Click += viewCylinder_Click;
            // 
            // E2CForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(953, 553);
            Controls.Add(viewCylinder);
            Controls.Add(viewRectangle);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(viewCircle);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "E2CForm";
            Text = "Experiment2C by Aidre Cabrera";
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Button viewCircle;
        private Label label1;
        private PictureBox pictureBox4;
        private Label label2;
        private System.Windows.Forms.Button viewRectangle;
        private System.Windows.Forms.Button viewCylinder;

        /*Create an application with four classes.Three of the classes should contain data and behavior characteristics for circle, rectangle, and cylinder, respectively.The fourth class should allow the user to input a figure type from a menu options. Prompt for appropriate values based on the inputted figure type, instantiate an object of the type entered, and display characteristics about the object. Sample output: */
    }

}
