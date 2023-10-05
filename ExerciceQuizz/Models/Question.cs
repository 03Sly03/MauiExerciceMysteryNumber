using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceQuizz.Models
{
    internal class Question
    {
        private string _theQuestion;
        private string _answer;
        private List<string> _hints = new List<string>();

        public string TheQuestion { get => _theQuestion; set => _theQuestion = value; }
        public string Answer { get => _answer; set => _answer = value; }
        public List<string> Hints { get => _hints; set => _hints = value; }

        public Question(string question, string answer )
        {
            TheQuestion = question;
            Answer = answer;
        }
    }
}
