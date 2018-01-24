using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchemaMod.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;


namespace SchemaMod.Handlers
{
    public class AddressHandler : ContentHandler
    {
        public AddressHandler(IRepository<AddressRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}