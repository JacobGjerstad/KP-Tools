﻿// <auto-generated />
using KP_Tools.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KP_Tools.Migrations
{
    [DbContext(typeof(StatContext))]
    [Migration("20200418044137_AddedWeapon")]
    partial class AddedWeapon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KP_Tools.Models.Weapon", b =>
                {
                    b.Property<int>("WeaponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("WeaponActionEndurance")
                        .HasColumnType("int");

                    b.Property<int>("WeaponActionSpeed")
                        .HasColumnType("int");

                    b.Property<int>("WeaponCastingSpeed")
                        .HasColumnType("int");

                    b.Property<int>("WeaponHp")
                        .HasColumnType("int");

                    b.Property<int>("WeaponHpRecovery")
                        .HasColumnType("int");

                    b.Property<int>("WeaponMagicAttack")
                        .HasColumnType("int");

                    b.Property<int>("WeaponMagicDefense")
                        .HasColumnType("int");

                    b.Property<int>("WeaponMagicalCritRate")
                        .HasColumnType("int");

                    b.Property<int>("WeaponMana")
                        .HasColumnType("int");

                    b.Property<int>("WeaponManaRecovery")
                        .HasColumnType("int");

                    b.Property<int>("WeaponMovementSpeed")
                        .HasColumnType("int");

                    b.Property<int>("WeaponPhysicalAttack")
                        .HasColumnType("int");

                    b.Property<int>("WeaponPhysicalCritRate")
                        .HasColumnType("int");

                    b.Property<int>("WeaponPhysicalDefense")
                        .HasColumnType("int");

                    b.Property<string>("WeaponProperty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeaponRageGeneration")
                        .HasColumnType("int");

                    b.Property<int>("WeaponSpellEndurance")
                        .HasColumnType("int");

                    b.Property<int>("WeaponStamina")
                        .HasColumnType("int");

                    b.Property<int>("WeaponStaminaRecovery")
                        .HasColumnType("int");

                    b.Property<string>("WeaponType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WeaponId");

                    b.ToTable("Weapons");
                });
#pragma warning restore 612, 618
        }
    }
}
