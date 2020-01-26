using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace AtlantaCodeCampMobile.Helpers
{
    public class BackgroundTaskHelper
    {
        private readonly Func<Task> _taskFactory; 
        
        private Task _backgroundTask;
        private CancellationTokenSource _cancellationTokenSource;

        public BackgroundTaskHelper(Func<Task> taskFactory)
        {
            _taskFactory = taskFactory;
        }

        public Task StartBackgroundTask()
        {
            if (!BackgroundTaskIsCompleted())
            {
                throw new InvalidAsynchronousStateException("Background task is currently executing. " +
                                                            "Cancel or wait for task completion");
            }
            _cancellationTokenSource = new CancellationTokenSource();
            _backgroundTask = _taskFactory.Invoke();
            return _backgroundTask;
        }

        public bool BackgroundTaskIsCompleted()
        {
            return _backgroundTask == null || _backgroundTask.IsCompleted;
        }

        public void Cancel()
        {
            _cancellationTokenSource?.Cancel();
        }
    }
}