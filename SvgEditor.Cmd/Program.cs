// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using SvgEditor.Editor;
using SvgEditor.Editor.Models;

static void SerializeSvg(Svg svg, string filePath)
{
    XmlSerializer serializer = new XmlSerializer(typeof(Svg));
    using (TextWriter writer = new StreamWriter(filePath))
    {
        serializer.Serialize(writer, svg);
    }
}

static void GenerateSVG()
{
    string filePath = "test.svg";

    Svg svg = new Svg("Test", "Testing SVG", 300, 300)
    {
    };

    const int strokewidth = 4;
    const int radius = 250;

    svg.Circles.Add(new Circle()
    {
        Cx = radius + strokewidth,
        Cy = radius + strokewidth,
        R = radius,
        Fill = "Transparent",
        Stroke = "Red",
        StrokeWidth = strokewidth
    });

    svg.Circles.Add(new Circle()
    {
        Cx = radius,
        Cy = radius,
        R = 100,
        Fill = "Transparent",
        StrokeDasharray = 5,
        Stroke = "Blue",
        StrokeWidth = 1
    });

    svg.Circles.Add(new Circle()
    {
        Cx = radius,
        Cy = radius,
        R = 200,
        Fill = "Transparent",
        Stroke = "Blue",
        StrokeWidth = 1
    });

    Circle circle = svg.Circles.First();
    svg.WidthPixel  = circle.Cx + radius + (2 * strokewidth);
    svg.HeightPixel = circle.Cy + radius + (2 * strokewidth);

    svg.PolyLines.Add(
    new()
    {
        Stroke = "Red",
        Opacity = 0.3,
        StrokeWidth = strokewidth,
        Fill = "Transparent",
        Coordinates = new List<Coordinate>()
        {
            new Coordinate(0 + strokewidth, radius - (int)(strokewidth / 2.0)),
            new Coordinate(2 * radius + strokewidth, radius - (int)(strokewidth / 2.0)),
        }
    });

    svg.PolyLines.Add(
    new()
    {
        Stroke = "Red",
        Opacity = 0.3,
        StrokeWidth = strokewidth,
        Fill = "Transparent",
        Coordinates = new List<Coordinate>()
        {
            new Coordinate(radius - (int)(strokewidth / 2.0), radius),
            new Coordinate(radius - (int)(strokewidth / 2.0), 2 * radius + strokewidth),
        }
    });

    svg.PolyLines.Add(
    new()
    {
        Fill = "White",
        Coordinates = new List<Coordinate>()
        {
            new Coordinate(200, 200),
            new Coordinate(215, 200),
            new Coordinate(255, 300),
            new Coordinate(240, 300),
        }
    });

    svg.Texts.Add(new Text(){
        Content = "35",
        X = 200,
        Y = 150,
        fontSize = "50px",
        fontFamily = "Verdana",
        Fill = "Red"
    });

    svg.Texts.Add(new Text(){
        Content = "25",
        X = 100,
        Y = 350,
        fontSize = "50px",
        fontFamily = "Verdana",
        Fill = "Red"
    });

    svg.Texts.Add(new Text(){
        Content = "31",
        X = 300,
        Y = 350,
        fontSize = "50px",
        fontFamily = "Verdana",
        Fill = "Red"
    });

    SerializeSvg(svg, filePath);
}

GenerateSVG();