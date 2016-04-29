using System.ServiceModel;

namespace Demo.Contracts
{
    [ServiceContract(CallbackContract = typeof(IProcessCallback))]
    public interface IProcess
    {
        [OperationContract(IsOneWay = true)]
        void StartProcess();
    }
}
