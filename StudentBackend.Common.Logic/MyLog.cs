using StudentBackend.Common.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentBackend.Common.Logic
{
    public class MyLog : IMyLog
    {
        public void Debug(object message)
        {
            return;
        }

        public void Error(object message)
        {
            return;
        }

        public void Error(Exception ex)
        {
            return;
        }

        public void Fatal(object message)
        {
            return;
        }

        public void Info(object message)
        {
            return;
        }

        public void Init(Type declaringType)
        {
            return;
        }

        public void Warn(object message)
        {
            return;
        }
    }
}
