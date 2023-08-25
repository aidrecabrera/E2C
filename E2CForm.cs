namespace Experiment2C
{
    public partial class E2CForm : Form
    {
        public E2CForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void WindowPasser(Form viewed)
        {
            this.Hide();
            viewed.ShowDialog();
        }
        private void viewCircle_Click(object sender, EventArgs e)
        {
            WindowPasser(new ShapeViewBlueprint(
            "Circle",
            "Edges: 0 edges (it's a curved shape).",
            "Vertices: 0 vertices.",
            "Area Formula: π * radius².",
            "Perimeter Formula: 2 * π * radius.",
            "Circle", 550));
        }

        private void viewRectangle_Click(object sender, EventArgs e)
        {
            WindowPasser(new ShapeViewBlueprint(
            "Rectangle",
            "Edges: 4 edges.",
            "Vertices: 4 vertices.",
            "Area Formula: width * height.",
            "Perimeter Formula: 2 * (width + height).",
            "Rectangle", 550));
        }

        private void viewCylinder_Click(object sender, EventArgs e)
        {
            WindowPasser(new ShapeViewBlueprint(
            "Cylinder",
            "Edges: 3 edges (2 circular bases and 1 curved lateral surface).",
            "Vertices: 0 vertices on the curved surface, 2 vertices on each base (total 4 vertices).",
            "Area Formula: 2 * π * radius * (radius + height).",
            "Perimeter Formula: Not applicable, as cylinders have curved surfaces, not perimeters.",
            "Cylinder", 800));
        }
    }
}
