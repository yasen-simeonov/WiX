using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace DevSoftWinService
{
    public partial class ScheduledTaskService : ServiceBase
    {
        private readonly Object _lock = new Object();
        private readonly Timer _timer;
        private readonly Stopwatch _stopwatch;
        private readonly string _logPath;
        private bool _started;

        // 1 minute tick interval
        private const int TickInterval = 60000;

        private void Log(string text)
        {
            lock (_lock)
            {
                File.AppendAllText(_logPath, String.Format("{0} | Test Service | {1}{2}", DateTime.Now, text, Environment.NewLine));
            }
        }

        public void Tick(Object state)
        {
            _stopwatch.Restart();

            // do your service processing here:

            // write log entry to log file
            Log("Tick");

            // when stopped don't trigger next tick interval
            if (_started)
            {
                _timer.Change(Math.Max(0, TickInterval - _stopwatch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }

        public ScheduledTaskService()
        {
            InitializeComponent();
            _timer = new Timer(Tick);
            _stopwatch = new Stopwatch();
            _logPath = String.Format(@"{0}\log.txt", AppDomain.CurrentDomain.BaseDirectory);
        }

        protected override void OnStart(string[] args)
        {
            _started = true;

            // trigger timer to run first log now
            _timer.Change(0, Timeout.Infinite);

            // stopwatch is used to calculate how much time to take off the next tick interval
            // this is useful for long running processes when you need an exact tick time
            _stopwatch.Restart();

            Log("OnStart");
        }

        protected override void OnStop()
        {
            _started = false;

            Log("OnStop");
        }
    }
}
