using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L220728Test.Model
{
    public class AlarmModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _id;
        private string _type;
        private string _rank;
        private string _time;
        private string _describe;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Id"));
                }
            }
        }
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Type"));
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
        public string Describe
        {
            get { return _describe; }
            set
            {
                _describe = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Describe"));
                }
            }
        }
    }
}
