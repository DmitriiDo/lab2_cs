
namespace Lab2_3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter serial code for document worker");
            string? key = Console.ReadLine();
            Console.WriteLine("Key accepted");
            DocumentWorker worker = DocumentWorkerFactory.CreateDocumentWorker(key);
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }
}