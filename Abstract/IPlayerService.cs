using Ask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ask.Abstract
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Remove(Player player);
        void Update(int newId,Player player);
        void List();

    }
}
