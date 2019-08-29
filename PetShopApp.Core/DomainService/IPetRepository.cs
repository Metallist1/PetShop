using System;
using System.Collections.Generic;
using System.Text;
using PetShopApp.Core.Entities;

namespace PetShopApp.Core.DomainService
{
    public interface IPetRepository
    {
        IEnumerable<Pet> ReadPets();
        Pet Create(Pet pe);
        Pet Delete(int id);
        Pet FindPetID(int id);
        void InitialiseData();
    }
}
