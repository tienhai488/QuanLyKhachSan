namespace HotelManagement.Data.Transfer
{
    public static class EntityExtensions
    {
        //public static string? IdString(this Customer? customer)
        //    => customer == null ? null : "CU" + customer.Id.ToString("D3");
        //public static string? IdString(this Reservation? reservation)
        //    => reservation == null ? null : "RE" + reservation.Id.ToString("D5");
        public static string? IdString(this RentRoomDetail? detail)
            => detail == null ? null : "RD" + detail.Id.ToString("D5");
        public static string? IdString(this UseServiceDetail? detail)
            => detail == null ? null : "SD" + detail.Id.ToString("D5");
        public static string? IdString(this Invoice? invoice)
            => invoice == null ? null : "IN" + invoice.Id.ToString("D4");
        public static string? UidString(this Account? account)
            => account?.Uid.ToString("D3");
        public static string? IdString(this PermissionGroup? group)
            => group?.Id.ToString("D2");
        //public static string? IdString(this RoomType? type)
        //    => type == null ? null : "RT" + type.Id.ToString("D2");
        //public static string? IdString(this Convenience? convenience)
        //    => convenience == null ? null : "CO" + convenience.Id.ToString("D2");
        public static string? IdString(this CancelationStatus? cancelation)
            => cancelation == null ? null : "SD" + cancelation.Id.ToString("D5");
        //public static string? IdString(this Service? service)
        //    => service == null ? null : "SE" + service.Id.ToString("D3");
        //public static string? IdString(this ServiceType? type)
        //    => type == null ? null : "ST" + type.Id.ToString("D2");
        public static string? IdString(this Role? role)
            => role == null ? null : "RO" + role.Id.ToString("D2");
        public static string? IdString(this Staff? staff)
            => staff == null ? null : "SA" + staff.Id.ToString("D3");
    }
}
