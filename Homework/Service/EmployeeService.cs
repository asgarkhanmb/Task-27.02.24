
//using Homework.Models;

//namespace Homework.Service
//{
//    internal class EmployeeService : Employee
//    {
//        public Employee[] GetAll()
//        {
//            Employee employe1 = new()
//            {
//                id = 1,
//                name = "Employe1",
//                surname = "Employev1",
//                address = "Baki1",
//                email = "tmploye1@gmail.com",
//                age = 18
//            };
//            Employee employe2 = new()
//            {
//                id = 2,
//                name = "Employe2",
//                surname = "Employev2",
//                address = "Baki2",
//                email = "tmploye1@gmail.com",
//                age = 19
//            };
//            Employee employe3 = new()
//            {
//                id = 3,
//                name = "Employe3",
//                surname = "Employev3",
//                address = "Baki3",
//                email = "employe3@gmail.com",
//                age = 21
//            };
//            Employee employe4 = new()
//            {
//                id = 4,
//                name = "Employe4",
//                surname = "Employev4",
//                address = "Baki4",
//                email = "tmploye4@gmail.com",
//                age = 26
//            };
//            Employee employe5 = new()
//            {
//                id = 5,
//                name = "Employe5",
//                surname = "Employev5",
//                address = "Baki5",
//                email = "employe5@gmail.com",
//                age = 35
//            };
//            Employee employe6 = new()
//            {
//                id = 6,
//                name = "Employe6",
//                surname = "Employev6",
//                address = "Baki6",
//                email = "employe6@gmail.com",
//                age = 40
//            };
//            Employee employe7 = new()
//            {
//                id = 7,
//                name = "Employe7",
//                surname = "Employev7",
//                address = "Baki7",
//                email = "employe7@gmail.com",
//                age = 55
//            };

//            Employee[] employers = { employe1, employe2, employe3, employe4, employe5, employe6, employe7 };
//            return employers;
//        }

//        public Employee[] GetAllByAge(Employee[] employees,int age )
//        {
//            return employees.Where(m => m.age>age).ToArray();
//        } 

//        public int GetCountByAge(Employee [] employees,int firstAge,int lastAge)
//        {
//            return employees.Where(m =>m.age>firstAge&& m.age<lastAge).Count(); 

//        }
//        public int SumOfAge(Employee[] employees)
//        {
//            return employees.Sum(m => m.age);   
//        }

//        public Employee[] GetAllByCheckedEmail(Employee [] employees,string str)
//        {
//            return employees.Where(m => m.email.StartsWith(str)).ToArray();
//        }
//    }

    
//}
