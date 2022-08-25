using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stylet;
using L220728Test.Event;
using L220728Test.Model;
using System.Windows.Input;

namespace L220728Test.ViewModel
{
    public class LoginViewModel : Screen
    {
        public ICommand ToLoginCmd { get; set; }
        //Command="{Binding ToLoginCmd}"
        /// <summary>
        /// 登陆模型
        /// </summary>
        public TestPublish<LoginEvent> Test;
        public LoginModel LoginModel { get; set; } = new LoginModel();

        IEventAggregator _eventAggregator;
        IWindowManager _windowManager;

        public List<string> UserList { get; set; } = new List<string>() { "管理员", "工程师", "调试员" };
        public LoginModel SelectUser { get; set; } = new LoginModel() { UserName = "管理员"};

        Dictionary<string, string> usersInfo = new Dictionary<string, string>()
        {
            { "管理员", "000" },
            { "工程师", "111" },
            { "调试员", "222" }
        };
        //private List<LoginModel> loginInfo { get; set; } = new List<LoginModel>()
        //{
        //    new LoginModel(){ UserName = "管理员", PassWord = "000"},
        //    new LoginModel(){ UserName = "调试员", PassWord = "111"},
        //    new LoginModel(){ UserName = "工程师", PassWord = "222"}
        //};
        public LoginViewModel(IWindowManager windowManager, IEventAggregator eventAggregator)
        {
            _windowManager = windowManager;
            _eventAggregator = eventAggregator;
            ToLoginCmd = new DelegateCommand(CmdLogin);
        }
        /// <summary>
        ///登录命令 
        /// </summary>
        public void CmdLogin(object obj)
        {
            if (string.IsNullOrEmpty(SelectUser.PassWord))
            {
                _windowManager.ShowMessageBox("密码不能为空！");
                return;
            }
            if (SelectUser.PassWord != usersInfo[SelectUser.UserName])
            {
                _windowManager.ShowMessageBox("密码错误!");
            }
            else
            {
                //发布
                LoginEvent loginEvent = new LoginEvent();
                loginEvent.LoginState = "ok";
                //Test(loginEvent);
                _eventAggregator.Publish(loginEvent);
            }
        }
        private void PublishEvent(LoginEvent loginEvent)
        {
            _eventAggregator.Publish(loginEvent);
        }
        /// <summary>
        /// 关闭命令
        /// </summary>
        public void CmdClose()
        {
            App.Current.Shutdown();
        }
        #region Command
        public class DelegateCommand : ICommand
        {
            public DelegateCommand(Action<object> execute) : this(execute, null)
            {

            }

            public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
            {
                if (execute == null)
                {
                    throw new ArgumentNullException("execute");
                }
                this._execute = execute;
                this._canExecute = canExecute;
            }

            public bool CanExecute(object parameter)
            {
                return this._canExecute == null || this._canExecute(parameter);
            }

            public event EventHandler CanExecuteChanged;
            public void RaiseCanExecuteChanged()
            {
                if (this.CanExecuteChanged != null)
                {
                    this.CanExecuteChanged(this, EventArgs.Empty);
                }
            }

            public void Execute(object parameter)
            {
                this._execute(parameter);
            }

            private readonly Action<object> _execute;

            private readonly Predicate<object> _canExecute;
        }
        #endregion
    }
}
