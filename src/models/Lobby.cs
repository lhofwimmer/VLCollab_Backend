using System.Collections.Generic;

namespace vlcollab_server.models
{
    public class Lobby
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}