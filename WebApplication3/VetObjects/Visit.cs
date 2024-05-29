namespace WebApplication3.VetObjects
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime VisitDate { get; set; }

        public string RegistrationPerson { get; set; }
        
        public string CatName { get; set; }
        public int CatAge { get; set; }
        public string CatColor { get; set; }

        public bool Check()
        {
            return true;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
