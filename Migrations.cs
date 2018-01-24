using System;
using System.Collections.Generic;
using System.Data;
using SchemaMod.Models;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace SchemaMod {
    public class Migrations : DataMigrationImpl {

        public int Create() {
            // Creating table AddressRecord
            SchemaBuilder.CreateTable("AddressRecord", table => table
                .ContentPartRecord()
                .Column("Address", DbType.String)
                .Column("City", DbType.String)
                .Column("State", DbType.String)
                .Column("Zip", DbType.String)
            );

            ContentDefinitionManager.AlterPartDefinition(
                typeof(AddressPart).Name, cfg => cfg.Attachable());

            return 1;
        }
    }
}