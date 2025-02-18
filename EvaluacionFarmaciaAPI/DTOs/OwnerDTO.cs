using System;
using System.Collections.Generic;
using EvaluacionFarmaciaAPI.Models;

namespace EvaluacionFarmaciaAPI.DTOs
{
    public class OwnerDTO
    {
        public int OwnerId { get; set; }

        public int DocumentTypeId { get; set; }

        public string DocumentOwner { get; set; }

        public string NameOwner { get; set; }

        public string LastNameOwner { get; set; }

        public string EmailOwner { get; set; }

        public string PhoneOwner { get; set; }

        public static OwnerDTO FromModel (Owner owner)
        {
            return new OwnerDTO
            {
                OwnerId = owner.OwnerId,
                DocumentTypeId = owner.DocumentTypeId,
                DocumentOwner = owner.DocumentOwner,
                NameOwner = owner.NameOwner,
                LastNameOwner = owner.LastNameOwner,
                EmailOwner = owner.EmailOwner,
                PhoneOwner = owner.PhoneOwner
            };
        }
    }
}