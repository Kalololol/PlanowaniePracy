using Domain.Common;
using Domain.Entities.Entity;
using Domain.Work;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Team
{
    public class Employee : EntityBase, IAuditableEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AddressEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string Password { get; set; }        
        public bool ActiveAccount { get; set; }
        public Contract Contract { get; set; }
        public Ward Ward { get; set; }
        public int WardId { get; set; }
        public ICollection<Indisposition> Indispositions { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }

        protected Employee() { }

        public Employee(
            string name, 
            string surname, 
            string addressEmail, 
            string phoneNumber, 
            string licenseNumber, 
            string password, 
            bool activeAccount,
            int contractId,
            int wardId,
            DateTime created, 
            string createdBy, 
            DateTime? lastModified, 
            string? lastModifiedBy)
        {
            Name = name;
            Surname = surname;
            AddressEmail = addressEmail;
            PhoneNumber = phoneNumber;
            LicenseNumber = licenseNumber;
            Password = password;
            ActiveAccount = activeAccount;
            WardId = wardId;
            Created = created;
            CreatedBy = createdBy;
            LastModified = lastModified;
            LastModifiedBy = lastModifiedBy;
        }
               
    }
}
