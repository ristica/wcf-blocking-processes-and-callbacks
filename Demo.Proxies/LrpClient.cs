using Demo.Contracts;
using System.ServiceModel;

namespace Demo.Proxies
{
    public class LrpClient : ClientBase<ILrp>, ILrp
    {
        public void StartProcess()
        {
            Channel.StartProcess();
        }
    }
}
