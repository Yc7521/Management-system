using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace 管理系统.Models
{
    public struct Role
    {
        public const string Unknow = "unknow";
        public const string Admin = "admin";
        public const string User = "user";
        public static readonly string[] Roles = new[] { Unknow, Admin, User };
    }
}
