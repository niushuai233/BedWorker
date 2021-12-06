using System;
using System.Drawing;
using System.Windows.Forms;

namespace BedWorker.Entity.Base
{
    public class TextBoxExt : TextBox
    {
        /**
         * placeholder属性
         */
        public String Placeholder { get; set; }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0xF || m.Msg == 0x133)
            {
                WmPaint(ref m);
            }
        }
        private void WmPaint(ref Message m)
        {
            Graphics g = Graphics.FromHwnd(base.Handle);
            if (!String.IsNullOrEmpty(this.Placeholder) && string.IsNullOrEmpty(this.Text))
                g.DrawString(this.Placeholder, this.Font, new SolidBrush(Color.LightGray), 0, 0);
        }
    }
}
