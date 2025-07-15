namespace SOLID_Principle.ISP.Violation_of_ISP
{
    public interface IPrinter
    {
        void Print(string document);
        void Scan(string document);
        void Fax(string document);
    }
}
