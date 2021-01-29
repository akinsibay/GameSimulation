using Ask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ask.Abstract
{
    public interface IValidationService
    {
        bool Validate(Player player);
    }
}
