using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ask.Entities
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string IdentityNo { get; set; }
        public Game FavGame { get; set; }
    }
}
