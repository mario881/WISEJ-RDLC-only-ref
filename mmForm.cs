using System;
using Wisej.Web;

namespace WisejWebDesktopApplication1
{
    public class mmForm:Form
    {
        public mmForm()
        {
            this.Move += new System.EventHandler(this.Window1_Move);
        }

        private void Window1_Move(object sender, EventArgs e)
        {
            var xx = this;

            if (xx.Top < 45) { xx.Top = 45; }
            if (xx.Left < 3) { xx.Left = 3; }
        }
    }
}
