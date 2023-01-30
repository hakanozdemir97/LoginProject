using LoginProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Entities.Concrete
{
    public class Movie:IEntity
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Poster { get; set; }
        public decimal Imdb { get; set; }
    }
}
