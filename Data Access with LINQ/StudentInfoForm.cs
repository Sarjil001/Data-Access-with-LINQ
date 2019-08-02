using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Access_with_LINQ
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }

        private void StudentInfoForm_Activated(object sender, EventArgs e)
        {
            //open File To Stream to read
            using (StreamReader inputStream = new StreamReader(
                File.Open("Student.txt", FileMode.Open)))
            {
                //Read stuff to the file into the Student Object
                Program.student.id = int.Parse(inputStream.ReadLine());
                Program.student.StudentID =inputStream.ReadLine();
                Program.student.FirstName = inputStream.ReadLine();
                Program.student.LastName = inputStream.ReadLine();

                //cleanup
                inputStream.Close();
                inputStream.Dispose();

                IDDateLabel.Text = Program.student.id.ToString();
                StudentIDDataLabel.Text = Program.student.StudentID;
                FirstNameDataLabel.Text = Program.student.FirstName;
                LastNameDataLabel.Text = Program.student.LastName;

            }
        }

        private void StudentInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
