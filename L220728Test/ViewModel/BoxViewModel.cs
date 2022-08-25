using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stylet;

namespace L220728Test.ViewModel
{
    
    public class BoxViewModel : Screen
    {
        public Screen ViewModelBase
        {
            get => _viewModelBase;
            set
            {
                _viewModelBase = value;
                OnPropertyChanged(nameof(ViewModelBase));
            }
        }

        private Screen _viewModelBase = new HomeViewModel();

        public void CmdAlarm()
        {
            //报警页面初始化
            AlarmViewModel alarmVM = new AlarmViewModel();
            ViewModelBase = alarmVM;
        }
        public void CmdLogs()
        {
            //日志页面初始化
            LogsViewModel logsVM = new LogsViewModel();
            ViewModelBase = logsVM;
        }
        public void CmdHome()
        {
            HomeViewModel homeVM = new HomeViewModel();
            ViewModelBase = homeVM;
        }
    }
}
