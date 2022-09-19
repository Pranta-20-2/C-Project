using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_Project
{
    internal class AbstractInherit: Abstract
    {
        public override void Welcome()
        {
            MessageBox.Show("....... WELCOME ....... ");
        }
        public override void ThankYou()
        {
            MessageBox.Show("........ THANK YOU ........ ");
        }
    }
}
