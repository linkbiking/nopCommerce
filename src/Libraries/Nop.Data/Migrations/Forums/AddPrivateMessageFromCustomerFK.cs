﻿using System.Data;
using FluentMigrator;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Forums;
using Nop.Data.Extensions;

namespace Nop.Data.Migrations.Forums
{
    [Migration(637097790373669695)]
    public class AddPrivateMessageFromCustomerFK : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            this.AddForeignKey(NopMappingDefaults.PrivateMessageTable
                , nameof(PrivateMessage.FromCustomerId)
                , nameof(Customer)
                , nameof(Customer.Id));
        }

        #endregion
    }
}