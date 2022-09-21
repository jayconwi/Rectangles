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
    public class PanelDrawHelperTest
    {
        private Mock<Form> _formMock = new Mock<Form>();
        private readonly ControlDrawHelper<Panel> _panelDrawHelper;

        public PanelDrawHelperTest()
        {

            Graphics graphics = _formMock.Object.CreateGraphics();

            Panel panel = new Panel()
            {
                Width = 250,
                Height = 250
            };

            _panelDrawHelper = new PanelDrawHelper(graphics, panel);
        }

        [TestMethod]
        public void TestDrawGridLines()
        {
            try
            {
                _panelDrawHelper.DrawGridLines();
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        
        }

        
    }
}