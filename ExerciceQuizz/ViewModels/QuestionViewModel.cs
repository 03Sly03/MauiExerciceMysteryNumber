using CommunityToolkit.Mvvm.ComponentModel;
using ExerciceQuizz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExerciceQuizz.ViewModels
{
    internal class QuestionViewModel : ObservableObject
    {
        private Question _theQuestion;
        private string _userAnswer;
        private Func<string, string, string, Task> alertAction;
        public ICommand CheckUserAnswerCommand { get; set; }
        public ICommand NavigateToNextQuestionCommand { get; set; }
        public bool IsGoodAnswer {get; set;}

        public string TheQuestion { get => _theQuestion.TheQuestion; }

        public string UserAnswer 
        {
            get => _userAnswer; set
            {
                _userAnswer = value;
            }
        }

        public QuestionViewModel(Func<string, string, string, Task> alertA)
        {
            _theQuestion = new Question("Quel film parle de Willy le borgne ?", "les goonies");
            CheckUserAnswerCommand = new Command(execute: () => CheckAnswer());
            alertAction = alertA;
        }

        private void RaisePropertyChanged(string propertyName)
        {
            //if (PropertyChanged != null)
            //    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            OnPropertyChanged(propertyName);
        }

        private void CheckAnswer()
        {
            if (_userAnswer == _theQuestion.Answer)
            {
                //IsGoodAnswer = true;
                alertAction("Bravo!", "Vous avez trouvé la bonne réponse", "Question suivante ->");
                NavigateToNextQuestionCommand = new Command(execute: () => Navigation.PushAsync(new Question2()));
                //RaisePropertyChanged("IsGoodAnswer");
            }   
            else
                alertAction("Dommage!", "Vous n'avez pas trouvé la bonne réponse", "Recommencer");
        }
    }
}
