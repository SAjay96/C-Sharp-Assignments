abstract public class Shape
    {
    public abstract void CalculteArea();


    }
 public class Reactangle :Shape
{
    private int length;
    private int width;
    private double areaofrectangle;
    

    public Reactangle(int l,int w)
    {
            length = l;
        width = w;

        
    }
    public override void CalculteArea()
    {
        areaofrectangle = length * width;
    }
    public void Display()
    {
        Console.WriteLine($"area of rectangleis {areaofrectangle}");
    }
}

