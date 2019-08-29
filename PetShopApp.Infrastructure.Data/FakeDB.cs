using PetShopApp.Core.Entities;
using PetShopApp.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Infrastructure.Data
{
    public static class FakeDB
    {

        private static List<Pet> pets = new List<Pet>();
        static int id = 1;
        public static List<Pet> InitData()
        {
            var pet1 = new Pet()
            {
                ID = id++,
                Name = "Jeson",
                PreviousOwner = "Nedas",
                Type = "Cat",
                Price = 99,
                SoldDate = DateTime.Now,
                Birthdate = DateTime.Now,
                Color = "Blue"
            };
            pets.Add(pet1);

            var pet2 = new Pet()
            {
                ID = id++,
                Name = "Kek the Frog",
                PreviousOwner = "4Chan",
                Type = "Fox",
                Price = 69,
                SoldDate = DateTime.Now,
                Birthdate = DateTime.Now,
                Color = "Black"
            };
            pets.Add(pet2);
            var pet3 = new Pet()
            {
                ID = id++,
                Name = "Kek the Frog",
                PreviousOwner = "4Chan",
                Type = "Fox",
                Price = 619,
                SoldDate = DateTime.Now,
                Birthdate = DateTime.Now,
                Color = "Black"
            };
            pets.Add(pet3);
            var pet4 = new Pet()
            {
                ID = id++,
                Name = "Kek the Frog",
                PreviousOwner = "4Chan",
                Type = "Fox",
                Price = 629,
                SoldDate = DateTime.Now,
                Birthdate = DateTime.Now,
                Color = "Black"
            };
            pets.Add(pet4);
            var pet5 = new Pet()
            {
                ID = id++,
                Name = "Kek the Frog",
                PreviousOwner = "4Chan",
                Type = "Fox",
                Price = 9,
                SoldDate = DateTime.Now,
                Birthdate = DateTime.Now,
                Color = "Black"
            };
            pets.Add(pet5);
            var pet6 = new Pet()
            {
                ID = id++,
                Name = "Kek the Frog",
                PreviousOwner = "4Chan",
                Type = "Fox",
                Price = 6,
                SoldDate = DateTime.Now,
                Birthdate = DateTime.Now,
                Color = "Black"
            };
            pets.Add(pet6);

            return pets;
        }

        public static int getID()
        {
            return id;
        }
    }
}
