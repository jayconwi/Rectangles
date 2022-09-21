namespace Rectangles.Helpers
{
    public class PanelDrawHelper : ControlDrawHelper<Panel>
    {
        private Graphics _graphics;
        private Panel _panel;

        public PanelDrawHelper(Graphics graphics, Panel panel)
        {
            _graphics = graphics;
            _panel = panel;
        }

        public override void DrawGridLines()
        {
            Pen pen = new Pen(Color.LightGray, 1.0F);

            for (int x = 10; x < _panel.Width; x += 10)
                _graphics.DrawLine(pen, new Point(0, x), new Point(_panel.Height, x));

            for (int y = 10; y < _panel.Width; y += 10)
                _graphics.DrawLine(pen, new Point(y, 0), new Point(y, _panel.Height));
        }
    }
}
