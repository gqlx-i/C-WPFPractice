using L220728Test.Event;
using L220728Test.Model;
using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L220728Test.ViewModel
{
    public class LogsViewModel : Conductor<Screen>
    {
        IEventAggregator _eventAggregator;
        IWindowManager _windowManager;

        public List<LogsModel> CurrentLogsList { get; set; } = new List<LogsModel>()
        {
            new LogsModel() { Time = "1234", Rank = "1", Module = "2", Message = "ascasas", ThreadId = 101 },
            new LogsModel() { Time = "1246", Rank = "1", Module = "1", Message = "ascasadavadcaca", ThreadId = 102 },
            new LogsModel() { Time = "1334", Rank = "2", Module = "4", Message = "bdbds", ThreadId = 103 },
            new LogsModel() { Time = "1434", Rank = "2", Module = "3", Message = "nhmgsas", ThreadId = 104 },
            new LogsModel() { Time = "453", Rank = "3", Module = "2", Message = "ukyrkr", ThreadId = 107 }
        };
        public List<LogsModel> HistoryLogsList { get; set; } = new List<LogsModel>()
        {
            new LogsModel() { Time = "1234", Rank = "1", Module = "2", Message = "ascasas", ThreadId = 101 },
            new LogsModel() { Time = "1246", Rank = "1", Module = "1", Message = "ascasadavadcaca", ThreadId = 102 },
            new LogsModel() { Time = "1334", Rank = "2", Module = "4", Message = "bdbds", ThreadId = 103 },
            new LogsModel() { Time = "1434", Rank = "2", Module = "3", Message = "nhmgsas", ThreadId = 104 },
            new LogsModel() { Time = "453", Rank = "3", Module = "2", Message = "ukyrkr", ThreadId = 107 }
        };

        public LogsModel CurrentLogs { get; set; } = new LogsModel(); 
        public LogsViewModel()
        {

        }
        public LogsViewModel(IWindowManager windowManager, IEventAggregator eventAggregator)
        {
            _windowManager = windowManager;
            _eventAggregator = eventAggregator;
        }
        //报警按钮命令
        public void CmdAlarm()
        {
            //报警页面初始化
            AlarmEvent alarmEvent = new AlarmEvent();
            alarmEvent.AlarmState = "ok";
            _eventAggregator.Publish(alarmEvent);
        }
    }
}
