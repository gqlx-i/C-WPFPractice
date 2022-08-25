using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L220728Test
{
    public class StudentModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string _name = "qwq";
        public string _sex = "m";
        public int _age = 18;
        public string _addr = "xian";
        public string _num = "11111";

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        public string Sex
        {
            get { return _sex; }
            set
            {
                _sex = value;
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Sex"));
                }
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Age"));
                }
            }
        }
        public string Addr
        {
            get { return _addr; }
            set
            {
                _addr = value;
                if (this.PropertyChanged != null)
                {
                    //this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Addr"));
                }
            }
        }
        public string Num
        {
            get { return _num; }
            set
            {
                _num = value;
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Num"));
                }
            }
        }
    }
}
