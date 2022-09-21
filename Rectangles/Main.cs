using Rectangles.Helpers;

namespace Rectangles
{
    public partial class Main : Form
    {
        private ControlDrawHelper<Panel> _panelDrawHelper;
        private ShapeDrawHelper<Rectangle> _rectangleDrawHelper;

        private List<Rectangle> _rectangleList;

        public Main()
        {
            InitializeComponent();
            _rectangleList = new List<Rectangle>();
        }

        #region Events

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {
            // Setup the grid
            panelGrid.Width = 250;
            panelGrid.Height = 250;

            _panelDrawHelper = new PanelDrawHelper(e.Graphics, panelGrid);
            _rectangleDrawHelper = new RectangleDrawHelper(e.Graphics, panelGrid, _rectangleList);

            _panelDrawHelper.DrawGridLines();
           
            foreach (Rectangle rectangle in _rectangleList)
                _rectangleDrawHelper.Draw(rectangle);

            e.Graphics.Dispose();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_rectangleDrawHelper.Add(Location, Size))
                panelGrid.Invalidate();
            else
                MessageBox.Show("The rectangle you are creating might be overlaping with another\n\ror might be exceeding the grid.");
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Rectangle? rectangle = _rectangleDrawHelper.Find(Location, Size);
            if (rectangle != null)
            {
                int x = ((Rectangle)rectangle).X / 10;
                int y = ((Rectangle)rectangle).Y / 10;
                int width = ((Rectangle)rectangle).Width / 10;
                int height = ((Rectangle)rectangle).Height / 10;
                MessageBox.Show($"Found Rectangle\n\rLocation=X:{x},Y:{y}\n\rSize=W:{width},H:{height}");
            }
            else
                MessageBox.Show("No rectangle found in the specific location");
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (_rectangleDrawHelper.Remove(Location, Size))
                panelGrid.Invalidate();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (_rectangleDrawHelper.Clear())
                panelGrid.Invalidate();
        }

        #endregion

        #region Properties

        private Point Location
        {
            get
            {
                string[] position = textLocation.Text.Trim().Split(',');
                return new Point(int.Parse(position[0]) * 10, int.Parse(position[1]) * 10);
            }
        }

        private Size Size
        {
            get
            {
                string[] size = textSize.Text.Trim().Split(',');
                return new Size(int.Parse(size[0]) * 10, int.Parse(size[1]) * 10);
            }
        }

        #endregion
    }
}