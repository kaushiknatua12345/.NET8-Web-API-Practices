using HandsOn_.NET8APIWithUnitTesting.Models;

namespace HandsOn_.NET8APIWithUnitTesting.Repository
{
    public class PatientRepository:IPatientRepository
    {
        private readonly static List<PatientModel> patients;

        static PatientRepository()
        {
            patients = new List<PatientModel>()
            {
                new PatientModel() { PatientId = 1, PatientName = "Kaushik", Age = 37, Email = "kaushik@gmail.com", MobileNumber = 9600197755, DiseaseName = "Fever" },
                new PatientModel() { PatientId = 2, PatientName = "Rajdip", Age = 40, Email = "raj@gmail.com", MobileNumber = 7606197755, DiseaseName = "Leg Pain" }
            };
        }


        //implement all methods
        public PatientModel AddPatient(PatientModel patient)
        {
            //Write your code here
            
        }        

        public IEnumerable<PatientModel> GetAllPatients()
        {
            //Write your code here
        }

        public PatientModel? GetPatientById(int id)
        {
            //Write your code here
        }

        public PatientModel? UpdatePatient(PatientModel patient, int id)
        {
            //Write your code here
        }

        public bool DeletePatient(int id)
        {
            //Write your code here
        }

    }
}
