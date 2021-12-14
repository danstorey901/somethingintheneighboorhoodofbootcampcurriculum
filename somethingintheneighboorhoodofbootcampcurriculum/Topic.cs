using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somethingintheneighboorhoodofbootcampcurriculum
{
    class Topic
    {
        private int NextId { get; set; } = 13;

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Difficulty { get; set; }

        public void Print() {
            Console.WriteLine($" {Id} | {Name} | {Category} | {Difficulty} ");
        }

        public Topic() {
            this.Id = NextId;
            NextId = NextId + 17;
        }
            //this.Id = Id;
            //this.Name = Name;
            //this.Category = Category;
            //this.Difficulty = Difficulty;
    }
}
