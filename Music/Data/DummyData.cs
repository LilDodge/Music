using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Music.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                // Look for any teams.
                if (context.Teams.Any())
                {
                    return;   // DB has already been seeded
                }

                var teams = DummyData.GetTeams().ToArray();
                context.Teams.AddRange(teams);
                context.SaveChanges();

            }
        }

        public static List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>() {
            new Team() {
               Singer="Alan Olav Walker",
                City="England",
                Song="《Faded》",
                Style="Electronic music",
                PictureUrl="",
               

            },
            new Team() {
                Singer="JJ Lin",
                City="China",
                Song="《当你》",
                Style="Chinoiserie",
                 PictureUrl="",


    },
            new Team() {
                Singer="Carly Rae Jepsen",
                City="Canada",
                Song="《Call Me Maybe》",
                Style="pop",
                 PictureUrl="",


            },
            new Team() {
                Singer="Taylor Swift",
                City="USA",
                Song="《泰勒·斯威夫特》",
                Style="Country style",
                 PictureUrl="",

            },
            new Team() {
               Singer="Andy Lau",
                City="HK",
                Song="《只知道此刻爱你》",
                Style="pop",
                 PictureUrl="",

            },
            new Team() {
                Singer="Ed Sheeran",
                City="England",
                Song="《shape of you》",
                Style="folk music",
                 PictureUrl="",

            },
          
        };

            return teams;
        }
    }


}
