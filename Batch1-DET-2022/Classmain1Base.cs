using Batch1_DET_2022;

namespace ParamsDemo
{
    public class Classmain1Base
    {

        public void Main()
        {
            Science Student = new Science { regno = 12, Name = "vinay" };
            Science sciencesubject = new Science { physics = 54, chemistry = 75, maths = 45 };
            CommerceStudent Commercessubject = new CommerceStudent { economices = 44, accounts = 82, banking = 44 };

            Console.WriteLine(sciencesubject.GetAvgMarks());
            Console.WriteLine(Commercessubject.GetAvgMarks());
        }
    }
}