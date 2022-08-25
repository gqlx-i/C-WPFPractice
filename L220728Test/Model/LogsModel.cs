using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L220728Test.Model
{
    public class LogsModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _time;
        private string _rank;
        private string _module;
        private string _message;
        private int _threadId;

        public string Time
        {
            get { return _time; }
            set
            {
                _time = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Time"));
                }
            }
        }
        public string Rank
        {
            get { return _rank; }
            set
            {
                _rank = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Rank"));
                }
            }
        }
        public string Module
        {
            get { return _module ; }
            set
            {
                _module = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Module"));
                }
            }
        }
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Message"));
                }
            }
        }
        public int ThreadId
        {
            get { return _threadId; }
            set
            {
                _threadId = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ThreadId"));
                }
            }
        }
    }
}
