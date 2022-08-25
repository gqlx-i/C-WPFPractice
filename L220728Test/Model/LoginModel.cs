using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stylet;

namespace L220728Test.Model
{
    public class LoginModel : PropertyChangedBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _userName;
        private string _passWord;
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("UserName"));
                }
            }
        }
        public string PassWord
        {
            get { return _passWord; }
            set
            {
                _passWord = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("PassWord"));
                }
            }
        }
    }
}
