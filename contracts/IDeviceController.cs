using System.Threading.Tasks;

namespace ha.sdk
{
    public interface IDeviceController
    {
        Task ExecuteCommand(ICommand command);
    }
}
