using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class ClassRoom
    {
        private const int kPupilsCount = 4;
        private Pupil?[] pupils;

        public ClassRoom(Pupil first, Pupil second, Pupil? third = null, Pupil? fourth = null)
        {
            pupils = new Pupil[kPupilsCount];
            pupils[0] = first;
            pupils[1] = second;
            pupils[2] = third;
            pupils[3] = fourth;
        }

        public void PrintClassRoom()
        {
            for(int i = 0; i < pupils.Length; i++)
            {
                Pupil? p = pupils[i];
                if (p is not null)
                {
                    Console.WriteLine("Pupil " + i.ToString());
                    p.Study();
                    p.Read();
                    p.Write();
                    p.Relax();
                    Console.WriteLine();
                }
            }
        }
    }


}
