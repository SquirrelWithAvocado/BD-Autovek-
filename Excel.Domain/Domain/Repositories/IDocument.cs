namespace Excel.Interfaces
{
    public interface IDocument
    {
        bool Open(string filePath);
        bool WriteTo();
        bool Save(string filePath);
    }
}