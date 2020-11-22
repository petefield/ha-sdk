using ha.sdk.contracts;

namespace ha.sdk
{
    public class Command : ICommand
    {
        public IDevice Device { get; set; }
        public string CommandName { get; set; }
        public string Parameters { get; set; }
        public int ExecutionOrder { get; set; }
    }
}
