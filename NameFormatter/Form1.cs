/*
Programmer Name: Berzaf Teklu
Date: 9/12/2020


Create an application that lets the user enter the following pieces of data:
    The user's first name
    The user's miidle name
    The user's last name
    The user's preferred title(Mr., Mrs, Ms., Dr., etc)

Assume the user has entered the following data: 
    First name: Kelly 
    Middle name: Jane 
    Last name: Smith 
    Title: Ms.
The application should have buttons that display the user’s name formatted in the following ways: 
    Ms.Kelly Jane Smith 
    Kelly Jane Smith 
    Kelly Smith 
    Smith, Kelly Jane, Ms. 
    Smith, Kelly Jane 
    Smith, Kelly
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameFormatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnFormatName_Click(object sender, EventArgs e)
        {
            string firstName;
            string middleName;
            string lastName;
            string title;
            firstName = firstNameTextBox.Text;
            middleName = middleNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            title = titleNameTextBox.Text;

            outPut.Items.Add(title + " " + firstName + " " + middleName + " " + lastName);           //Ms. Kelly Jane Smith 
            outPut.Items.Add(firstName + " " + middleName + " " + lastName);                         //Kelly Jane Smith 
            outPut.Items.Add(firstName + " " + lastName);                                            //Kelly Smith
            outPut.Items.Add(lastName + ", " + firstName + " " + middleName + ", " + title);         //Smith, Kelly Jane, Ms.
            outPut.Items.Add(lastName + ", " + firstName + " " + middleName);                        //Smith, Kelly Jane
            outPut.Items.Add(lastName + ", " + firstName);                                           //Smith, Kelly

        }


    }
}
