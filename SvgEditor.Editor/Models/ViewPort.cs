using System.Xml.Serialization;

namespace SvgEditor.Editor.Models;

public class ViewPort
{
    [XmlIgnore]
    public int X0 {get; set;}
    [XmlIgnore]
    public int Y0 {get; set;}
    [XmlIgnore]
    public int Width {get; set;}
    [XmlIgnore]
    public int Height {get; set;}
    
    public override string ToString() => $"{X0} {Y0} {Width} {Height}";

    public List<int> GetViewPort() => [X0, Y0, Width, Height];

    public void SetViewPort(List<int> data)
    {
        X0 = data[0];
        Y0 = data[1];
        Width = data[2];
        Height = data[3];
    }
    public ViewPort(int x0, int y0, int widht, int height)
    {
        X0 = x0;
        Y0 = y0;
        Width = widht;
        Height = height;
    }

    public ViewPort() : this(0, 0, 0, 0)
    {}
}