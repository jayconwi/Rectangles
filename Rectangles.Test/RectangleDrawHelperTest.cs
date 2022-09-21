using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Rectangles.Helpers;
using System;
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
        private List<Rectangle> _rectangleList = new List<Rectangle>();

        private ShapeDrawHelper<Rectangle> _rectangleDrawHelper;

        private Point _location = new Point(10, 10);
        private Size _size = new Size(20, 20);

        public RectangleDrawHelperTest()
        {
            Graphics graphics = _formMock.Object.CreateGraphics();

            Panel panel = new Panel()
            {
                Width = 250,
                Height = 250
            };

            _rectangleDrawHelper = new RectangleDrawHelper(graphics, panel, _rectangleList);
        }

        [TestMethod]
        public void TestDrawRect()
        {
            try
            {
                _rectangleDrawHelper.Draw(new Rectangle(_location, _size));
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void TestAddRect()
        {
            _rectangleDrawHelper.Add(_location, _size);
            Assert.IsTrue(_rectangleList.Count == 1);
        }

        [TestMethod]
        public void TestAddRectOverlap()
        {
            _rectangleDrawHelper.Add(_location, _size);
            _rectangleDrawHelper.Add(_location, _size);
            Assert.IsTrue(_rectangleList.Count == 1);
        }

        [TestMethod]
        public void TestAddRectExceedGrid()
        {
            _rectangleDrawHelper.Add(_location, new Size(0, 250));
            Assert.IsFalse(_rectangleList.Any());

            _rectangleDrawHelper.Add(_location, new Size(250, 0));
            Assert.IsFalse(_rectangleList.Any());
        }


        [TestMethod]
        public void TestFindRect()
        {
            _rectangleDrawHelper.Add(_location, _size);
            Assert.IsTrue(_rectangleList.Any());
        }

        [TestMethod]
        public void TestRemoveRect()
        {
            _rectangleDrawHelper.Add(_location, _size);
            if (_rectangleList.Any())
            {
                bool removeResult = _rectangleDrawHelper.Remove(_location, _size);
                Assert.IsTrue(removeResult);
            }

        }

        [TestMethod]
        public void TestClearRect()
        {
            _rectangleDrawHelper.Add(_location, _size);
            if (_rectangleList.Any())
            {
                bool removeResult = _rectangleDrawHelper.Clear();
                Assert.IsTrue(removeResult);
            }

        }
    }
}