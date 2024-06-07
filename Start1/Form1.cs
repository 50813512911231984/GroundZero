using Start1;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start1
{
 
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                long notepad;
                long editx;
                notepad = FindWindow("notepad", Constants.vbNullString);
                editx = FindWindowEx(notepad, 0 &, "edit", Constants.vbNullString);
                SendMessageByString(editx, WM_SETTEXT, 0 &, "The New Text");
            }

        }
        public void test1()
        {
            MessageBox.Show("Test");
          
            // return System.Reflection.MethodBase.GetCurrentMethod().Name;
        }
    }
}
