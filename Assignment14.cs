using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanKumarcl_Assignments_Fai
{
    class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long PhoneNo { get; set; }
        public int BillAmount { get; set; }
    }
    class Assignment14
    {
        [STAThread]
        static void Main(string[] args)
        {
            bool state = true;
            string menu = "Press 1 to ENter the Patient Data or 2 to Display";
            do
            {
                string choice = UiConsole.GetString(menu);
                if (choice == "1")
                {
                    WritePatientDetails();
                }
                else if(choice == "2")
                {
                    List<Patient> pat = new List<Patient>();
                    pat = GetAllPatients();
                    foreach (var item in pat)
                    {
                        Console.WriteLine($"{item.Id},{item.Name},{item.PhoneNo},{item.BillAmount}");
                    }
                }else
                {
                    state = false;
                }
            } while (state);
           
        }

        public static void WritePatientDetails()
        {
            Patient patient = new Patient();
            patient.Id = UiConsole.GetNumber("Enter the Patient ID");
            patient.Name = UiConsole.GetString("Enter the Patient Name");
            patient.PhoneNo = UiConsole.GetLong("Enter the Phone Number");
            patient.BillAmount = UiConsole.GetNumber("Enter the Bill Amount");
            string content = $"{patient.Id},{patient.Name},{patient.PhoneNo},{patient.BillAmount}";
            File.AppendAllText("Patient.csv", content);
            Console.WriteLine("Patient Data has been Entered");
        }

        public static List<Patient> GetAllPatients()
        {
            List<Patient> patient = new List<Patient>();
            var lines = File.ReadAllLines("Patient.csv");
            foreach(var line in lines)
            {
                var parts = line.Split(',');
                var pat = new Patient();
                pat.Id = int.Parse(parts[0]);
                pat.Name = parts[1];
                pat.PhoneNo = long.Parse(parts[2]);
                pat.BillAmount = int.Parse(parts[3]);

                patient.Add(pat);
                
            }
            return patient;
        }
    }
}
