using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    public class Pupil
    {
        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
    }

    public class ExcellentPupil : Pupil
    {
        public override void Study() {
            Console.WriteLine("Pupil studies excellent");
        }
        public override void Read()
        {
            Console.WriteLine("Pupil reads technical literature");
        }
        public override void Write() {
            Console.WriteLine("Pupil writes good essays");
        }
        public override void Relax() {
            Console.WriteLine("Pupil walks out to relax");
        }
    }
    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Pupil studies good");
        }
        public override void Read()
        {
            Console.WriteLine("Pupil reads technical literature and science fiction");
        }
        public override void Write()
        {
            Console.WriteLine("Pupil writes good essays");
        }
        public override void Relax()
        {
            Console.WriteLine("Pupil plays DOTA and walks out to relax");
        }
    }
    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Pupil studies bad");
        }
        public override void Read()
        {
            Console.WriteLine("Pupil isn`t interested in any literature");
        }
        public override void Write()
        {
            Console.WriteLine("Pupil isn`t good at writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Pupil walks out to relax");
        }
    }
}
