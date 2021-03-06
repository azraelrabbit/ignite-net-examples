﻿using Apache.Ignite.Core.Interop;

namespace IgnitePlugin
{
    internal class Semaphore
    {
        private readonly IPlatformTarget _target;

        public Semaphore(IPlatformTarget target)
        {
            _target = target;
        }

        public void WaitOne()
        {
            _target.InLongOutLong(0, 0);
        }

        public void Release()
        {
            _target.InLongOutLong(1, 0);
        }
    }
}
