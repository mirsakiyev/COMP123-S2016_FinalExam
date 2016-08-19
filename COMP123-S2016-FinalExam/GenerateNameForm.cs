using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace COMP123_S2016_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();   
            InitializeComponent();
            t.Abort();
        }

 
        public void SplashStart()
        {
            Application.Run(new SplashScreen());
        }

        public void GenerateNames()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1,51);

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            
        }
    }
}
