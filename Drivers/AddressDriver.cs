using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchemaMod.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;


namespace SchemaMod.Drivers
{
    public class AddressDriver : ContentPartDriver<AddressPart>
    {
        protected override DriverResult Display(
          AddressPart part, string displayType, dynamic shapeHelper)
        {

            return ContentShape("Parts_Address", () => shapeHelper.Parts_Address(
                Address: part.Address,
                State: part.State,
                ZIP: part.ZIP,
                City: part.City));
        }

        //GET
        protected override DriverResult Editor(
            AddressPart part, dynamic shapeHelper)
        {

            return ContentShape("Parts_Address_Edit",
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/Address",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(
            AddressPart part, IUpdateModel updater, dynamic shapeHelper)
        {

            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}