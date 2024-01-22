using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answer(int _ID,string _Answer)
        {
            AnswerId = _ID;
            AnswerText = _Answer;
        }
        public Answer() { }
        public override string ToString()
        {
            return $"{AnswerId} - {AnswerText}\n";
        }
    }
}
