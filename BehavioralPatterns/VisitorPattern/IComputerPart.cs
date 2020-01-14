namespace VisitorPattern
{
    public interface IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
