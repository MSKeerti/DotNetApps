using System.ComponentModel.DataAnnotations;

namespace FirstApi.Models
{
    public class Person
    {
        [Required]
        public string Aadhar { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [Range(18, 110)]
        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
    public class PersonOperations
    {
        private static List<Person> _people = new List<Person>();
        public static List<Person> GetPeople()
        {
            if (_people.Count == 0)
            {
                _people.Add(new Person() { Aadhar = "AA12345678901A", Age = 25, Email = "meena@gmail.com", Name = "Meena" });
                _people.Add(new Person() { Aadhar = "BB12345678901B", Age = 24, Email = "eena@gmail.com", Name = "Eena" });
                _people.Add(new Person() { Aadhar = "CC12345678901C", Age = 27, Email = "reena@gmail.com", Name = "Reena" });
            }
            return _people;
        }

        public static Person Search(string pAadhar)
        {
            return GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
        }

        public static List<Person> PeopleofAge(int pstartAge, int pendAge)
        {
            return GetPeople().Where(p => p.Age >= pstartAge && p.Age <= pendAge).ToList();
        }

        public static void CreateNew(Person p)
        {
            GetPeople();
            _people.Add(p);
        }

        public static bool Update(string pAadhar, Person updatedPerson)
        {
           var found = GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
            if (found != null)
            {
                found.Email = updatedPerson.Email;
                found.Name = updatedPerson.Name;
                found.Age = updatedPerson.Age;
                return true;
            }
                
            else
                throw new Exception("No such record");
        }

        public static bool Delete(string pAadhar)
        {
            var found = GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
            if(found != null)
            {
                GetPeople().Remove(found);
                return true;
            }
            else
                throw new Exception("No such record");
        }
    }
}
