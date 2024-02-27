namespace SvgEditor.Editor;

public struct Coordinate(float x, float y) 
{
    public float X = x;
    public float Y = y;

    public override string ToString()
    {
        return $"{X},{Y}";
    }

}

public class PathGenerator()
{
    // public 
}