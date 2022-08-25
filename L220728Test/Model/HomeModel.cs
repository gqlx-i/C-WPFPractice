using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace L220728Test.Model
{
    public class HomeModel : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _axisName = "1";

        //private List<string> _axisName = new List<string>();
        private List<string> _actionName = new List<string>();
        private List<double> _moveScale = new List<double>();
        private List<double> _rotateScale = new List<double>();

        public List<string> ActionName
        {
            get { return _actionName; }
            set
            {
                _actionName = value;
                if (PropertyChanged != null)
                {
                    _actionName = value;
                    this.PropertyChanged.Invoke(this,new PropertyChangedEventArgs("ActionName"));
                }
            }
        }
        public string AxisName
        {
            get { return _axisName; }
            set
            {
                _axisName = value;
                if (PropertyChanged != null)
                {
                    _axisName = value;
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("AxisName"));
                }
            }
        }
        //public List<string> ActionName
        //{
        //    get { return _actionName; }
        //    set
        //    {
        //        if (PropertyChanged != null)
        //        {
        //            _actionName = value;
        //            this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ActionName"));
        //        }
        //    }
        //}
        public List<double> MoveScale
        {
            get { return _moveScale; }
            set
            {
                _moveScale = value;
                if (PropertyChanged != null)
                {
                    _moveScale = value;
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("MoveScale"));
                }
            }
        }
        public List<double> RotateScale
        {
            get { return _rotateScale; }
            set
            {
                _rotateScale = value;
                if (PropertyChanged != null)
                {
                    _rotateScale = value;
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("RotateScale"));
                }
            }
        }
    }
}
