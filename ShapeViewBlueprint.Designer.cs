namespace Experiment2C
{
    partial class ShapeViewBlueprint
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
            edgeLabel = new Label();
            verticesLabel = new Label();
            areaLabel = new Label();
            perimeterLabel = new Label();
            showImage = new PictureBox();
            shapeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)showImage).BeginInit();
            SuspendLayout();
            // 
            // edgeLabel
            // 
            edgeLabel.AutoSize = true;
            edgeLabel.Font = new Font("Inter", 9F);
            edgeLabel.Location = new Point(242, 98);
            edgeLabel.Name = "edgeLabel";
            edgeLabel.Size = new Size(38, 15);
            edgeLabel.TabIndex = 0;
            edgeLabel.Text = "Edge:";
            // 
            // verticesLabel
            // 
            verticesLabel.AutoSize = true;
            verticesLabel.Font = new Font("Inter", 9F);
            verticesLabel.Location = new Point(242, 123);
            verticesLabel.Name = "verticesLabel";
            verticesLabel.Size = new Size(55, 15);
            verticesLabel.TabIndex = 1;
            verticesLabel.Text = "Vertices:";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Font = new Font("Inter", 9F);
            areaLabel.Location = new Point(242, 148);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(84, 15);
            areaLabel.TabIndex = 2;
            areaLabel.Text = "Area Formula:";
            // 
            // perimeterLabel
            // 
            perimeterLabel.AutoSize = true;
            perimeterLabel.Font = new Font("Inter", 9F);
            perimeterLabel.Location = new Point(242, 174);
            perimeterLabel.Name = "perimeterLabel";
            perimeterLabel.Size = new Size(112, 15);
            perimeterLabel.TabIndex = 3;
            perimeterLabel.Text = "Perimeter Formula:";
            // 
            // showImage
            // 
            showImage.Location = new Point(33, 28);
            showImage.Name = "showImage";
            showImage.Size = new Size(179, 185);
            showImage.TabIndex = 4;
            showImage.TabStop = false;
            // 
            // shapeLabel
            // 
            shapeLabel.AutoSize = true;
            shapeLabel.Font = new Font("Open Sans SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shapeLabel.Location = new Point(242, 45);
            shapeLabel.Name = "shapeLabel";
            shapeLabel.Size = new Size(104, 42);
            shapeLabel.TabIndex = 5;
            shapeLabel.Text = "Shape";
            shapeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ShapeViewBlueprint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 247);
            Controls.Add(shapeLabel);
            Controls.Add(showImage);
            Controls.Add(perimeterLabel);
            Controls.Add(areaLabel);
            Controls.Add(verticesLabel);
            Controls.Add(edgeLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ShapeViewBlueprint";
            Text = "Circle";
            ((System.ComponentModel.ISupportInitialize)showImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label edgeLabel;
        private Label verticesLabel;
        private Label areaLabel;
        private Label perimeterLabel;
        private PictureBox showImage;
        private Label shapeLabel;
    }
}