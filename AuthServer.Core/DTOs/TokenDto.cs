using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.DTOs
{
    public class TokenDto
    {
        public string AccessToken { get; set; }
        public DateTime AccessTokenExipration { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExipration { get; set; }
    }
}
