using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcWineAPP.Models;

namespace MvcWineAPP.Data
{
    public class DbInitializer
    {
    
    public static void Initialize(WineDBContext context)
    {
        context.Database.EnsureCreated();

        // Look for any Wines.
        if (context.Wines.Any())
        {
            return;   // DB has been seeded
        }

        var wines = new Wine[]
        {
            new Wine{WineID= 1, WineName="Ghost Pines",WineVintage=2018, PairsWith = "Pairs well with Beer, Lamb, Deer, Venison, Poultry."},
            new Wine{WineID= 2, WineName="Example Wine2",WineVintage=2008, PairsWith = "Pairs well with Beer, Poultry."},
            new Wine{WineID= 3, WineName="Example Wine3",WineVintage=2007, PairsWith = "Pairs well with Lamb, Venison, Poultry."},
            new Wine{WineID= 4, WineName="Example Wine4",WineVintage=2006, PairsWith = "Pairs well with Beer, Lamb, Deer, Venison, Poultry."},
            new Wine{WineID= 5, WineName="Example Wine5",WineVintage=2012, PairsWith = "Pairs well with Beer, Lamb, Deer."},
            new Wine{WineID= 6, WineName="Example Wine6",WineVintage=2014, PairsWith = "Pairs well with Poultry."},

        };
        foreach (Wine s in wines)
        {
            context.Wines.Add(s);
        }
        context.SaveChanges();

        var grapes = new Grape[]
        {
            new Grape{GrapeID=1001,RedGrape="Cabernet Sauvignon ",Rating=7},
            new Grape{GrapeID=1002,RedGrape="Merlot",Rating=6},
            new Grape{GrapeID=1003,RedGrape="Pinot Noir",Rating=5},
            new Grape{GrapeID=1004,RedGrape=" Malbec",Rating=8},
            new Grape{GrapeID=1005,RedGrape="Zinfandel",Rating=9},
            new Grape{GrapeID=1006,RedGrape="Sangiovese",Rating=6},

        };
        foreach (Grape c in grapes)
        {
            context.Grapes.Add(c);
        }
        context.SaveChanges();

        //var winetype = new WineType[]
        //{
        //    new WineType{WineID=1,GrapesID=1001,Grade=Grade.A},
        //    new WineType{WineID=2,GrapesID=1002,Grade=Grade.A},
        //    new WineType{WineID=4,GrapesID=1003,Grade=Grade.A},
        //    new WineType{WineID=3,GrapesID=1004,Grade=Grade.A},
        //    new WineType{WineID=5,GrapesID=1005,Grade=Grade.A},
        //    new WineType{WineID=6,GrapesID=1006,Grade=Grade.A},
        //    new WineType{WineID=1,GrapesID=1001,Grade=Grade.A},
        //    new WineType{WineID=1,GrapesID=1001,Grade=Grade.A},
        //    new WineType{WineID=1,GrapesID=1001,Grade=Grade.A},

        //};
        //foreach (WineType e in winetype)
        //{
        //    context.WineType.Add(e);
        //}
        //context.SaveChanges();
    }
}
}
