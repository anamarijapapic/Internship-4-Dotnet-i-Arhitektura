using Data.Entities;

namespace Domain
{
    public class Domain
    {
        public static User CurrentUser;
        public static Computer Computer;
        public static Order Order = new();
        public static Receipt Receipt;
        public static OrderHistory OrderHistory = new();
    }
}
