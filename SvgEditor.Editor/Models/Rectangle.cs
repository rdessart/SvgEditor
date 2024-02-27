using System.Xml.Serialization;

namespace SvgEditor.Editor.Models;

[XmlRoot("rect")]
public class Rectangle : Shape
{
    [XmlAttribute("x")]
    public int X {get; set;}

    [XmlAttribute("y")]
    public int Y {get; set;}

    [XmlAttribute("width")]
    public int Width {get; set;}

    [XmlAttribute("height")]
    public int Height {get; set;}
}