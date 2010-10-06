using System;
using System.Collections.Generic;
using System.Threading;

namespace Serra.Micros.MVP.Infra
{
    /// <summary>
    /// Executes actions with a (hard-coded) delay of 1 second.
    /// </summary>
    /// <remarks>
    /// Quick&dirty busy-waiting implementation.
    /// </remarks>
    public class SecondDelayQueuedCommandManager : ICommandManager
    {
        private readonly object _lock = new object();
        private readonly Queue<Action> _q = new Queue<Action>();
        private bool _run;

        protected int PollInterval { get; private set; }

        public void Post(Action action)
        {
            _q.Enqueue(action);
        }

        public void Start()
        {
            if (_run)
                return;
            _run = true;
            var t = new Thread(Run) {Name = "Command Manager's workerthread."};
            t.Start();
        }

        public void Stop()
        {
            _run = false;
        }

        private void Run()
        {
            while (_run)
            {
                if (_q.Count > 0)
                    Process(_q.Dequeue());
                Thread.Sleep(50);
            }
        }

        private void Process(Action action)
        {
            Thread.Sleep(GetWaitInterval());
            action.Invoke();
        }

        private static int GetWaitInterval()
        {
            return 1000;
        }
    }
}