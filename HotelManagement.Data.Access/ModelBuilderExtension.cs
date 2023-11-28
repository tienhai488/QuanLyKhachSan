namespace HotelManagement.Data.Access
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;
    using HotelManagement.Data.Transfer;
    using System.Reflection.Emit;

    internal static class ModelBuilderExtension
    {
        //public static void ConfigureRoom(this EntityTypeBuilder<Room> builder, bool includeRoomTypeRelationship = true)
        //{
        //    builder.ToTable("room");
        //    builder.Property<string>(nameof(Room.Id))
        //        .HasColumnName("ID");
        //    builder.Property<int>(nameof(Room.Status))
        //        .HasColumnName("Status");
        //    builder.Property<string>(nameof(Room.RoomTypeId))
        //        .HasColumnName("RoomTypeID");
        //    builder.HasKey(nameof(Room.Id));

        //    if (includeRoomTypeRelationship)
        //    {
        //        builder.HasOne<RoomType>(nameof(Room.RoomType))
        //            .WithMany(nameof(RoomType.Rooms))
        //            .HasForeignKey(nameof(Room.RoomTypeId))
        //            .IsRequired()
        //            .OnDelete(DeleteBehavior.Restrict);
        //    }
        //    else builder.Ignore(nameof(Room.RoomType));
        //}
        public static void ConfigureRoom(this EntityTypeBuilder<Room> builder, bool includeRoomTypeRelationship = true)
        {
            builder.ToTable("room");
            builder.Property<string>(nameof(Room.Id))
                .HasColumnName("ID");
            builder.Property<RoomStatus>(nameof(Room.Status))
                .HasColumnName("Status")
                .HasConversion(x => (int)x, x => (RoomStatus)x);
            builder.OptionalBigIntegerIdProperty(nameof(Room.RoomTypeId), "RoomTypeID", "RT", "2");
            builder.HasKey(nameof(Room.Id));

            //if (includeRoomTypeRelationship)
            //{
            //    builder.HasOne<RoomType>(nameof(Room.RoomType))
            //        .WithMany(nameof(RoomType.Rooms))
            //        .HasForeignKey(nameof(Room.RoomTypeId))
            //        .IsRequired().OnDelete(DeleteBehavior.Restrict);
            //}
            //else builder.Ignore(nameof(Room.RoomType));
        }


        //public static void ConfigureRoomType(this EntityTypeBuilder<RoomType> builder, bool includeConvenienceRelationship = true)
        //{
        //    builder.ToTable("roomtype");
        //    builder.Property<string>(nameof(RoomType.Id))
        //        .HasColumnName("ID");
        //    builder.Property<string>(nameof(RoomType.Name))
        //        .HasColumnName("Name");
        //    builder.Property<double>(nameof(RoomType.UnitPrice))
        //        .HasColumnName("UnitPrice");
        //    builder.HasKey(nameof(RoomType.Id));

        //    if (includeConvenienceRelationship)
        //    {
        //        builder.HasMany<Convinience>(nameof(RoomType.Conviniences))
        //        .WithMany().UsingEntity<RoomTypeConvinience>()
        //        .ConfigureRoomTypeConvenience();
        //    }
        //    else builder.Ignore(nameof(RoomType.Conviniences));
        //}

        public static void ConfigureRoomType(this EntityTypeBuilder<RoomType> builder, bool includeConvenienceRelationship = true)
        {
            builder.ToTable("roomtype");
            builder.BigIntegerIdProperty(nameof(RoomType.Id), "ID", "RT", "2");
            builder.Property<string>(nameof(RoomType.Name))
                .HasColumnName("Name");
            builder.Property<double>(nameof(RoomType.UnitPrice))
                .HasColumnName("UnitPrice");
            builder.HasKey(nameof(RoomType.Id));

            //if (includeConvenienceRelationship)
            //{
            //    builder.HasMany<Convenience>(nameof(RoomType.Conveniences))
            //    .WithMany().UsingEntity<RoomTypeConvenience>()
            //    .ConfigureRoomTypeConvenience();
            //}
            //else
            //{
            //    builder.Ignore(nameof(RoomType.Conveniences));
            //    builder.Ignore(nameof(RoomType.Quantities));
            //}
        }

        //public static void ConfigureRoomTypeConvenience(this EntityTypeBuilder<RoomTypeConvinience> builder)
        //{
        //    builder.ToTable("convinience_roomtype");

        //    builder.Property<string>(nameof(RoomTypeConvinience.RoomTypeId))
        //        .HasColumnName("RoomTypeId");
        //    builder.Property<string>(nameof(RoomTypeConvinience.ConvinienceId))
        //        .HasColumnName("ConvinienceId");
        //    builder.Property<int>(nameof(RoomTypeConvinience.Quantity))
        //        .HasColumnName("Quantity").HasDefaultValue(1);
        //    builder.HasKey(nameof(RoomTypeConvinience.RoomTypeId), nameof(RoomTypeConvinience.ConvinienceId));

        //    builder.HasOne<Convinience>(nameof(RoomTypeConvinience.Convenience))
        //        .WithMany().HasForeignKey(nameof(RoomTypeConvinience.Convenience));
        //    builder.HasOne<RoomType>(nameof(RoomTypeConvinience.RoomType))
        //        .WithMany(nameof(RoomType.Quantities))
        //        .HasForeignKey(nameof(RoomTypeConvinience.RoomTypeId));
        //}
        public static void ConfigureRoomTypeConvenience(this EntityTypeBuilder<RoomTypeConvinience> builder)
        {
            builder.ToTable("convinience_roomtype");

            builder.BigIntegerIdProperty(nameof(RoomTypeConvinience.RoomTypeId), "RoomTypeId", "RT", "2");
            builder.BigIntegerIdProperty(nameof(RoomTypeConvinience.ConvinienceId), "ConvinienceId", "CO", "2");
            builder.Property<int>(nameof(RoomTypeConvinience.Quantity))
                .HasColumnName("Quantity").HasDefaultValue(1);
            builder.HasKey(nameof(RoomTypeConvinience.RoomTypeId), nameof(RoomTypeConvinience.ConvinienceId));

            builder.HasOne<Convinience>(nameof(RoomTypeConvinience.Convinience))
                .WithMany().HasForeignKey(nameof(RoomTypeConvinience.ConvinienceId));
            //builder.HasOne<RoomType>(nameof(RoomTypeConvinience.RoomType))
            //    .WithMany(nameof(RoomType.Quantities))
            //    .HasForeignKey(nameof(RoomTypeConvinience.RoomTypeId));
        }

        //public static void ConfigureConvenience(this EntityTypeBuilder<Convinience> builder)
        //{
        //    builder.ToTable("convinience");
        //    builder.Property<string>(nameof(Convinience.Id))
        //        .HasColumnName("ID");
        //    builder.Property<string>(nameof(Convinience.Name))
        //        .HasColumnName("Name");
        //    builder.HasKey(nameof(Convinience.Id));
        //}

        public static void ConfigureConvenience(this EntityTypeBuilder<Convinience> builder)
        {
            builder.ToTable("convinience");
            builder.BigIntegerIdProperty(nameof(Convinience.Id), "ID", "CO", "2");
            builder.Property<string>(nameof(Convinience.Name))
                .HasColumnName("Name");
            builder.HasKey(nameof(Convinience.Id));
        }

        //public static void ConfigureReservation(this EntityTypeBuilder<Reservation> builder,
        //    bool includeRoomRelationship = true, bool includeStaffRelationship = true, bool includeCustomerRelationship = true)
        //{
        //    builder.ToTable("reservation");
        //    builder.Property<string>(nameof(Reservation.Id))
        //        .HasColumnName("ID");
        //    builder.Property<DateTime>(nameof(Reservation.CreatedAt))
        //        .HasColumnName("CreatedAt");
        //    builder.BigIntegerIdProperty(nameof(Reservation.StaffId), "StaffID", "SA", "3");
        //    builder.BigIntegerIdProperty(nameof(Reservation.CustomerId), "CustomerID", "CU", "3");
        //    builder.HasKey(nameof(Reservation.Id));

        //    if (includeRoomRelationship)
        //    {
        //        builder.HasOne<Room>(nameof(Reservation.Room))
        //            .WithMany().HasForeignKey(nameof(Reservation.RoomId))
        //            .IsRequired().OnDelete(DeleteBehavior.Restrict);
        //    }
        //    else builder.Ignore(nameof(Reservation.Room));
        //    if (includeStaffRelationship)
        //    {
        //        builder.HasOne<Staff>(nameof(Reservation.Staff))
        //            .WithMany().HasForeignKey(nameof(Reservation.StaffId))
        //            .IsRequired().OnDelete(DeleteBehavior.Restrict);
        //    }
        //    else builder.Ignore(nameof(Reservation.Staff));
        //    if (includeCustomerRelationship)
        //    {
        //        builder.HasOne<Customer>(nameof(Reservation.Customer))
        //            .WithMany().HasForeignKey(nameof(Reservation.CustomerId))
        //            .IsRequired().OnDelete(DeleteBehavior.Restrict);
        //    }
        //    else builder.Ignore(nameof(Reservation.Customer));
        //}

        public static void ConfigureRentRoomDetail(this EntityTypeBuilder<RentRoomDetail> builder,
            bool includeRoomRelationship = true, bool includeStaffRelationship = true, bool includeInvoiceRelationship = true)
        {
            builder.ToTable("rentroomdetail");
            builder.BigIntegerIdProperty(nameof(RentRoomDetail.Id), "ID", "RD", "5");
            builder.Property<DateTime>(nameof(RentRoomDetail.StartTime))
                .HasColumnName("StartTime");
            builder.Property<DateTime>(nameof(RentRoomDetail.EndTime))
                .HasColumnName("EndTime");
            builder.Property<DateTime>(nameof(RentRoomDetail.AddedTime))
                .HasColumnName("AddedTime");
            builder.Property<string>(nameof(RentRoomDetail.RoomId))
                .HasColumnName("RoomID");
            builder.BigIntegerIdProperty(nameof(RentRoomDetail.InvoiceId), "InvoiceID", "IN", "4");
            builder.BigIntegerIdProperty(nameof(RentRoomDetail.StaffId), "StaffID", "SA", "3");
            builder.HasKey(nameof(RentRoomDetail.Id));

            if (includeRoomRelationship)
            {
                builder.HasOne<Room>(nameof(RentRoomDetail.Room))
                    .WithMany().HasForeignKey(nameof(RentRoomDetail.RoomId))
                    .IsRequired().OnDelete(DeleteBehavior.Restrict);
            }
            else builder.Ignore(nameof(RentRoomDetail.Room));
            if (includeStaffRelationship)
            {
                builder.HasOne<Staff>(nameof(RentRoomDetail.Staff))
                    .WithMany().HasForeignKey(nameof(RentRoomDetail.StaffId))
                    .IsRequired().OnDelete(DeleteBehavior.Restrict);
            }
            else builder.Ignore(nameof(RentRoomDetail.Staff));
            if (includeInvoiceRelationship)
            {
                builder.HasOne<Invoice>(nameof(RentRoomDetail.Invoice))
                    .WithMany(nameof(Invoice.RentRooms))
                    .HasForeignKey(nameof(RentRoomDetail.InvoiceId))
                    .IsRequired().OnDelete(DeleteBehavior.Restrict);
            }
            else builder.Ignore(nameof(RentRoomDetail.Invoice));
        }

        public static void ConfigureInvoice(this EntityTypeBuilder<Invoice> builder,
            bool includeStaffRelationship = true, bool includeCustomerRelationship = true)
        {
            builder.ToTable("invoice");
            builder.BigIntegerIdProperty(nameof(Invoice.Id), "ID", "IN", "4");
            builder.Property<double>(nameof(Invoice.Subtotal))
                .HasColumnName("Subtotal");
            builder.Property<double>(nameof(Invoice.TotalDue))
                .HasColumnName("TotalDue");
            builder.Property<DateTime?>(nameof(Invoice.PaidTime))
                .HasColumnName("PaidTime");
            builder.BigIntegerIdProperty(nameof(Invoice.StaffId), "StaffID", "SA", "3");
            builder.BigIntegerIdProperty(nameof(Invoice.CustomerId), "CustomerID", "CU", "3");
            builder.HasKey(nameof(Invoice.Id));

            if (includeStaffRelationship)
            {
                builder.HasOne<Staff>(nameof(Invoice.Staff))
                    .WithMany().HasForeignKey(nameof(Invoice.StaffId))
                    .IsRequired().OnDelete(DeleteBehavior.Restrict);
            }
            else builder.Ignore(nameof(Invoice.Staff));
            if (includeCustomerRelationship)
            {
                builder.HasOne<Customer>(nameof(Invoice.Customer))
                    .WithMany().HasForeignKey(nameof(Invoice.CustomerId))
                    .IsRequired().OnDelete(DeleteBehavior.Restrict);
            }
            else builder.Ignore(nameof(Invoice.Customer));
        }

        public static void ConfigureCustomer(this EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customer");
            builder.BigIntegerIdProperty(nameof(Customer.Id), "ID", "CU", "3");
            builder.Property<string>(nameof(Customer.FullName))
                .HasColumnName("FullName");
            builder.Property<bool>(nameof(Customer.Gender))
                .HasColumnName("Gender")
                .HasConversion(x => x == Customer.GenderMale ? "0" : "1", x => x == "0" ? Customer.GenderMale : Customer.GenderFemale);
            builder.Property<DateOnly>(nameof(Customer.Birthday))
                .HasColumnName("Birthday")
                .HasConversion(x => x.ToDateTime(TimeOnly.MinValue), x => DateOnly.FromDateTime(x));
            builder.Property<string>(nameof(Customer.Address))
                .HasColumnName("Address");
            builder.Property<string>(nameof(Customer.CitizenID))
                .HasColumnName("CitizenID");
            builder.Property<string>(nameof(Customer.PhoneNumber))
                .HasColumnName("PhoneNumber");
            builder.HasKey(nameof(Customer.Id));
        }

        public static void ConfigureService(this EntityTypeBuilder<Service> builder, bool includeServiceTypeRelationship = true)
        {
            builder.ToTable("service");
            builder.BigIntegerIdProperty(nameof(Service.Id), "ID", "SE", "3");
            builder.Property<string>(nameof(Service.Name))
                .HasColumnName("Name");
            builder.Property<double>(nameof(Service.UnitPrice))
                .HasColumnName("UnitPrice");
            builder.Property<string>(nameof(Service.Unit))
                .HasColumnName("Unit");
            builder.OptionalBigIntegerIdProperty(nameof(Service.ServiceTypeId   ), "ServiceTypeID", "ST", "2");
            builder.HasKey(nameof(Service.Id));

            if (includeServiceTypeRelationship)
            {
                builder.HasOne<ServiceType>(nameof(Service.ServiceType))
                .WithMany(nameof(ServiceType.Services))
                .HasForeignKey(nameof(Service.ServiceTypeId))
                .OnDelete(DeleteBehavior.Restrict);
            }
            else builder.Ignore(nameof(Service.ServiceType));
        }

        public static void ConfigureServiceType(this EntityTypeBuilder<ServiceType> builder)
        {
            builder.ToTable("servicetype");
            builder.BigIntegerIdProperty(nameof(ServiceType.Id), "ID", "ST", "2");
            builder.Property<string>(nameof(ServiceType.Name))
                .HasColumnName("Name");
            builder.HasKey(nameof(ServiceType.Id));
        }

        public static void ConfigureCancelationStatus(this EntityTypeBuilder<CancelationStatus> builder)
        {
            builder.ToTable("cancelationstatus");
            builder.BigIntegerIdProperty(nameof(CancelationStatus.Id), "ID", "SD", "5");
            builder.Property<string>(nameof(CancelationStatus.Reason))
                .HasColumnName("Reason");
            builder.Property<double>(nameof(CancelationStatus.Fee))
                .HasColumnName("Fee");
            builder.Property<DateTime>(nameof(CancelationStatus.Time))
                .HasColumnName("Time");
            builder.HasKey(nameof(CancelationStatus.Id));
        }

        public static void ConfigureUseServiceDetail(this EntityTypeBuilder<UseServiceDetail> builder,
            bool includeServiceRelationship = true, bool includeStaffRelationship = true, bool includeInvoiceRelationship = true,
            bool includeCancelationStatusRelationship = true)
        {
            builder.ToTable("useservicedetail");
            builder.BigIntegerIdProperty(nameof(UseServiceDetail.Id), "ID", "SD", "5");
            builder.Property<int>(nameof(UseServiceDetail.Quantity))
                .HasColumnName("Quantity");
            builder.Property<DateTime>(nameof(UseServiceDetail.UsedTime))
                .HasColumnName("UsedTime");
            builder.BigIntegerIdProperty(nameof(UseServiceDetail.InvoiceId), "InvoiceID", "IN", "4");
            builder.BigIntegerIdProperty(nameof(UseServiceDetail.ServiceId), "ServiceID", "SE", "3");
            builder.BigIntegerIdProperty(nameof(UseServiceDetail.StaffId), "StaffID", "SA", "3");
            builder.HasKey(nameof(UseServiceDetail.Id));

            if (includeServiceRelationship)
            {
                builder.HasOne<Service>(nameof(UseServiceDetail.Service))
                    .WithMany().HasForeignKey(nameof(UseServiceDetail.ServiceId))
                    .IsRequired().OnDelete(DeleteBehavior.Restrict);
            }
            else builder.Ignore(nameof(UseServiceDetail.Service));
            if (includeStaffRelationship)
            {
                builder.HasOne<Staff>(nameof(UseServiceDetail.Staff))
                    .WithMany().HasForeignKey(nameof(UseServiceDetail.StaffId))
                    .IsRequired().OnDelete(DeleteBehavior.Restrict);
            }
            else builder.Ignore(nameof(UseServiceDetail.Staff));
            if (includeInvoiceRelationship)
            {
                builder.HasOne<Invoice>(nameof(UseServiceDetail.Invoice))
                    .WithMany(nameof(Invoice.UseServices))
                    .HasForeignKey(nameof(UseServiceDetail.InvoiceId))
                    .IsRequired().OnDelete(DeleteBehavior.Restrict);
            }
            else builder.Ignore(nameof(UseServiceDetail.Invoice));
            if (includeCancelationStatusRelationship)
            {
                builder.HasOne<CancelationStatus>(nameof(UseServiceDetail.CancelationStatus))
                    .WithOne().IsRequired(false).OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey<CancelationStatus>(nameof(CancelationStatus.Id));
            }
            else builder.Ignore(nameof(UseServiceDetail.CancelationStatus));
        }

        public static void ConfigureRole(this EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("role");
            builder.BigIntegerIdProperty(nameof(Role.Id), "ID", "RO", "2");
            builder.Property<string>(nameof(Role.Name))
                .HasColumnName("Name");
            builder.HasKey(nameof(Role.Id));
        }

        public static void ConfigureStaff(this EntityTypeBuilder<Staff> builder,
            bool includeRoleRelationship = true, bool includePermissionGroupRelationship = true, bool includeAccountRelationship = true)
        {
            builder.ToTable("staff");
            builder.BigIntegerIdProperty(nameof(Staff.Id), "ID", "SA", "3");
            builder.Property<string>(nameof(Staff.FullName))
                .HasColumnName("FullName");
            builder.Property<bool>(nameof(Staff.Gender))
                .HasColumnName("Gender")
                .HasConversion(x => x == Staff.GenderMale ? "0" : "1", x => x == "0" ? Staff.GenderMale : Staff.GenderFemale);
            builder.Property<DateOnly>(nameof(Staff.Birthday))
                .HasColumnName("Birthday")
                .HasConversion(x => x.ToDateTime(TimeOnly.MinValue), x => DateOnly.FromDateTime(x));
            builder.Property<string>(nameof(Staff.Address))
                .HasColumnName("Address");
            builder.Property<string>(nameof(Staff.CitizenId))
                .HasColumnName("CitizenID");
            builder.Property<string>(nameof(Staff.Phone))
                .HasColumnName("PhoneNumber");
            builder.Property<double>(nameof(Staff.Salary))
                .HasColumnName("Salary");
            builder.Property<StaffState>(nameof(Staff.Status))
                .HasColumnName("Status")
                .HasConversion(x => (int)x, x => (StaffState)x);
            builder.Ignore(nameof(Staff.CanDelete));
            builder.Ignore(nameof(Staff.Resign));
            builder.Property<string>(nameof(Staff.ImageLink))
                .HasColumnName("ImageLink")
                .IsRequired(false);
            builder.OptionalBigIntegerIdProperty(nameof(Staff.RoleId), "RoleID", "RO", "2");
            builder.OptionalBigIntegerIdProperty(nameof(Staff.GroupId), "PermissionGroupID", "", "2");
            builder.OptionalBigIntegerIdProperty(nameof(Staff.AccountId), "UID", "", "3");
            builder.HasKey(nameof(Staff.Id));

            if (includeRoleRelationship)
            {
                builder.HasOne<Role>(nameof(Staff.Role))
                    .WithMany().IsRequired(false)
                    .HasForeignKey(nameof(Staff.RoleId))
                    .OnDelete(DeleteBehavior.Restrict);
            }
            else builder.Ignore(nameof(Staff.Role));
            if (includePermissionGroupRelationship)
            {
                builder.HasOne<PermissionGroup>(nameof(Staff.Group))
                    .WithMany().IsRequired(false)
                    .HasForeignKey(nameof(Staff.GroupId))
                    .OnDelete(DeleteBehavior.Restrict);
            }
            else builder.Ignore(nameof(Staff.Group));
            if (includeAccountRelationship)
            {
                builder.HasOne<Account>(nameof(Staff.Account))
                    .WithOne().IsRequired(false)
                    .HasForeignKey<Staff>(nameof(Staff.AccountId))
                    .OnDelete(DeleteBehavior.SetNull);
            }
            else builder.Ignore(nameof(Staff.Account));
        }

        public static void ConfigureAccount(this EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("account");
            builder.BigIntegerIdProperty(nameof(Account.Uid), "UID", "", "3");
            builder.Property<string>(nameof(Account.UserName))
                .HasColumnName("UserName");
            builder.Property<string>(nameof(Account.Password))
                .HasColumnName("Password");
            builder.Property<AccountState>(nameof(Account.State))
                .HasColumnName("Status")
                .HasConversion(x => (int)x, x => (AccountState)x);
            builder.Ignore(nameof(Account.Linked));
            builder.Ignore(nameof(Account.Disabled));
            builder.Ignore(nameof(Account.Permissions));
            builder.Property<string>(nameof(Account.SerializedPermissions))
                .HasColumnName("Permissions");
            builder.HasKey(nameof(Account.Uid));
        }

        public static void ConfigurePermissionGroup(this EntityTypeBuilder<PermissionGroup> builder)
        {
            builder.ToTable("permissiongroup");
            builder.BigIntegerIdProperty(nameof(PermissionGroup.Id), "ID", "", "2");
            builder.Property<string>(nameof(PermissionGroup.Name))
                .HasColumnName("Name");
            builder.Property<string>(nameof(PermissionGroup.SerializedPermissions))
                .HasColumnName("Permissions");
            builder.HasKey(nameof(PermissionGroup.Id));
        }

        public static void BigIntegerIdProperty<T>(this EntityTypeBuilder<T> builder, string propertyName, string columnName, string prefix, string length) where T : class
        {
            builder.Property<BigInteger>(propertyName)
                .HasColumnName(columnName)
                .HasConversion(x => prefix + x.ToString("D" + length), x => BigInteger.Parse(x.Substring(prefix.Length)));
        }

        public static void OptionalBigIntegerIdProperty<T>(this EntityTypeBuilder<T> builder, string propertyName, string columnName, string prefix, string length) where T : class
        {
            builder.Property<BigInteger?>(propertyName)
                .HasColumnName(columnName).IsRequired(false)
                .HasConversion(x => x == null ? null : prefix + x.Value.ToString("D" + length),
                        x => x == null ? null : BigInteger.Parse(x.Substring(prefix.Length)));
        }
    }
}
