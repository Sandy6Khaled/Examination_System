using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class TFQuestion : BaseQuestion
    {
        public override string Header => "True or False Question ";

        public TFQuestion()
        {
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1,"True");
            AnswerList[1] = new Answer(2,"False");
        }
        public override void AddQuestion()
        {
            Console.WriteLine(Header);

            Console.WriteLine("Enter The Body Of the Question");
            Body = Console.ReadLine();
            int mark;
            do
            {
                Console.Write("Enter the Mark of the Question: ");
            } while (!int.TryParse(Console.ReadLine(), out mark));
            Mark = mark;
            int RAnswer;
            do
            {
                Console.WriteLine("Enter The Right Answer of the Question (1 for True)/(2 for False)");
            } while (!int.TryParse(Console.ReadLine(), out RAnswer) && RAnswer < 1 || RAnswer > 2);
            RightAnswer.AnswerId = RAnswer;
            RightAnswer.AnswerText = AnswerList[RAnswer - 1].AnswerText;
        }
    }
}
