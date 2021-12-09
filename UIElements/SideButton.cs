using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI366FinalProject.UIElements
{
    public class SideButton: System.Windows.Forms.Button
    {
        static List<SideButton> sidebuttons = new List<SideButton>();
        public SideButton()
        {
            sidebuttons.Add(this);
            this.MouseEnter += SideButton_MouseEnter;
            this.MouseClick += SideButton_Click;
        }

        private void SideButton_Click(object sender, MouseEventArgs e)
        {
            foreach(SideButton s in sidebuttons){
                s.BackColor = System.Drawing.SystemColors.ControlLight;
            }
            this.BackColor = System.Drawing.SystemColors.ControlDark;
        }

        private void SideButton_MouseEnter(object sender, EventArgs e)
        {
            //This is how you use this
        }
    }
}
