using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Diagram {
    public class Speler {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Rugnummer { get; set; }
        public int Value { get; set; }
        public int TeamId { get; set; }
        public Speler(string naam, int rugnummer, int value, int TeamId) {
            this.Naam = naam;
            this.Rugnummer = rugnummer;
            this.Value = value;
            this.TeamId = TeamId;
        }
    }
}
