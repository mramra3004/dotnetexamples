﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#pragma warning disable 219, 612, 618
#nullable enable

namespace IcedTead.Api
{
    public partial class MainDbContextModel
    {
        partial void Initialize()
        {
            var cashFund = CashFundEntityType.Create(this);
            var cashFundTransaction = CashFundTransactionEntityType.Create(this);
            var customer = CustomerEntityType.Create(this);
            var wallet = WalletEntityType.Create(this);
            var transaction = TransactionEntityType.Create(this);

            CashFundTransactionEntityType.CreateForeignKey1(cashFundTransaction, cashFund);
            CustomerEntityType.CreateForeignKey1(customer, wallet);
            TransactionEntityType.CreateForeignKey1(transaction, cashFund);
            TransactionEntityType.CreateForeignKey2(transaction, customer);

            CashFundEntityType.CreateAnnotations(cashFund);
            CashFundTransactionEntityType.CreateAnnotations(cashFundTransaction);
            CustomerEntityType.CreateAnnotations(customer);
            WalletEntityType.CreateAnnotations(wallet);
            TransactionEntityType.CreateAnnotations(transaction);

            AddAnnotation("Npgsql:PostgresExtension:uuid-ossp", ",,");
            AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
            AddAnnotation("ProductVersion", "6.0.0");
            AddAnnotation("Relational:DefaultSchema", "icedtea");
            AddAnnotation("Relational:MaxIdentifierLength", 63);
        }
    }
}