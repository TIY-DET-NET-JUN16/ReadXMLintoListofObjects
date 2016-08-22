using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WriteXMLtoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var pets = XDocument
                .Load("michigandog_0001-1000.xml")
                .Root.Elements().Elements("pet")
                .Select(p => new Pet
                {
                    animalid = (int)p.Element("animalid"),
                    shelterid = (string)p.Element("shelterid"),
                    shelterpetid = (string)p.Element("shelterpetid"),
                    name = (string)p.Element("name"),
                    animal = (string)p.Element("animal"),
                    breeds = p.Elements("breeds").Select(b => new Breed
                    {
                        breed = (string)b.Element("breed")
                    }).ToList(),
                }).ToList();
        }
    }
}
