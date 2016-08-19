using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // setting up the timer
            try
            {
                progressBar.Increment(1);
                if (progressBar.Value == 100)
                {
                    timer.Stop();
                }
            }
            catch (Exception)
            {

                throw;
            }           
        }
    }
}
