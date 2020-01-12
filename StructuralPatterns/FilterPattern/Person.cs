namespace FilterPattern
{
    public class Person
    {
        private readonly string Name;
        private readonly string Gender;
        private readonly string MaritalStatus;
        public Person(string name, string gender, string maritalStatus)
        {
            Name = name;
            Gender = gender;
            MaritalStatus = maritalStatus;
        }

        public string GetName()
        {
            return Name;
        }
        public string GetGender()
        {
            return Gender;
        }
        public string GetMaritalStatus()
        {
            return MaritalStatus;
        }
    }
}
