using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class ChooseOneQuestion : BaseQuestion
    {
        public override string Header => "Choose One Answer ";

        public ChooseOneQuestion()
        {
            AnswerList = new Answer[4];
        }

        public override void AddQuestion()
        {
            Console.WriteLine(Header);

            Console.WriteLine("Enter The Body of the Question");
            Body = Console.ReadLine();

            int mark;
            do
            {
                Console.Write("Enter the Mark of the Question: ");
            } while (!int.TryParse(Console.ReadLine(), out mark));
            Mark = mark;

            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine($"Enter {i+1} Answer");
                AnswerList[i] = new Answer();
                AnswerList[i].AnswerId = i+1;
                AnswerList[i].AnswerText = Console.ReadLine();
            }
            int RAnswer;
            do
            {
                Console.WriteLine("Enter The Right Answer of the Question (1|2|3|4)");
            } while (!int.TryParse(Console.ReadLine(), out RAnswer) && RAnswer < 1 || RAnswer > 3);
            RightAnswer.AnswerId = RAnswer;
            RightAnswer.AnswerText = AnswerList[RAnswer - 1].AnswerText;
        }
    }
}
