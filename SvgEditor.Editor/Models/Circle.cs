using System.Xml.Serialization;

namespace SvgEditor.Editor.Models;

[XmlRoot("circle")]
public class Circle : Shape
{
    [XmlAttribute("cx")]
    public int Cx { get; set; }

    [XmlAttribute("cy")]
    public int Cy { get; set; }

    [XmlAttribute("r")]
    public int R { get; set; }
}