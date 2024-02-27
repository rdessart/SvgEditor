using System.Xml.Serialization;

namespace SvgEditor.Editor.Models;

[XmlRoot("polyline")]
public class PolyLine : Shape
{
    [XmlAttribute("points")]
    public string Points 
    {
        get => string.Join(" ", Coordinates.ToArray()); 
        set {}
    }

    [XmlIgnore]
    public List<Coordinate> Coordinates {get; set;} = [];
}