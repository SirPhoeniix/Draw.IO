using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawboard
{
    class BitmapHistory
    {
        private List<Bitmap> m_lstBitmapHistory;
        private int nIndex;

        public BitmapHistory()
        {
            m_lstBitmapHistory = new List<Bitmap>();
        }

        public void Add(Bitmap bitmap)
        {
            m_lstBitmapHistory.Add(bitmap);
            nIndex = m_lstBitmapHistory.Count - 1;
        }

        public Bitmap this[int index]
        {
            get
            {
                return m_lstBitmapHistory[index];
            }
            set
            {
                m_lstBitmapHistory[index] = value;
            }
        }

        public void RemoveAt(int index)
        {
            m_lstBitmapHistory.RemoveAt(index);
        }

        public void Remove(Bitmap bitmap)
        {
            m_lstBitmapHistory.Remove(bitmap);
        }

        public Bitmap GetPrev()
        {
            try
            {
                nIndex--;
                return m_lstBitmapHistory[nIndex];
            }
            catch (Exception e)
            {
                nIndex = 0;
                return m_lstBitmapHistory[nIndex];
            }
        }

        public Bitmap GetNext()
        {
            try
            {
                nIndex++;
                return m_lstBitmapHistory[nIndex];
            }
            catch (Exception e)
            {
                nIndex = m_lstBitmapHistory.Count - 1;
                return m_lstBitmapHistory[nIndex];
            }
        }
    }
}
