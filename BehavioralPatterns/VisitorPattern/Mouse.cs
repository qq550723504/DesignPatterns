namespace VisitorPattern
{
    public class Mouse : IComputerPart
    {
        public virtual void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
