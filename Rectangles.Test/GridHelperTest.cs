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
    public class GridHelperTest
    {
        private Mock<Form> _formMock = new Mock<Form>();
        private GridHelper _gridHelper;

        public GridHelperTest()
        {
            Panel panel = new Panel()
            {
                Width = 250,
                Height = 250
            };

            _gridHelper = new GridHelper(_formMock.Object.CreateGraphics(), panel);
        }

        [TestMethod]
        public void TestDrawGridLines()
        {
            try
            {
                _gridHelper.DrawGridLines();
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        
        }

        
    }
}