using PetShopApp.Core.DomainService;
using PetShopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Infrastructure.Data.Repositories
{
    public class PetRepository : IPetRepository
    {
        static int id = 1;
        private List<Pet> _pets = new List<Pet>();
        public Pet Create(Pet pe)
        {
            pe.ID = id++;
            _pets.Add(pe);
            return pe;
        }

        public Pet Delete(int id)
        {
            var petFound = this.FindPetID(id);
            if(petFound != null)
            {
                _pets.Remove(petFound);
                return petFound;
            }
            return null;
        }

        public Pet FindPetID(int id)
        {
            foreach(var pet in _pets)
            {
                if(pet.ID == id)
                {
                    return pet;
                }
            }
            return null;
        }

        public void InitialiseData()
        {
            _pets = FakeDB.InitData();
            IDAfterInit();
        }
        private void IDAfterInit()
        {
            id = FakeDB.getID();
        }

        public IEnumerable<Pet> ReadPets()
        {
            return _pets;
        }
    }
}
