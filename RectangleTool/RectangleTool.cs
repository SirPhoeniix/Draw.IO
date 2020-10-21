using Drawboard;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleTool
{
    public class RectangleTool : IPluginTool
    {
        public string Name { get; set; }
        public Image Icon { get; set; }
        public Pen Pen { get; set; }
        public Graphics Graphics { get; set; }

        public Point m_pStartPoint;
        public Point m_pEndPoint;
        public bool bSquare;

        public RectangleTool()
        {
            Name = "RectangleTool";
            Icon = Resource.rectangle_48;
            Pen = new Pen(Color.Black, 5);
        }

        public void SetGraphics(Graphics g)
        {
            Graphics = g;
        }

        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;

                m_pStartPoint = new Point(x, y);
            }
        }

        public void OnMouseMove(object sender, MouseEventArgs e)
        {

        }

        public void OnMouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            m_pEndPoint = new Point(x, y);

            if (m_pStartPoint.X > m_pEndPoint.X)
            {
                int tempX = m_pEndPoint.X;
                m_pEndPoint.X = m_pStartPoint.X;
                m_pStartPoint.X = tempX;
            }

            if (m_pStartPoint.Y > m_pEndPoint.Y)
            {
                int tempY = m_pEndPoint.Y;
                m_pEndPoint.Y = m_pStartPoint.Y;
                m_pStartPoint.Y = tempY;
            }

            if (bSquare)
            {
                Graphics.DrawRectangle(Pen, m_pStartPoint.X, m_pStartPoint.Y, m_pEndPoint.X - m_pStartPoint.X, m_pEndPoint.X - m_pStartPoint.X);
                bSquare = false;
            }
            else
            {
                Graphics.DrawRectangle(Pen, m_pStartPoint.X, m_pStartPoint.Y, m_pEndPoint.X - m_pStartPoint.X, m_pEndPoint.Y - m_pStartPoint.Y);
            }
        }

        public void OnKeyDown(object sender, Keys keyData)
        {
            if (keyData == (Keys.Shift | Keys.ShiftKey))
            {
                bSquare = true;
            }
        }
    }
}
