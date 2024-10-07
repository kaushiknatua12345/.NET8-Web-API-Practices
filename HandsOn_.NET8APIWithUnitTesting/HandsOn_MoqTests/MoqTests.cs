using HandsOn_.NET8APIWithUnitTesting.Models;
using HandsOn_.NET8APIWithUnitTesting.Repository;
using Moq;

namespace HandsOn_MoqTests
{
    public class MoqTests
    {
        private readonly Mock<IPatientRepository> _mockRepository;

        public MoqTests()
        {
            _mockRepository = new Mock<IPatientRepository>();
        }

        //write moq test for GetAllPatients method  
        [Test]
        public void GetAllPatientsTest()
        {
            //Arrange
            _mockRepository.Setup(p => p.GetAllPatients()).Returns(new List<PatientModel>()
            {
                new PatientModel() { PatientId = 1001, PatientName = "Sam", Age = 39, Email = "sam@gmail.com", MobileNumber = 9600197755, DiseaseName = "Fever" },
                new PatientModel() { PatientId = 1002, PatientName = "Peter", Age = 40, Email = "peter@yahoo.in", MobileNumber = 7606197758, DiseaseName = "Leg Pain" }
            });
            var result = _mockRepository.Object;

            //Act
            var patients = result.GetAllPatients();

            //Assert
            Assert.That(2, Is.EqualTo(patients.Count()));
            }


        //write moq test for GetPatientById method
        [Test]
        public void GetPatientByIdTest()
        {
            //Write your code here

        }

         //write moq test for AddPatient method
         [Test]
         public void AddPatientTest()
         {
                //Write your code here

         }

        //write moq test for UpdatePatient method
        [Test]
        public void UpdatePatientTest()
        {
            //Write your code here

        }

            //write moq test for DeletePatient method
            [Test]
            public void DeletePatientTest()
            {
               //Write your code here

            }


        }
}