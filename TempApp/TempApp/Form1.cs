using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var collection = Journey.Journeys;

            var result = from t in collection
                         group t by t.Month into g
                         select new { Month = g.Key, Journeys = g };
        }
    }

    public class Journey
    {

        public static List<Journey> Journeys
        {
            get
            {
                List<Journey> listJourney = new List<Journey>();
                listJourney.Add(new Journey() { JourneyNo = "JAA00901", JourneyDate = DateTime.Now.Date, Reg = "VT-IND", Color = Color.Blue, Employees = Employee.Employees });
                listJourney.Add(new Journey() { JourneyNo = "JAA00902", JourneyDate = DateTime.Now.Date.AddDays(1).Date, Reg = "VT-IND", Color = Color.Blue, Employees = Employee.Employees });
                listJourney.Add(new Journey() { JourneyNo = "JAA00903", JourneyDate = DateTime.Now.Date.AddDays(2).Date, Reg = "VT-IND", Color = Color.Red, Employees = Employee.Employees });
                listJourney.Add(new Journey() { JourneyNo = "JAA00904", JourneyDate = DateTime.Now.Date.AddDays(3).Date, Reg = "VT-IND", Color = Color.Blue, Employees = Employee.Employees });
                listJourney.Add(new Journey() { JourneyNo = "JAA00905", JourneyDate = DateTime.Now.Date.AddDays(4).Date, Reg = "VT-IND", Color = Color.Red, Employees = Employee.Employees });
                listJourney.Add(new Journey() { JourneyNo = "JAA00906", JourneyDate = DateTime.Now.Date.AddDays(5).AddMonths(1).Date, Reg = "VT-IND", Color = Color.Blue, Employees = Employee.Employees});
                listJourney.Add(new Journey() { JourneyNo = "JAA00907", JourneyDate = DateTime.Now.Date.AddDays(6).AddMonths(1).Date, Reg = "VT-IND", Color = Color.Red, Employees = Employee.Employees });
                listJourney.Add(new Journey() { JourneyNo = "JAA00908", JourneyDate = DateTime.Now.Date.AddDays(7).AddMonths(1).Date, Reg = "VT-IND", Color = Color.Blue, Employees = Employee.Employees});
                listJourney.Add(new Journey() { JourneyNo = "JAA00909", JourneyDate = DateTime.Now.Date.AddDays(8).AddMonths(1).Date, Reg = "VT-IND", Color = Color.Red, Employees = Employee.Employees });
                listJourney.Add(new Journey() { JourneyNo = "JAA00910", JourneyDate = DateTime.Now.Date.AddDays(9).AddMonths(1).Date, Reg = "VT-IND", Color = Color.Blue, Employees = Employee.Employees});
                return listJourney;
            }
        }

        public string JourneyNo { get; set; }

        public DateTime JourneyDate { get; set; }

        public Color Color { get; set; }

        public string Reg { get; set; }

        public string Month
        {
            get
            {
                return JourneyDate.Date.Month.ToString();
            }
        }

        public List<Employee> Employees { get; set; }        
    }

    public class Employee
    {
        public static List<Employee> Employees
        {
            get
            {
                var list = new List<Employee>();
                list.Add(new Employee() { EmployeeName = "BAL - CAPTAIN" });
                list.Add(new Employee() { EmployeeName = "RAV - FIRSTOFFICER" });
                list.Add(new Employee() { EmployeeName = "PRD - ON" });
                list.Add(new Employee() { EmployeeName = "JEY - CA1" });
                list.Add(new Employee() { EmployeeName = "KAL - CA2" });
                list.Add(new Employee() { EmployeeName = "BJI - TRAINEE" });
                return list;
            }
        }

        public string EmployeeName { get; set; }
    }
}
