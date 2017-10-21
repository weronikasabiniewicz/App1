using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1
{
    public class Class1 : INotifyPropertyChanged
    {
        private string _testText; 
        public string Testtext
        {
            get { return _testText; }
            set
            {
                if (_testText != value)
                {
                    _testText = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _testText2;
        public string Testtext2
        {
            get { return _testText2; }
            set
            {
                if (_testText2 != value)
                {
                    _testText2 = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Command Entry_OnCompleted
        {
            get { return new Command(() =>  Testtext2 = Testtext.ToUpper()); }
           
        }
    }
}
