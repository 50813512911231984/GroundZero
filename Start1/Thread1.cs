using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Start1
{
    public class Thread1:Form1
    {
       
        static long Worker = 0;
        public static void StartThread(Action TheTest)
        {  
            try
            {
                Thread thread = new Thread(new ThreadStart(TheTest));
                Worker++;
                thread.Name = Worker.ToString();
                thread.Start(); 
            }
            catch(Exception ex) 
            {
                Worker--;
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
   
            }
        }
    }
}
