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
    public class RectangleHelperTest
    {
        private Mock<Form> _formMock = new Mock<Form>();
        private RectangleHelper _rectangleHelper;
        private List<Rectangle> _rectangleList;

        public RectangleHelperTest()
        {
            Panel panel = new Panel()
            {
                Width = 25,
                Height = 25
            };

            _rectangleList = new List<Rectangle>();
            _rectangleHelper = new RectangleHelper(_formMock.Object.CreateGraphics(), panel, _rectangleList);
        }

        [TestMethod]
        public void TestAddRect()
        {
            _rectangleHelper.AddRect(new Point(2, 2), new Size(2, 3));
            Assert.IsTrue(_rectangleList.Count == 1);
        }

        [TestMethod]
        public void TestAddRectOverlap()
        {
            _rectangleHelper.AddRect(new Point(1, 2), new Size(2, 3));
            _rectangleHelper.AddRect(new Point(2, 2), new Size(2, 3));
            Assert.IsTrue(_rectangleList.Count == 1);
        }

        [TestMethod]
        public void TestAddRectExceedGrid()
        {
            _rectangleHelper.AddRect(new Point(25, 2), new Size(2, 3));
            Assert.IsFalse(_rectangleList.Any());
        }


        [TestMethod]
        public void TestFindRect()
        {
            _rectangleHelper.AddRect(new Point(2, 2), new Size(2, 3));
            Assert.IsTrue(_rectangleList.Any());
        }

        [TestMethod]
        public void TestRemoveRect()
        {
            _rectangleHelper.AddRect(new Point(2, 2), new Size(2, 3));
            if (_rectangleList.Any())
            {
                bool removeResult = _rectangleHelper.RemoveRect(new Point(2, 2), new Size(2, 3));
                Assert.IsTrue(removeResult);
            }

        }

        [TestMethod]
        public void TestClearRect()
        {
            _rectangleHelper.AddRect(new Point(2, 2), new Size(2, 3));
            if (_rectangleList.Any())
            {
                bool removeResult = _rectangleHelper.ClearRect();
                Assert.IsTrue(removeResult);
            }

        }
    }
}