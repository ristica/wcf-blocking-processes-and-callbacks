using System.ServiceModel;

namespace Demo.Contracts
{
    [ServiceContract]
    public interface ILrp
    {
        [OperationContract(IsOneWay = true)]
        void StartProcess();
    }
}
