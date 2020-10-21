using Drawboard;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineTool
{
    public class LineTool : IPluginTool
    {
        public string Name { get; set; }
        public Image Icon { get; set; }
        public Pen Pen { get; set; }
        public Graphics Graphics { get; set; }

        public Point m_pStartPoint;
        public Point m_pEndPoint;
        public bool bStraight;

        public LineTool()
        {
            Name = "LineTool";
            Icon = Resource.line_48;
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

            if (bStraight)
            {
                if ((m_pStartPoint.X - m_pEndPoint.X) > (m_pStartPoint.Y - m_pEndPoint.Y))
                {
                    m_pEndPoint.X = m_pStartPoint.X;
                }
                else
                {
                    m_pEndPoint.Y = m_pStartPoint.Y;
                }
                Graphics.DrawLine(Pen, m_pStartPoint, m_pEndPoint);
                bStraight = false;
            }
            else
            {
                Graphics.DrawLine(Pen, m_pStartPoint, m_pEndPoint);
            }
        }

        public void OnKeyDown(object sender, Keys keyData)
        {
            if (keyData == (Keys.Shift | Keys.ShiftKey))
            {
                bStraight = true;
            }
        }
    }
}
