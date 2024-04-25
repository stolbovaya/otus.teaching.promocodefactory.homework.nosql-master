using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using Otus.Teaching.Pcf.Administration.Core.Domain.Administration;

namespace Otus.Teaching.Pcf.Administration.DataAccess.Data
{
    public static class FakeDataFactory
    {
        public static List<Employee> Employees => new List<Employee>()
        {
            new Employee()
            {
                Id = ObjectId.GenerateNewId(),
                Email = "owner@somemail.ru",
                FirstName = "Иван",
                LastName = "Сергеев",
                Role = Roles.FirstOrDefault(x => x.Name == "Admin"),
                AppliedPromocodesCount = 5
            },
            new Employee()
            {
                Id = ObjectId.GenerateNewId(),
                Email = "andreev@somemail.ru",
                FirstName = "Петр",
                LastName = "Андреев",
                Role = Roles.FirstOrDefault(x => x.Name == "PartnerManager"),
                AppliedPromocodesCount = 10
            },
        };

        public static List<Role> Roles => new List<Role>()
        {
            new Role()
            {
                Id = ObjectId.GenerateNewId(),
                Name = "Admin",
                Description = "Администратор",
            },
            new Role()
            {
                Id = ObjectId.GenerateNewId(),
                Name = "PartnerManager",
                Description = "Партнерский менеджер"
            }
        };
    }
}