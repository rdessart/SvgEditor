using System.Xml.Serialization;

namespace SvgEditor.Editor.Models;

[XmlInclude(typeof(Circle)), XmlInclude(typeof(Rectangle))]
public abstract class Shape {
    [XmlAttribute("stroke")]
    public string Stroke { get; set; } = "Blakc";

    [XmlAttribute("stroke-width")]
    public int StrokeWidth { get; set; }

    [XmlAttribute("stroke-dasharray")]
    public int StrokeDasharray { get; set; }

    [XmlAttribute("fill")]
    public string Fill { get; set; } = "Blue";

    [XmlAttribute("opacity")]
    public double Opacity { get; set; } = 1.0;
}