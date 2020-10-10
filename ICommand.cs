namespace ha.sdk
{
    public interface ICommand
    { 
        IDevice Device { get; set; }
        int ExecutionOrder {get; set; }
        string CommandName { get; set; }
        string Parameters { get; set; }
    }
}
