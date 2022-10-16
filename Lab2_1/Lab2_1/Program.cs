
namespace Lab2_1
{
    public class Program
    {
        public static void Main()
        {
            ClassRoom c_room = new(new GoodPupil(), new BadPupil(), new ExcellentPupil());
            c_room.PrintClassRoom();
        }
    }
}