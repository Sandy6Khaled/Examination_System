using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class ChooseAllQuestion : ChooseOneQuestion
    {
        public override string Header => "Choose one or More ";

        public ChooseAllQuestion()
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

                AnswerList[i] = new Answer();
                if (i == AnswerList.Length - 1)
                {
                    AnswerList[i].AnswerId = 4;
                    AnswerList[i].AnswerText = "All the Above";
                }
                else
                {
                    AnswerList[i].AnswerId = i + 1;
                    Console.WriteLine($"Enter {i + 1} Answer");
                    AnswerList[i].AnswerText = Console.ReadLine();
                }
            }

            RightAnswer.AnswerId = 4;
            RightAnswer.AnswerText = AnswerList[4 - 1].AnswerText;
        }
    }
}
