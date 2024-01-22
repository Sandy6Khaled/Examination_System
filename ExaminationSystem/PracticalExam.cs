using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class PracticalExam : BaseExam
    {
        public PracticalExam(int _time, int _numofQ) : base(_time, _numofQ)
        {

        }
        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new BaseQuestion[NumberOfQuestions];
            for (int i = 0; i < ListOfQuestions?.Length; i++)
            {
                int choise;
                do
                {
                    Console.Write("Enter the type of Question (1 choose one | 2 for choose all ): ");
                } while (!int.TryParse(Console.ReadLine(), out choise) && choise < 1 || choise > 2);

                switch (choise)
                {
                    case 1:
                        ListOfQuestions[i] = new ChooseOneQuestion();
                        ListOfQuestions[i].AddQuestion();
                    break;
                    case 2:
                        ListOfQuestions[i] = new ChooseAllQuestion();
                        ListOfQuestions[i].AddQuestion();
                    break;
                }
            }
        }

        public override void ShowExam()
        {
            foreach (var Question in ListOfQuestions)
            {
                //Question
                Console.WriteLine(Question);
                //Answers Of Question
                for (int i = 0; i < Question.AnswerList?.Length; i++)
                    Console.WriteLine(Question.AnswerList[i]);
                Console.WriteLine("---------------------------------------");

                //User Answer
                int UserAnswerId;
                do
                {
                    Console.Write("Please Enter Number of your answer : ");
                } while (!int.TryParse(Console.ReadLine(), out UserAnswerId) && UserAnswerId < 1 || UserAnswerId > 4);

                Question.UserAnswer.AnswerId = UserAnswerId;
                Question.UserAnswer.AnswerText = Question.AnswerList[UserAnswerId - 1].AnswerText;
                Console.WriteLine("*********************************************************** \n");
            }

            Console.WriteLine("Right Answers: \n");
            for (int i = 0; i < ListOfQuestions?.Length; i++)
            {
                Console.WriteLine($"Question ({i + 1}) : {ListOfQuestions[i].Body}");
                Console.WriteLine($"Right Answer => {ListOfQuestions[i].RightAnswer.AnswerText}");
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
    }
}
