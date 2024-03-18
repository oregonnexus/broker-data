﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using EdNexusData.Broker.Data;

#nullable disable

namespace EdNexusData.Broker.Data.Migrations.MsSql
{
    [DbContext(typeof(MsSqlDbContext))]
    [Migration("20240303072259_FixDates")]
    partial class FixDates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.EducationOrganization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EducationOrganizationId");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contacts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Domain")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EducationOrganizationType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentOrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Domain")
                        .IsUnique()
                        .HasFilter("[Domain] IS NOT NULL");

                    b.HasIndex("ParentOrganizationId");

                    b.ToTable("EducationOrganizations");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.EducationOrganizationConnectorSettings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EducationOrganizationConnectorSettingsId");

                    b.Property<string>("Connector")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EducationOrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Settings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EducationOrganizationId", "Connector")
                        .IsUnique()
                        .HasFilter("[EducationOrganizationId] IS NOT NULL");

                    b.ToTable("EducationOrganizationConnectorSettings");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.EducationOrganizationPayloadSettings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EducationOrganizationPayloadSettingsId");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EducationOrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Payload")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EducationOrganizationId", "Payload")
                        .IsUnique()
                        .HasFilter("[EducationOrganizationId] IS NOT NULL");

                    b.ToTable("EducationOrganizationPayloadSettings");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.Mapping", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("MappingId");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DestinationMapping")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MappingType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalSchema")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RequestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SourceMapping")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentAttributes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("Mappings", (string)null);
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("MessageId");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MessageContents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("MessageTimestamp")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("RequestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RequestResponse")
                        .HasColumnType("int");

                    b.Property<string>("TransmissionDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("Messages", (string)null);
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.PayloadContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PayloadContentId");

                    b.Property<byte[]>("BlobContent")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JsonContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MessageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RequestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("XmlContent")
                        .HasColumnType("xml");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.HasIndex("RequestId");

                    b.ToTable("PayloadContents", (string)null);
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("RequestId");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EducationOrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IncomingOutgoing")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("InitialRequestSentDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Payload")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestManifest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RequestProcessUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RequestStatus")
                        .HasColumnType("int");

                    b.Property<string>("ResponseManifest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ResponseProcessUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Student")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WorkerInstance")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EducationOrganizationId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserId");

                    b.Property<int>("AllEducationOrganizations")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetimeoffset")
                        .HasAnnotation("Relational:IsStored", true);

                    b.Property<Guid?>("CreatedBy")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("uniqueidentifier")
                        .HasAnnotation("Relational:IsStored", true);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSuperAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserRoleId");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EducationOrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("EducationOrganizationId", "UserId")
                        .IsUnique()
                        .HasFilter("[EducationOrganizationId] IS NOT NULL AND [UserId] IS NOT NULL");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.EducationOrganization", b =>
                {
                    b.HasOne("EdNexusData.Broker.Domain.EducationOrganization", "ParentOrganization")
                        .WithMany("EducationOrganizations")
                        .HasForeignKey("ParentOrganizationId");

                    b.Navigation("ParentOrganization");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.EducationOrganizationConnectorSettings", b =>
                {
                    b.HasOne("EdNexusData.Broker.Domain.EducationOrganization", "EducationOrganization")
                        .WithMany()
                        .HasForeignKey("EducationOrganizationId");

                    b.Navigation("EducationOrganization");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.EducationOrganizationPayloadSettings", b =>
                {
                    b.HasOne("EdNexusData.Broker.Domain.EducationOrganization", "EducationOrganization")
                        .WithMany()
                        .HasForeignKey("EducationOrganizationId");

                    b.OwnsOne("EdNexusData.Broker.Domain.IncomingPayloadSettings", "IncomingPayloadSettings", b1 =>
                        {
                            b1.Property<Guid>("EducationOrganizationPayloadSettingsId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("StudentInformationSystem")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("EducationOrganizationPayloadSettingsId");

                            b1.ToTable("EducationOrganizationPayloadSettings");

                            b1.ToJson("IncomingPayloadSettings");

                            b1.WithOwner()
                                .HasForeignKey("EducationOrganizationPayloadSettingsId");

                            b1.OwnsMany("EdNexusData.Broker.Domain.PayloadSettingsContentType", "PayloadContents", b2 =>
                                {
                                    b2.Property<Guid>("IncomingPayloadSettingsEducationOrganizationPayloadSettingsId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int");

                                    b2.Property<string>("PayloadContentType")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Settings")
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("IncomingPayloadSettingsEducationOrganizationPayloadSettingsId", "Id");

                                    b2.ToTable("EducationOrganizationPayloadSettings");

                                    b2.WithOwner()
                                        .HasForeignKey("IncomingPayloadSettingsEducationOrganizationPayloadSettingsId");
                                });

                            b1.Navigation("PayloadContents");
                        });

                    b.OwnsOne("EdNexusData.Broker.Domain.OutgoingPayloadSettings", "OutgoingPayloadSettings", b1 =>
                        {
                            b1.Property<Guid>("EducationOrganizationPayloadSettingsId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("StudentLookupConnector")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("EducationOrganizationPayloadSettingsId");

                            b1.ToTable("EducationOrganizationPayloadSettings");

                            b1.ToJson("OutgoingPayloadSettings");

                            b1.WithOwner()
                                .HasForeignKey("EducationOrganizationPayloadSettingsId");

                            b1.OwnsMany("EdNexusData.Broker.Domain.PayloadSettingsContentType", "PayloadContents", b2 =>
                                {
                                    b2.Property<Guid>("OutgoingPayloadSettingsEducationOrganizationPayloadSettingsId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int");

                                    b2.Property<string>("PayloadContentType")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("Settings")
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("OutgoingPayloadSettingsEducationOrganizationPayloadSettingsId", "Id");

                                    b2.ToTable("EducationOrganizationPayloadSettings");

                                    b2.WithOwner()
                                        .HasForeignKey("OutgoingPayloadSettingsEducationOrganizationPayloadSettingsId");
                                });

                            b1.Navigation("PayloadContents");
                        });

                    b.Navigation("EducationOrganization");

                    b.Navigation("IncomingPayloadSettings");

                    b.Navigation("OutgoingPayloadSettings");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.Mapping", b =>
                {
                    b.HasOne("EdNexusData.Broker.Domain.Request", "Request")
                        .WithMany()
                        .HasForeignKey("RequestId");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.Message", b =>
                {
                    b.HasOne("EdNexusData.Broker.Domain.Request", "Request")
                        .WithMany("Messages")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Request");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.PayloadContent", b =>
                {
                    b.HasOne("EdNexusData.Broker.Domain.Message", "Message")
                        .WithMany("PayloadContents")
                        .HasForeignKey("MessageId");

                    b.HasOne("EdNexusData.Broker.Domain.Request", "Request")
                        .WithMany("PayloadContents")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.Request", b =>
                {
                    b.HasOne("EdNexusData.Broker.Domain.EducationOrganization", "EducationOrganization")
                        .WithMany()
                        .HasForeignKey("EducationOrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EducationOrganization");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.User", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<System.Guid>", null)
                        .WithOne()
                        .HasForeignKey("EdNexusData.Broker.Domain.User", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.UserRole", b =>
                {
                    b.HasOne("EdNexusData.Broker.Domain.EducationOrganization", "EducationOrganization")
                        .WithMany()
                        .HasForeignKey("EducationOrganizationId");

                    b.HasOne("EdNexusData.Broker.Domain.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId");

                    b.Navigation("EducationOrganization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.EducationOrganization", b =>
                {
                    b.Navigation("EducationOrganizations");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.Message", b =>
                {
                    b.Navigation("PayloadContents");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.Request", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("PayloadContents");
                });

            modelBuilder.Entity("EdNexusData.Broker.Domain.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
