using System.Numerics;
using System.Xml.Serialization;

namespace SvgEditor.Editor.Models;

[XmlRoot("svg")]
public class Svg(string title, string description, int width, int height)
{
    [XmlIgnore]
    public int HeightPixel {get; set;} = height;

    [XmlIgnore]
    public int WidthPixel {get; set;} = width;

    [XmlAttribute("height")]
    public string Height 
    {
        get => $"{HeightPixel}px";
        set {}
    }

    [XmlAttribute("width")]
    public string Width {
        get => $"{WidthPixel}px";
        set {}
    }

    [XmlAttribute("version")]
    public string Version {
        get => "2.0";
        set {}
    }

    [XmlElement("title")]
    public string Title { get; set; } = title;

    [XmlElement("desc")]
    public string Description { get; set; } = description;
    [XmlElement("rect")]
    public List<Rectangle> Rectangles{get; set;} = [];
    [XmlElement("circle")]
    public List<Circle> Circles{get; set;} = [];

    [XmlElement("polyline")]
    public List<PolyLine> PolyLines{get; set;} = [];

    [XmlElement("text")]
    public List<Text> Texts{get; set;} = [];

    public Svg() : this("", "", 0, 0)
    {
        
    }
}