using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampClassLibrary1
{
    public class PeristaliticPump
    {
        private bool _isRunning;
        private int _rpm;
        public void Start() 
        {
            InternalStart();
            _isRunning = true;
        }
        public void Stop() 
        {
            InternalStop();
            _isRunning = false;
        }

        public bool IsRunning { get => _isRunning; }
        
        public int RPM { get=>_rpm;
            set
            {
                //TODO
            }
        }
        protected virtual void InternalStart()
        {
            //descendant should implement

        }
        protected virtual void InternalStop()
        {
            //descendant should implement
        }

    }
}
