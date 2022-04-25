using GameSimulator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Entities
{
    class Player : IEntity
    {
        public Player(int Id, string TcNumber, string Name, string Surname, int YearOfBirth)
        {
            this.Id = Id;
            this.TcNumber = TcNumber;
            this.Name = Name;
            this.Surname = Surname;
            this.YearOfBirth = YearOfBirth;
        }

        public int Id { get; set; }
        public string TcNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int YearOfBirth { get; set; }
    }
}
