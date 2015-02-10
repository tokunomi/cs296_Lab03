using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TSTOneighboreenos.Models;


namespace TSTOneighboreenos.DAL
{
    public class NeighboreenoInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NeighboreenoContext>
    {
        protected override void Seed(NeighboreenoContext context)
        {
            var players = new List<Player>
            {
                new Player{TSTOhandle="jtsmith",Lv=21,NameFirst="John",NameLast="Smith",MidInit='T',Email="jtsmith@test.com",SFpath="~/Content/Graphics/springfields/tsto_homeScreen.png",Active=true,AddMe=true},
                new Player{TSTOhandle="BillyBoy428",Lv=30,NameFirst="Bill",NameLast="Johnson",MidInit='M',Email="BillyBoy428@test.com",SFpath="~/Content/Graphics/springfields/tsto_homeScreen.png",Active=true,AddMe=true},
                new Player{TSTOhandle="LisaIsGr8",Lv=09,NameFirst="Lisa",NameLast="Kinderson",MidInit='A',Email="LisaIsGr8@test.com",SFpath="~/Content/Graphics/springfields/tsto_homeScreen.png",Active=true,AddMe=true},
                new Player{TSTOhandle="fhonda",Lv=42,NameFirst="Frank",NameLast="Honda",MidInit='N',Email="fhonda@test.com",SFpath="~/Content/Graphics/springfields/tsto_homeScreen.png",Active=true,AddMe=true},
                new Player{TSTOhandle="NatShell",Lv=48,NameFirst="Natalie",NameLast="Shelly",MidInit='B',Email="NatShell@test.com",SFpath="~/Content/Graphics/springfields/tsto_homeScreen.png",Active=true,AddMe=true}
            };

            players.ForEach(p => context.Players.Add(p));
            context.SaveChanges();
        }

        
            
    }
}