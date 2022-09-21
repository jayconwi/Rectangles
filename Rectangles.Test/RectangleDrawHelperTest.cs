using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Rectangles.Helpers;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Rectangles.Test
{
    [TestClass]
    public class RectangleDrawHelperTest
    {
        private Mock<Form> _formMock = new Mock<Form>();
        private ShapeDrawHelper<Rectangle> _rectangleDrawHelper;
        private List<Rectangle> _rectangleList;

        public RectangleDrawHelperTest()
        {
            Graphics graphics = _formMock.Object.CreateGraphics();

            Panel panel = new Panel()
            {
                Width = 25,
                Height = 25
            };

            _rectangleList = new List<Rectangle>();

            _rectangleDrawHelper = new RectangleDrawHelper(graphics, panel, _rectangleList);
        }

        [TestMethod]
        public void TestAddRect()
        {
            _rectangleDrawHelper.Add(new Point(2, 2), new Size(2, 3));
            Assert.IsTrue(_rectangleList.Count == 1);
        }

        [TestMethod]
        public void TestAddRectOverlap()
        {
            _rectangleDrawHelper.Add(new Point(1, 2), new Size(2, 3));
            _rectangleDrawHelper.Add(new Point(2, 2), new Size(2, 3));
            Assert.IsTrue(_rectangleList.Count == 1);
        }

        [TestMethod]
        public void TestAddRectExceedGrid()
        {
            _rectangleDrawHelper.Add(new Point(25, 2), new Size(2, 3));
            Assert.IsFalse(_rectangleList.Any());
        }


        [TestMethod]
        public void TestFindRect()
        {
            _rectangleDrawHelper.Add(new Point(2, 2), new Size(2, 3));
            Assert.IsTrue(_rectangleList.Any());
        }

        [TestMethod]
        public void TestRemoveRect()
        {
            _rectangleDrawHelper.Add(new Point(2, 2), new Size(2, 3));
            if (_rectangleList.Any())
            {
                bool removeResult = _rectangleDrawHelper.Remove(new Point(2, 2), new Size(2, 3));
                Assert.IsTrue(removeResult);
            }

        }

        [TestMethod]
        public void TestClearRect()
        {
            _rectangleDrawHelper.Add(new Point(2, 2), new Size(2, 3));
            if (_rectangleList.Any())
            {
                bool removeResult = _rectangleDrawHelper.Clear();
                Assert.IsTrue(removeResult);
            }

        }
    }
}