using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Vita_Track_Server.Models
{
    public class PatientModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonProperty("id")]
        public string? Id { get; set; }
        [JsonProperty("firstName")]
        public string? FirstName { get; set; }
        [JsonProperty("lastName")]
        public string? LastName { get; set; }
        [JsonProperty("email")]
        public string? Email { get; set; }
        [JsonProperty("phone")]
        public string? Phone { get; set; }
        [JsonProperty("dateOfBirth")]
        public string? DateOfBirth { get; set; }
        [JsonProperty("password")]
        public string? Password { get; set; }
        [JsonProperty("associatedDoctors")]
        public List<DoctorModel>? AssociatedDoctors { get; set; }
    }
}
