using System.Collections.Generic;

namespace ha.sdk.contracts
{
    public interface IScene
    {
        string Id { get; set; }

        string Name { get; set; }

        IEnumerable<ICommand> Commands { get;  }

    }
}
