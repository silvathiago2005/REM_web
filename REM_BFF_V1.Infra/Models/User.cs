using Microsoft.EntityFrameworkCore;

namespace REM_BFF_V1.Infra.Connections
{
    public class  User
    {
        public int Id { get; set; }

        public int Id_Profile { get; set; }

        public string Name { get;set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
