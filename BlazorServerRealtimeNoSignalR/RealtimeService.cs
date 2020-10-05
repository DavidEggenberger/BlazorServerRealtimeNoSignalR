using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerRealtimeNoSignalR
{
    public class RealtimeService
    {
        private int _a;
        public int a
        {
            get { return _a; }
            set 
            { 
                _a = value;
                UpdateEvent?.Invoke();
            }
        }
        private int _b;

        public int b
        {
            get { return _b; }
            set 
            { 
                _b = value;
                UpdateEvent?.Invoke();
            }
        }
        public event Func<Task> UpdateEvent;
    }
}
