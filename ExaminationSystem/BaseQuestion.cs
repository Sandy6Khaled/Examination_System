using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class BaseQuestion
    {
        public string Body { get; set; }
        public abstract string Header { get; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer UserAnswer { get; set; }
        public Answer RightAnswer { get; set; }

        public BaseQuestion()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }
        public abstract void AddQuestion();
        public override string ToString()
        {
            return $@"Header: {Header} Mark: {Mark}
---------------------------------------------
{Body}";
        }

    }
}
