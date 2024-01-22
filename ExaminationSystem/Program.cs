using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int subId;
            do
            {
                Console.Write("Enter the Id of the Subject: ");
            } while (!int.TryParse(Console.ReadLine(), out subId));
            Console.Write("Enter the Name of the Subject: ");
            string subName = Console.ReadLine();
            Subject Sub = new Subject(subId, subName);
            Sub.CreateExam();
            char choise;
            do
            {

                Console.Write("Do You Want To Start Exam ( y | n ) : ");
            } while (!char.TryParse(Console.ReadLine(), out choise));

            if (choise == 'y' || choise == 'Y')
            {
                Console.Clear();
                Stopwatch sw = new();
                sw.Start();
                Sub.SubjectExam.ShowExam();
                Console.WriteLine($"\nThe Elapsed Time = {sw.Elapsed}");
            }
            else
                Console.WriteLine("Thank You");
        }
    }
}
