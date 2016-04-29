using System.ServiceModel;

namespace Demo.Contracts
{
    [ServiceContract]
    public interface IProcessCallback
    {
        [OperationContract]
        bool ReportBack(int nr);
    }
}
