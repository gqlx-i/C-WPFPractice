using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stylet;
using L220728Test.Event;

namespace L220728Test.ViewModel
{
    public delegate void TestPublish<T>(T Event);
    public class ShellViewModel : Conductor<Screen>, IHandle<LoginEvent>, IHandle<LogsEvent>, IHandle<AlarmEvent>
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

        private Screen _viewModelBase;

        //订阅
        //public ShellViewModel(IEventAggregator eventAggregator, LoginViewModel loginViewModel, IWindowManager windowManager)
        //{
        //    ActiveItem = loginViewModel;

        //    this.eventAggregator = eventAggregator;
        //    this.windowManager = windowManager;

        //    eventAggregator.Subscribe(this);
        //    //ActivateItem(loginViewModel);
        //}
        private AlarmViewModel _alarmVM;
        private LogsViewModel _logsVM;
        private HomeViewModel _homeVM;
        private BoxViewModel _boxVM;
        public ShellViewModel(IEventAggregator eventAggregator, LoginViewModel loginViewModel, AlarmViewModel alarmViewModel, LogsViewModel logsViewModel, HomeViewModel homeViewModel, BoxViewModel boxViewModel)
        {
            ActiveItem = loginViewModel;
            _alarmVM = alarmViewModel;
            _logsVM = logsViewModel;
            _homeVM = homeViewModel;
            _boxVM = boxViewModel;
            eventAggregator.Subscribe(this);
            //loginViewModel.Test = Handle;
            ActivateItem(ActiveItem);
        }
        /// <summary>
        /// 接收事件
        /// </summary>
        /// <param name="message"></param>
        public void Handle(LoginEvent message)
        {
            if (message.LoginState == "ok")
            {
                ViewModelBase = _boxVM;
                ActivateItem(ViewModelBase);
            }
        }
        public void Handle(AlarmEvent message)
        {
            if (message.AlarmState == "ok")
            {
                ViewModelBase = _alarmVM;
                ActivateItem(ViewModelBase);
            }
        }
        public void Handle(LogsEvent message)
        {
            if (message.LogsState == "ok")
            {
                ViewModelBase = _logsVM;
                ActivateItem(ViewModelBase);
            }
        }
    }
}
