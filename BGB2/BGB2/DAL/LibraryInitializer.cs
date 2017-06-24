using BGB2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BGB2.DAL
{
    public class LibraryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var users = new List<User>
            {
            new User{Name="Ryan"},           
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var games = new List<Game>
            {
                new Game()
            {
                ID = 1,
                Title = "Blood Rage",
                PlayerCountMin = 2,
                PlayerCountMax = 5,
                BestPlayerCount = 4,
                PlayTimeMax = 90,
                MyRating = 7.5,
                GeekRating = 8.2,
            },
            new Game()
            {
                ID = 2,
                Title = "Lost Cities",
                PlayerCountMin = 2,
                PlayerCountMax = 2,
                BestPlayerCount = 2,
                PlayTimeMax = 30,
                MyRating = 8.1,
                GeekRating = 7.1,
            },
            new Game()
            {
                ID = 3,
                Title = "Dead of Winter: A Crossroads Game ",
                PlayerCountMin = 2,
                PlayerCountMax = 5,
                BestPlayerCount = 4,
                PlayTimeMax = 210,
                MyRating = 7.5,
                GeekRating = 7.9,
            },
            new Game()
            {
                ID = 4,
                Title = "Cosmic Encounter",
                PlayerCountMin = 3,
                PlayerCountMax = 6,
                BestPlayerCount = 5,
                PlayTimeMax = 120,
                MyRating = 9.0,
                GeekRating = 7.6,
            },
            new Game()
            {
                ID = 5,
                Title = "Codenames",
                PlayerCountMin = 2,
                PlayerCountMax = 8,
                BestPlayerCount = 6,
                PlayTimeMax = 15,
                MyRating = 8,
                GeekRating = 7.9,
            }};

            games.ForEach(g => context.Games.Add(g));
            context.SaveChanges(); 
        }
    }
}
    
