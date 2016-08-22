using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteXMLtoDB
{
    public class Pet
    {
        public int animalid { get; set; }
        public string shelterid { get; set; }
        public string shelterpetid { get; set; }
        public string name { get; set; }
        public string animal { get; set; }
        public List<Breed> breeds { get; set; }
        public string mix { get; set; }
        public string age { get; set; }
        public string sex { get; set; }
        public string size { get; set; }
        public List<Options> options { get; set; }
        public string description { get; set; }
        public DateTime lastUpdate { get; set; }
        public string status { get; set; }
        public string media { get; set; }
        public Contact contact { get; set; }
    }
}
