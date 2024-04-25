using MongoDB.Bson;
using System;

namespace Otus.Teaching.Pcf.Administration.WebHost.Models
{
    public class RoleItemResponse
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}