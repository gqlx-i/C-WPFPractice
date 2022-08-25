using L220728Test.Event;
using L220728Test.Model;
using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace L220728Test.ViewModel
{
    public class AlarmViewModel : Conductor<Screen>
    {
        IEventAggregator _eventAggregator;
        IWindowManager _windowManager;

        public List<AlarmModel> CurrentAlarmList { get; set; } = new List<AlarmModel>()
        {
            new AlarmModel() { Id = 101, Type = "2", Time = "1234", Rank = "1",  Describe = "ascasas" },
            new AlarmModel() { Id = 102, Type = "1", Time = "1246", Rank = "1",  Describe = "ascasadavadcaca" },
            new AlarmModel() { Id = 103, Type = "4", Time = "1334", Rank = "2",  Describe = "bdbds" },
            new AlarmModel() { Id = 104, Type = "3", Time = "1434", Rank = "2",  Describe = "nhmgsas" },
            new AlarmModel() { Id = 107, Type = "2", Time = "453", Rank = "3", Describe = "ukyrkr" }
        };                              
        public List<AlarmModel> HistoryAlarmList { get; set; } = new List<AlarmModel>()
        {
            new AlarmModel() { Id = 101, Type = "2", Time = "1234", Rank = "1",  Describe = "ascasas" },
            new AlarmModel() { Id = 102, Type = "1", Time = "1246", Rank = "1",  Describe = "ascasadavadcaca" },
            new AlarmModel() { Id = 103, Type = "4", Time = "1334", Rank = "2",  Describe = "bdbds" },
            new AlarmModel() { Id = 104, Type = "3", Time = "1434", Rank = "2",  Describe = "nhmgsas" },
            new AlarmModel() { Id = 107, Type = "2", Time = "453", Rank = "3", Describe = "ukyrkr" }
        };

        public AlarmModel CurrentAlarm { get; set; } = new AlarmModel();
        public AlarmViewModel()
        {
            
        }
        public AlarmViewModel(IWindowManager windowManager, IEventAggregator eventAggregator)
        {
            _windowManager = windowManager;
            _eventAggregator = eventAggregator;
        }
        //日志按钮命令
        public void CmdLogs()
        {
            LogsEvent logsEvent = new LogsEvent();
            logsEvent.LogsState = "ok";
            _eventAggregator.Publish(logsEvent);
        }
        private void ToLogs(object obj)
        {
           
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
