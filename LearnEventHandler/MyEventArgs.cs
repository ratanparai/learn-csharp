using System;
using System.Collections.Generic;
using System.Text;

namespace LearnEventHandler
{
    class MyEventArgs : EventArgs
    {
        public string Message { get; set; }
        public string Name { get; set; }
    }
}
