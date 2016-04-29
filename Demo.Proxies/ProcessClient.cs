using Demo.Contracts;
using System.ServiceModel;
using System;

namespace Demo.Proxies
{
    public class ProcessClient : ClientBase<IProcess>, IProcess
    {
        public void StartProcess()
        {
            Channel.StartProcess();
        }
    }
}
