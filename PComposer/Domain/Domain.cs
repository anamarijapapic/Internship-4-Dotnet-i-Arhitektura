using Data.Entities;
using System;

namespace Domain
{
    public class Domain
    {
        public static User CurrentUser;
        public static Computer Computer = new();
    }
}
