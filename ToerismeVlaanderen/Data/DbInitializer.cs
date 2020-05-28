using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToerismeVlaanderen.Models;

namespace ToerismeVlaanderen.Data
{
    public static class DbInitializer
    {
        public static void Initialize(VLContext context)
        {
            context.Database.EnsureCreated();

            // Look for any activiteiten.
            if (context.Activiteiten.Any())
            {
                return;   // DB has been seeded
            }

            var provincies = new Provincie[]
            {
            new Provincie{ProvincieID=200, Naam="Limburg"},
            new Provincie{ProvincieID=100, Naam="Antwerpen"},
            new Provincie{ProvincieID=300, Naam="Vlaams-Brabant"},
            new Provincie{ProvincieID=400, Naam="West-Vlaanderen"},
            new Provincie{ProvincieID=500, Naam="Oost-Vlaanderen"},
            };
            foreach (var p in provincies)
            {
                context.Provincies.Add(p);
            }
            context.SaveChanges();

            var gemeentes = new Gemeente[]
            {
            new Gemeente{GemeenteID = 2440, ProvincieID=100, Naam="Geel"},
            new Gemeente{GemeenteID = 2200, ProvincieID=100, Naam="Herentals"},
            new Gemeente{GemeenteID = 3390, ProvincieID=300, Naam="Tielt-Winge"},
            new Gemeente{GemeenteID = 3500, ProvincieID=200, Naam="Hasselt"},
            new Gemeente{GemeenteID = 2260, ProvincieID=100, Naam="Westerlo"},
            new Gemeente{GemeenteID = 3000, ProvincieID=300, Naam="Leuven"},
            new Gemeente{GemeenteID = 3200, ProvincieID=300, Naam="Aarschot"},
            new Gemeente{GemeenteID = 3700, ProvincieID=200, Naam="Tongeren"},
            };
            foreach (var g in gemeentes)
            {
                context.Gemeentes.Add(g);
            }
            context.SaveChanges();

            var activiteiten = new Activiteit[]
            {
            new Activiteit{ActiviteitID=1,GemeenteID=3500,MaxPersonen=3,Naam="Shotjes in het Jenevermuseum",Datum=DateTime.Parse("2020-08-08")},
            new Activiteit{ActiviteitID=200,GemeenteID=2440,MaxPersonen=10,Naam="Stadswandeling",Datum=DateTime.Parse("2020-07-15")},
            new Activiteit{ActiviteitID=3,GemeenteID=3390,MaxPersonen=2,Naam="Uitzicht vanop de Vlooybergtoren",Datum=DateTime.Parse("2020-08-23")},
            new Activiteit{ActiviteitID=40,GemeenteID=2260,MaxPersonen=15,Naam="Natuurwandeling Kwarekken",Datum=DateTime.Parse("2020-08-03")},
            new Activiteit{ActiviteitID=5,GemeenteID=3000,MaxPersonen=5,Naam="Universiteitsbibliotheek en -toren",Datum=DateTime.Parse("2020-07-06")},
            new Activiteit{ActiviteitID=61,GemeenteID=2440,MaxPersonen=3,Naam="Bezoek Gasthuismuseum",Datum=DateTime.Parse("2020-07-01")},
            new Activiteit{ActiviteitID=7,GemeenteID=2260,MaxPersonen=8,Naam="Gegidst bezoek gemeentehuis",Datum=DateTime.Parse("2020-07-11")},
            new Activiteit{ActiviteitID=88,GemeenteID=2200,MaxPersonen=15,Naam="Boerenkrijgwandeling",Datum=DateTime.Parse("2020-08-15")},
            new Activiteit{ActiviteitID=900,GemeenteID=3500,MaxPersonen=30,Naam="Japanse tuin",Datum=DateTime.Parse("2020-07-09")},
            new Activiteit{ActiviteitID=1000,GemeenteID=3500,MaxPersonen=15,Naam="Het stadsmus",Datum=DateTime.Parse("2020-07-10")},
            new Activiteit{ActiviteitID=11,GemeenteID=3700,MaxPersonen=10,Naam="Gallo-Romeins Museum",Datum=DateTime.Parse("2020-08-11")},
            new Activiteit{ActiviteitID=1212,GemeenteID=2440,MaxPersonen=8,Naam="De schatten van de Sint-Dimpnakerk",Datum=DateTime.Parse("2020-07-22")},
            new Activiteit{ActiviteitID=13,GemeenteID=3000,MaxPersonen=15,Naam="Wandeling Groot Begijnhof",Datum=DateTime.Parse("2020-08-14")},
            new Activiteit{ActiviteitID=141,GemeenteID=3390,MaxPersonen=8,Naam="Ridderavontuur in het kasteel van Horst",Datum=DateTime.Parse("2020-07-25")},
            new Activiteit{ActiviteitID=15,GemeenteID=3200,MaxPersonen=6,Naam="Bezoek stadsbrouwerij",Datum=DateTime.Parse("2020-08-07")},
            };
            foreach (var a in activiteiten)
            {
                context.Activiteiten.Add(a);
            }
            context.SaveChanges();

            var inschrijvingen = new Inschrijving[]
            {
            new Inschrijving{Naam="Jef Verboven", Email="jv@ping.be", ActiviteitID=1},
            new Inschrijving{Naam="Ans Heylen", Email="ans.heylen@telenet.be", ActiviteitID=3},
            new Inschrijving{Naam="Steff Quintens", Email="steff@quintens.be", ActiviteitID=88},
            new Inschrijving{Naam="Alex Peeters", Email="alexp@proximus.com", ActiviteitID=5},
            new Inschrijving{Naam="Mies Gevers", Email="msgs@abb.be", ActiviteitID=3},
            new Inschrijving{Naam="Wout Stevens", Email="ws@telenet.be", ActiviteitID=7},
            new Inschrijving{Naam="Karel Abeloos", Email="karel.abeloos@google.be", ActiviteitID=88},
            new Inschrijving{Naam="Els Van Mol", Email="evm@kbc.be", ActiviteitID=5},
            new Inschrijving{Naam="Griet Van Lommel", Email="vlommel.griet@tm.be", ActiviteitID=61},
            new Inschrijving{Naam="Lea Storms", Email="lea.storms@pa.be", ActiviteitID=61},
            new Inschrijving{Naam="Steven Haeckens", Email="steven@haeckens.com", ActiviteitID=7},
            new Inschrijving{Naam="Peter Vanheuckelom", Email="pvhl@fret.be", ActiviteitID=5},
            new Inschrijving{Naam="Dana Wouters", Email="dana.wouters@vrt.be", ActiviteitID=1000},
            new Inschrijving{Naam="Laura Fleerackers", Email="lf@qrst.com", ActiviteitID=11},
            new Inschrijving{Naam="Hugo Christiaans", Email="hugo.christiaans@museumKL.be", ActiviteitID=1000},
            new Inschrijving{Naam="Greet Mertens", Email="mertens.greet@tm.be", ActiviteitID=61},
            new Inschrijving{Naam="Dieter Sjegers", Email="dieter@sjegers.org", ActiviteitID=11}
            };
            foreach (var i in inschrijvingen)
            {
                context.Inschrijvingen.Add(i);
            }
            context.SaveChanges();

        }
    }
}
