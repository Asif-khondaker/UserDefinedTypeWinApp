using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDefinedTypeDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<Person> persons = new List<Person>();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Person aPerson = new Person();


            aPerson.firstName = firstNameTextBox.Text;
            aPerson.middleName = middleNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;

            firstNameTextBox.Text = " ";
            middleNameTextBox.Text = " ";
            lastNameTextBox.Text = " ";

            persons.Add(aPerson);
        }
        private void Change()
        {
            // Change 
        }
        private void ShowAllFullNamesButton_Click(object sender, EventArgs e)
        {
            fullNameListBox.Items.Clear();
            foreach(Person person in persons)
            {
                fullNameListBox.Items.Add(person.GetFullName());
            }
        }
    }
}
