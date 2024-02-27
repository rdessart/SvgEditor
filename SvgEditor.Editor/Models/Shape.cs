using System.Xml.Serialization;

namespace SvgEditor.Editor.Models;

[
    XmlInclude(typeof(Circle)), 
    XmlInclude(typeof(Rectangle)),
    XmlInclude(typeof(Text)),
    XmlInclude(typeof(TextSpan)),
    XmlInclude(typeof(PolyLine))
]
public abstract class Shape 
{
    private int? _strokeWidth;
    private int? _strokeDashArray;
    private double? _opacity;

    [XmlIgnore]
    public int? StrokeWidth 
    {
        get => _strokeWidth; 
        set => _strokeWidth = value;
    }

    [XmlIgnore]
    public int? StrokeDasharray 
    {
        get => _strokeDashArray; 
        set => _strokeDashArray = value;
    }

    [XmlIgnore]
    public double? Opacity 
    {
        get => _opacity; 
        set => _opacity = value;
    }

    [XmlAttribute("stroke")]
    public string? Stroke { get; set; }

    

    [XmlAttribute("stroke-width")]
    public string? StrokeWidthText 
    { 
        get  => StrokeWidth == null ? null : StrokeWidth.ToString();
        set{}
    }

    [XmlAttribute("stroke-dasharray")]
    public string? StrokeDasharrayText { 
        get => _strokeDashArray == null ? null : _strokeDashArray.ToString();
        set {}
    }

    [XmlAttribute("fill")]
    public string? Fill { get; set;}
  
    [XmlAttribute("opacity")]
    public string? OpacityText { 
        get => _opacity == null ? null : _opacity.ToString();
        set {}
    }
}