using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }
    
    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            // If you are actually doing this in real thing
            // you have a personal reserved place in hell

            Console.WriteLine("Документ сохранён в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }

    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранён в новом формате");
        }
    }
}

