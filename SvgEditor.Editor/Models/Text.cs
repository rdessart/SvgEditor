using System.Xml.Serialization;

namespace SvgEditor.Editor.Models;

[XmlRoot("Text")]
public class Text : Shape
{
    [XmlAttribute("x")]
    public string? X { get; set; }

    [XmlAttribute("y")]
    public string? Y { get; set; }

    [XmlAttribute("font-size")]
    public string? fontSize { get; set; } = null!;

    [XmlAttribute("font-family")]
    public string? fontFamily { get; set; } = null!;

    [XmlText] 
    public string Content { get; set; } = null!;

    [XmlElement(ElementName="tspan")] 
	public List<TextSpan>? Tspan { get; set; } 

}