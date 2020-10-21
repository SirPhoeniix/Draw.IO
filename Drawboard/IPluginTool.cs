using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawboard
{
    public interface IPluginTool
    {
        string Name { get; set; }
        Image Icon { get; set; }
        Pen Pen { get; set; }
        Graphics Graphics { get; set; }

        void SetGraphics(Graphics g);
        void OnMouseDown(object sender, MouseEventArgs e);
        void OnMouseUp(object sender, MouseEventArgs e);
        void OnMouseMove(object sender, MouseEventArgs e);
        void OnKeyDown(object sender, Keys keyData);
    }
}
