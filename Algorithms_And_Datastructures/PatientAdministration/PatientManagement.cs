using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.PatientAdministration
{
    public class PatientManagement
    {
        // collection of patients
        private IDictionary<Patient, MedicalRecord> patients = new SortedDictionary<Patient, MedicalRecord>();
        private SortedSet<Patient> sortedPatients = new SortedSet<Patient>();

        public MedicalRecord FindMedicalRecord(Patient patient)
        {
            return patients[patient];
        }

        public SortedSet<Patient> FindPatients(int minAge, int maxAge)
        {
            SortedSet<Patient> patients = new SortedSet<Patient>();
            foreach (var item in sortedPatients)
            {
                if (item.Age >= minAge && item.Age <= maxAge) patients.Add(item);
            }
            return patients;
        }
    }
}
