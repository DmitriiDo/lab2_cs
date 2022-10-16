using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    // https://refactoring.guru/ru/design-patterns/factory-method/csharp/example
    public class DocumentWorkerFactory
    {
        private DocumentWorkerFactory() { }
        public static DocumentWorker CreateDocumentWorker(string? key = null)
        {
            switch(key)
            {
                case "pro":
                    Console.WriteLine("Created pro document worker");
                    return new ProDocumentWorker();
                case "expert":
                    Console.WriteLine("Created expert document worker");
                    return new ExpertDocumentWorker();
                default:
                    Console.WriteLine("Created free document worker");
                    return new DocumentWorker();
            }
        }
    }
}
