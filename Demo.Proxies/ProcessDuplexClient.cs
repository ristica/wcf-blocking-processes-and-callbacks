using Demo.Contracts;
using System.ServiceModel;

namespace Demo.Proxies
{
    public class ProcessDuplexClient : DuplexClientBase<IProcess>, IProcess
    {
        public ProcessDuplexClient(InstanceContext callback)
            : base(callback)
        { }

        public void StartProcess()
        {
            Channel.StartProcess();
        }
    }
}
