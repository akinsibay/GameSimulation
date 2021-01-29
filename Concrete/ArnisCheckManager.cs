using Ask.Abstract;
using Ask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ask.Concrete
{
    public class ArnisCheckManager : IValidationService
    {
        public bool Validate(Player player)
        {
            if (player.IdentityNo == "12345678")
            {
                return true;
            }
            return false;
        }
    }
}
