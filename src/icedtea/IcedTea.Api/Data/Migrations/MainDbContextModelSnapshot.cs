﻿// <auto-generated />
using System;
using IcedTea.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IcedTea.Api.Data.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("icedtea")
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "uuid-ossp");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("IcedTea.Domain.AggregateModel.CashFundAggregate.CashFund", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by_id");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_updated_by");

                    b.Property<Guid>("LastUpdatedById")
                        .HasColumnType("uuid")
                        .HasColumnName("last_updated_by_id");

                    b.Property<DateTimeOffset>("LastUpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_updated_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("numeric")
                        .HasColumnName("total_amount");

                    b.HasKey("Id")
                        .HasName("pk_cash_funds");

                    b.ToTable("cash_funds", "icedtea");
                });

            modelBuilder.Entity("IcedTea.Domain.AggregateModel.CashFundTransactionAggregate.CashFundTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("CashFundId")
                        .HasColumnType("uuid")
                        .HasColumnName("cash_fund_id");

                    b.Property<DateTimeOffset>("CompletedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("completed_date");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by_id");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid")
                        .HasColumnName("customer_id");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_name");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_updated_by");

                    b.Property<Guid>("LastUpdatedById")
                        .HasColumnType("uuid")
                        .HasColumnName("last_updated_by_id");

                    b.Property<DateTimeOffset>("LastUpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_updated_date");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("note");

                    b.Property<int>("PaymentGateway")
                        .HasColumnType("integer")
                        .HasColumnName("payment_gateway");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("numeric")
                        .HasColumnName("total_amount");

                    b.HasKey("Id")
                        .HasName("pk_cash_fund_transactions");

                    b.HasIndex("CashFundId")
                        .HasDatabaseName("ix_cash_fund_transactions_cash_fund_id");

                    b.ToTable("cash_fund_transactions", "icedtea");
                });

            modelBuilder.Entity("IcedTea.Domain.AggregateModel.CustomerAggregate.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by_id");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("DeviceId")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("device_id");

                    b.Property<Guid>("ExternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("external_id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_updated_by");

                    b.Property<Guid>("LastUpdatedById")
                        .HasColumnType("uuid")
                        .HasColumnName("last_updated_by_id");

                    b.Property<DateTimeOffset>("LastUpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_updated_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("name");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1)
                        .HasColumnName("status");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("user_name");

                    b.Property<Guid>("WalletId")
                        .HasColumnType("uuid")
                        .HasColumnName("wallet_id");

                    b.HasKey("Id")
                        .HasName("pk_customer");

                    b.HasIndex("WalletId")
                        .IsUnique()
                        .HasDatabaseName("ix_customer_wallet_id");

                    b.ToTable("customer", "icedtea");
                });

            modelBuilder.Entity("IcedTea.Domain.AggregateModel.CustomerAggregate.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<DateTimeOffset>("LastUpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_updated_date");

                    b.Property<decimal>("SubTotalAmount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric")
                        .HasDefaultValue(0m)
                        .HasColumnName("sub_total_amount");

                    b.Property<decimal>("TotalAmount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric")
                        .HasDefaultValue(0m)
                        .HasColumnName("total_amount");

                    b.HasKey("Id")
                        .HasName("pk_wallet");

                    b.ToTable("wallet", "icedtea");
                });

            modelBuilder.Entity("IcedTea.Domain.AggregateModel.TransactionAggregate.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("BankAccount")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("bank_account");

                    b.Property<Guid?>("CashFundId")
                        .HasColumnType("uuid")
                        .HasColumnName("cash_fund_id");

                    b.Property<DateTimeOffset>("CompletedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("completed_date");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by_id");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid")
                        .HasColumnName("customer_id");

                    b.Property<string>("ErrorMessage")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("error_message");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("last_updated_by");

                    b.Property<Guid>("LastUpdatedById")
                        .HasColumnType("uuid")
                        .HasColumnName("last_updated_by_id");

                    b.Property<DateTimeOffset>("LastUpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_updated_date");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("note");

                    b.Property<int>("PaymentGateway")
                        .HasColumnType("integer")
                        .HasColumnName("payment_gateway");

                    b.Property<string>("Response")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("response");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("numeric")
                        .HasColumnName("total_amount");

                    b.HasKey("Id")
                        .HasName("pk_transactions");

                    b.HasIndex("CashFundId")
                        .HasDatabaseName("ix_transactions_cash_fund_id");

                    b.HasIndex("CustomerId")
                        .HasDatabaseName("ix_transactions_customer_id");

                    b.ToTable("transactions", "icedtea");
                });

            modelBuilder.Entity("IcedTea.Domain.AggregateModel.CashFundTransactionAggregate.CashFundTransaction", b =>
                {
                    b.HasOne("IcedTea.Domain.AggregateModel.CashFundAggregate.CashFund", "CashFund")
                        .WithMany("CashFundTransactions")
                        .HasForeignKey("CashFundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cash_fund_transactions_cash_funds_cash_fund_id");

                    b.Navigation("CashFund");
                });

            modelBuilder.Entity("IcedTea.Domain.AggregateModel.CustomerAggregate.Customer", b =>
                {
                    b.HasOne("IcedTea.Domain.AggregateModel.CustomerAggregate.Wallet", "Wallet")
                        .WithOne("Customer")
                        .HasForeignKey("IcedTea.Domain.AggregateModel.CustomerAggregate.Customer", "WalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_customer_wallets_wallet_id");

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("IcedTea.Domain.AggregateModel.TransactionAggregate.Transaction", b =>
                {
                    b.HasOne("IcedTea.Domain.AggregateModel.CashFundAggregate.CashFund", null)
                        .WithMany("Transactions")
                        .HasForeignKey("CashFundId")
                        .HasConstraintName("fk_transactions_cash_funds_cash_fund_id");

                    b.HasOne("IcedTea.Domain.AggregateModel.CustomerAggregate.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_transactions_customers_customer_id");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("IcedTea.Domain.AggregateModel.CashFundAggregate.CashFund", b =>
                {
                    b.Navigation("CashFundTransactions");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("IcedTea.Domain.AggregateModel.CustomerAggregate.Customer", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("IcedTea.Domain.AggregateModel.CustomerAggregate.Wallet", b =>
                {
                    b.Navigation("Customer")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
