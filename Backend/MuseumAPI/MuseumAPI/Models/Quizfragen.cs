using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MuseumAPI.Models;

public class Quizfragen
{
    //Id für MongoDB
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = "";

    //Fragennummer für die App
    public int FragenNr { get; set; }

    //Zu welchem Exponat / Kategorie gehört die Quizfrage
    public string ExponatId { get; set; } = "";

    //Frage selbst
    public string Frage { get; set; } = "";

    //Antwortmöglichkeiten
    public string[] Antworten { get; set; } = ["", "", "", ""];

    //Welche Antwort ist die richtige (0-3)
    public int KorrektIndex { get; set; }
}