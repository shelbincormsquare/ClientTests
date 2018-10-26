using Caliburn.Micro;

namespace TopLayer.ViewModels
{
    public class ShellViewModel : PropertyChangedBase
    {
        private string _numberOne;

        public string NumberOne
        {
            get { return _numberOne; }
            set { _numberOne = value; }
        }

        private string _numberTwo;

        public string NumberTwo
        {
            get { return _numberTwo; }
            set { _numberTwo = value; }
        }

        private string _result;

        public string Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public void Add(string numberOne, string numberTwo)
        {
            Result = numberOne + " " + NumberTwo;
        }

        public ShellViewModel()
        {
            NumberOne = "Number1";
            NumberTwo = "Number2";
            Result = "Hello World";
        }
        //private string _message;

        //public string Message
        //{
        //    get { return _message; }
        //    set
        //    {
        //        _message = value;
        //        NotifyOfPropertyChange(() => Message);
        //        NotifyOfPropertyChange(() => CanChangeMessage);
        //    }
        //}

        //public bool CanChangeMessage
        //{
        //    get { return _pressCount < 10; }
        //}

        //private int _pressCount;

        //public ShellViewModel()
        //{
        //    Message = "Hello World";
        //    _pressCount = 0;
        //}

        //public void ChangeMessage()
        //{
        //    _pressCount++;

        //    Message = "Presses = " + _pressCount;
        //}
    }
}
