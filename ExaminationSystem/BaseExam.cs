using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class BaseExam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public BaseQuestion[] ListOfQuestions { get; set; }

        public BaseExam(int _time,int _numofquestions)
        {
            Time = _time;
            NumberOfQuestions = _numofquestions;
        }
        public abstract void ShowExam();
        public abstract void CreateListOfQuestions();
    }
}
