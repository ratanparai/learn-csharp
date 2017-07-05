using System;
using System.Collections.Generic;
using System.Text;

namespace LearnEventHandler
{
    class MyClass
    {
        public event EventHandler OnComplete;

        public void DoSomeWork()
        {
            // sample data
            MyEventArgs myEventArgs = new MyEventArgs();
            myEventArgs.Message = "This is done";

            OnComplete(this, myEventArgs);
        }
    }
}
