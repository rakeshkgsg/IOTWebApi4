using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace IotWebApi.Entities
{
    public class RoleEto : BaseEto
    {
        public string? RoleName { get; set; } = string.Empty;
        public int? Context { get; set; }
        public string? Description { get; set; } = string.Empty;
    }
}
