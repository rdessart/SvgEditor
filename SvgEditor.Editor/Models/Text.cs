using System.Xml.Serialization;

namespace SvgEditor.Editor.Models;

[XmlRoot("Text")]
public class Text : Shape
{
    private int? _x;
    private int? _y;
    [XmlIgnore]
    public int? X {
        get => _x;
        set => _x = value;
    }
    [XmlIgnore]
    public int? Y {
        get => _y;
        set => _y = value;
    }

    [XmlAttribute("x")]
    public string? XText 
    { 
        get => _x is null ? null : _x.ToString(); 
        set{} 
    }

    [XmlAttribute("y")]
    public string? YText
    { 
        get => _y is null ? null : _y.ToString(); 
        set{} 
    }

    [XmlAttribute("font-size")]
    public string? fontSize { get; set; } = null!;

    [XmlAttribute("font-family")]
    public string? fontFamily { get; set; } = null!;

    [XmlText] 
    public string Content { get; set; } = null!;

    [XmlElement(ElementName="tspan")] 
	public List<TextSpan>? Tspan { get; set; } 

}