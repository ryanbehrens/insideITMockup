using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;

namespace SchemaMod.Models
{
    public class AddressRecord: ContentPartRecord
    {

        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string ZIP { get; set; }
    }

    public class AddressPart : ContentPart<AddressRecord>
    {
        [Required]
        public string Address
        {
            get { return Retrieve(r => r.Address); }
            set { Store(r => r.Address, value); }
        }
        [Required]
        public string City
        {
            get { return Retrieve(r => r.City); }
            set { Store(r => r.City, value); }
        }
        [Required]
        public string State
        {
            get { return Retrieve(r => r.State); }
            set { Store(r => r.State, value); }
        }
        [Required]
        public string ZIP
        {
            get { return Retrieve(r => r.ZIP); }
            set { Store(r => r.ZIP, value); }
        }
    }
      
}