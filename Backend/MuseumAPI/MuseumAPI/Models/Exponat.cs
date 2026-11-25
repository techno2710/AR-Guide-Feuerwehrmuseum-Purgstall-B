using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MuseumAPI.Models;

namespace MuseumAPI.Models;

[BsonKnownTypes(typeof(Fotos), typeof(Audios), typeof(Text), typeof(Videos), typeof(Models3D))]
public class Exponat
{
    //Id für MongoDB
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = "";

    //Name des Ausstellungsstücks
    public string Name { get; set; } = "";
    
    //Kategorie des Ausstellungsstücks
    [BsonRepresentation(BsonType.String)]
    public Kategorie Kategorie { get; set; }
    
    //Beschreibung der Ausstellungsstücke
    public string Beschreibung { get; set; } = "";
}