using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hw3q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Personel
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }

            public int dd, mm, yy;
            public Personel() { }
            public Personel(string FirstName, string MiddleName, string LastName, int dd, int mm, int yy)
            {
                this.FirstName = FirstName;
                this.MiddleName = MiddleName;
                this.LastName = LastName;
                this.dd = dd;
                this.mm = mm;
                this.yy = yy;
            }
        }

        public class Employee : Personel
        {
            public int ID { get; set; }
            public double SalaryPerYear { get; set; }
            public double SalaryPerHour { get; set; }
            public int Age { get; set; }

            public Employee() { }

            public Employee(int ID, double SalaryPerYear, string FirstName, string MiddleName, string LastName, int dd, int mm, int yy) : base(FirstName, MiddleName, LastName, dd, mm, yy)
            {
                this.ID = ID;
                this.SalaryPerYear = SalaryPerYear;
            }
            public void SalaryPerHourFun(int Hour)
            {
                SalaryPerHour = SalaryPerYear / Hour;
            }
            public void AgeOfPersonelFun(int Year)
            {
                Age = Year - yy;
            }

        }
        public class Students : Personel
        {
            public int RegistrationNo { get; set; }
            public double GPA { get; set; }
            public char GPALetter { get; set; }
            public Students() { }
            public Students(int RegistrationNo, double GPA, string FirstName, string MiddleName, string LastName, int dd, int mm, int yy) : base(FirstName, MiddleName, LastName, dd, mm, yy)
            {
                this.GPA = GPA;
                this.RegistrationNo = RegistrationNo;
            }


            public void GPAFun()
            {
                if ((GPA >= 3.4) && (GPA <= 4.00)) GPALetter = 'A';
                else if ((GPA >= 2.8) && (GPA <= 3.39)) GPALetter = 'B';
                else if ((GPA >= 2.4) && (GPA <= 2.79)) GPALetter = 'C';
                else if ((GPA >= 2.8) && (GPA <= 2.39)) GPALetter = 'D';
                else GPALetter = 'F';
            }
        }

        private void button_PersonelCalculate_Click(object sender, EventArgs e)
        {

            int.TryParse(textBox_ID.Text, out int ID);
            double.TryParse(textBox_SalaryPerYear.Text, out double SalaryPerYear);
            int.TryParse(textBox_DD.Text, out int DD);
            int.TryParse(textBox_MM.Text, out int MM);
            int.TryParse(textBox_YY.Text, out int YY);
            int.TryParse(textBox_TotalHour.Text, out int Hour);

            Employee Employee1 = new Employee(ID, SalaryPerYear, textBox_FirstName.Text, textBox_MiddleName.Text, textBox_LastName.Text, DD, MM, YY);
            Employee1.SalaryPerHourFun(Hour);
            textBox_SalaryPerHour.Text = Employee1.SalaryPerHour.ToString();
            Employee1.AgeOfPersonelFun(System.DateTime.Now.Year);
            textBox_Age.Text = Employee1.Age.ToString();
        }

        private void button_StudentCalculate_Click(object sender, EventArgs e)
        {

            int.TryParse(textBox_RegistrationNo.Text, out int RegistrationNo);
            double.TryParse(textBox_GPA.Text, out double GPA);
            int.TryParse(textBox_DD.Text, out int DD);
            int.TryParse(textBox_MM.Text, out int MM);
            int.TryParse(textBox_YY.Text, out int YY);

            Students Student1 = new Students(RegistrationNo, GPA, textBox_FirstName.Text, textBox_MiddleName.Text, textBox_LastName.Text, DD, MM, YY);
            Student1.GPAFun();
            textBox_GPALetter.Text = Student1.GPALetter.ToString();



        }
    }
}
