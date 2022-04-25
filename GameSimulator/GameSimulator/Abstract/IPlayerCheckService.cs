using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Abstract
{
    internal interface IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player);
    }
}
