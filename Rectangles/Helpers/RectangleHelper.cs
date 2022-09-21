namespace Rectangles.Helpers
{
    public class RectangleHelper
    {
        private Graphics _graphics;
        private Panel _panel;
        private List<Rectangle> _rectangleList;

        public RectangleHelper(Graphics graphics, Panel panel, List<Rectangle> rectangleList)
        {
            _graphics = graphics;
            _panel = panel;
            _rectangleList = rectangleList;
        }

        public void DrawRect(Rectangle rectangle)
        {
            Pen pen = new Pen(Color.Red, 2.0F);
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(128, Color.Red));

            _graphics.FillRectangle(solidBrush, rectangle);
            _graphics.DrawRectangle(pen, rectangle);
        }

        public Rectangle? FindRect(Point location, Size size)
        {
            IEnumerable<Rectangle> rectangleListFiltered = _rectangleList
                .Where(rect =>
                {
                    return (location.X >= rect.X
                        && location.X < rect.X + rect.Width
                        && location.Y >= rect.Y
                        && location.Y < rect.Y + rect.Height)
                        || (location.X + size.Width > rect.X
                        && location.X + size.Width <= rect.X + rect.Width
                        && location.Y + size.Height > rect.Y
                        && location.Y + size.Height <= rect.Y + rect.Height);
                });

            if (rectangleListFiltered.Any())
                return rectangleListFiltered.First();

            return null;
        }

        public bool AddRect(Point location, Size size)
        {
            if ((location.X + size.Width) <= _panel.Width && (location.Y + size.Height) <= _panel.Height)
            {
                if (FindRect(location, size) == null)
                {
                    _rectangleList.Add(new Rectangle(location, size));
                    return true;
                }
            }

            return false;
        }

        public bool RemoveRect(Point location, Size size)
        {
            Rectangle? rectangle = FindRect(location, size);
            if (rectangle != null)
            {
                _rectangleList.Remove((Rectangle)rectangle);
                return true;
            }
            return false;
        }

        public bool ClearRect()
        {
            if (_rectangleList.Any())
            {
                _rectangleList.Clear();
                return true;
            }
            return false;
        }
    }
}
