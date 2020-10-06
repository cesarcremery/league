using DataLayer.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataLayer {
    class dataFunctie {
        public void VoegSpelerToe(Speler speler) {
            using (var context = new dbModel()) {
                context.Spelers.Add(speler);
                context.SaveChanges();
            }
        }

        public void UpdateSpeler(Speler speler) {
            using(var context = new dbModel()) {
                var teveranderenSpeler = context.Spelers.Find(speler.Id);
                teveranderenSpeler.Id = speler.Id;
                teveranderenSpeler.Naam = speler.Naam;
                teveranderenSpeler.Rugnummer = speler.Rugnummer;
                teveranderenSpeler.TeamId = speler.TeamId;
                context.SaveChanges();
            }
        }

        public void voegTeamToe(Team team) {
            using(var context = new dbModel()) {
                context.Teams.Add(team);
                context.SaveChanges();
            }
        }

        public void UpdateTeam(Team team) {
            using(var context = new dbModel()) {
                var teveranderenTeam = context.Teams.Find(team.Stamnummer);
                teveranderenTeam.Stamnummer = team.Stamnummer;
                teveranderenTeam.Naam = team.Naam;
                teveranderenTeam.Bijnaam = team.Bijnaam;
                teveranderenTeam.Trainer = team.Trainer;
                teveranderenTeam.Spelers = team.Spelers;
                context.SaveChanges();
            }
        }

        public void VoegSpelerToeAanTeam(int spelerId, int stamNummer) {
            using(var context = new dbModel()) {
                var speler = context.Spelers.ToList().Where(x => x.Id == spelerId).FirstOrDefault();
                var team = context.Teams.ToList().Where(x => x.Stamnummer == stamNummer).FirstOrDefault();
                team.Spelers.Add(speler);
                speler.TeamId = team.Stamnummer;
            }
        }

        public Speler SelecteerSpeler(int spelerID) {
            Speler speler = null;
            using (var context = new dbModel()) {
                speler = context.Spelers.ToList().Where(x => x.Id == spelerID).FirstOrDefault();
            }
            return speler;
        }

        public Team SelecteerTeam(int stamnummer) {
            Team team = null;
            using (var context = new dbModel()) {
                team = context.Teams.ToList().Where(x => x.Stamnummer == stamnummer).FirstOrDefault();

            }
            return team;
        }


        public Transfer SelecteerTransfer(int transferID) {
            Transfer transfer = null;
            using (var context = new dbModel()) {
                transfer = context.Transfers.ToList().Where(x => x.Id == transferID).FirstOrDefault();
            }
            return transfer;

        }
    }
}
