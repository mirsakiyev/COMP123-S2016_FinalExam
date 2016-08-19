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
            // setting the timer
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();   
            InitializeComponent();
            t.Abort();
        }

        // starting splash form
        public void SplashStart()
        {
            Application.Run(new SplashScreen());
        }

        public void GenerateNames()
        {            
                // generating a random number (1-50)
                Random rnd = new Random();
            Character character = Program.character;
            int randomNumber = rnd.Next(1, 51); 
                

            FirstNameTextBox.Text = string.Empty;

            foreach (string firstName in FirstNameListBox.SelectedItems)
            {
                FirstNameTextBox.Text = firstName.ToString();
                character.FirstName = firstName.ToString();               
            }
                
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            // calling generate names method
            GenerateNames();        
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Step 1 - Hide the parent form
            this.Hide();

            // Step 2 - Instantiate an object for the form type
            // you are going to next
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();

            // Step 3 - create a property in the next form that 
            // we will use to point to this form
            // e.g. public AbilityGeneratorForm previousForm;

            // Step 4 - point this form to the parent Form 
            // property in the next form
            abilityGeneratorForm.previousForm = this;

            // Step 5 - Show the next form
            abilityGeneratorForm.Show();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
