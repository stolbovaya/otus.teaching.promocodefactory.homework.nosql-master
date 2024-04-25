using MongoDB.Bson;
using System;

namespace Otus.Teaching.Pcf.Administration.WebHost.Models
{
    public class EmployeeShortResponse
    {
        public ObjectId Id { get; set; }
        
        public string FullName { get; set; }

        public string Email { get; set; }
    }
}