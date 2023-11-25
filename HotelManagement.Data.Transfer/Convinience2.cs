using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DTO
{
    public class Convinience2
    {
        private string id, name;

        public Convinience2()
        {
        }

        public Convinience2(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public Convinience2(Convinience2 convinience)
        {
            Id = convinience.Id;
            Name = convinience.Name;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
