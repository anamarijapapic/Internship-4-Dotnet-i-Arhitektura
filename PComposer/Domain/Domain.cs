using Data.Entities;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class Domain
    {
        public static User CurrentUser;
        public static Computer Computer;
        public static Order Order = new();
    }
}
