namespace NullObjectPattern
{
    public class RealCustomer : AbstractCustomer
    {

        public RealCustomer(string name) 
        {
            Name = name;
        }
        public override string GetName()
        {
            return Name;
        }

        public override bool IsNil()
        {
            return false;
        }
    }
}
