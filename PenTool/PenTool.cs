using Drawboard;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenTool
{
    public class PenTool : IPluginTool
    {
        public string Name { get; set; }
        public Image Icon { get; set; }
        public Pen Pen { get; set; }
        public Graphics Graphics { get; set; }

        public Point m_pStartPoint;
        public Point m_pEndPoint;
        public bool m_bPenDown;

        public PenTool()
        {
            Name = "PenTool";
            Icon = Resource.pen_48;
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
                m_bPenDown = true;
            }
        }

        public void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (m_bPenDown)
            {
                int x = e.X;
                int y = e.Y;

                m_pEndPoint = new Point(x, y);

                //Graphics.FillEllipse(Pen.Brush, m_pStartPoint.X, m_pStartPoint.Y, Pen.Width, Pen.Width);
                Graphics.DrawLine(Pen, m_pStartPoint, m_pEndPoint);

                m_pStartPoint = m_pEndPoint;
            }
        }

        public void OnMouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            m_pEndPoint = new Point(x, y);
            m_bPenDown = false;
        }

        public void OnKeyDown(object sender, Keys keyData)
        {
            
        }
    }
}
