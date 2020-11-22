using System.Collections.Generic;
using ha.sdk.contracts;

namespace ha.sdk
{
    public class Scene : IScene
    {
        public Scene()
        {
            Commands = new List<ICommand>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<ICommand> Commands {get; set;}
    }
}
