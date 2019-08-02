using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Access_with_LINQ
{
    public static class Program
    {
        public static StartForm startForm;
        public static MainForm mainForm;
        public static AboutForm aboutForm;
        public static Student student;
        public static StudentInfoForm studentInfoForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startForm = new StartForm();
            mainForm = new MainForm();
            aboutForm = new AboutForm();
            studentInfoForm = new StudentInfoForm();

            student = new Student();

            Application.Run(startForm);
        }
    }
}
