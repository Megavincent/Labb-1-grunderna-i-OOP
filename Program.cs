namespace Labb_1_grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                
                Circle circle1 = new Circle(5);
                
                Console.WriteLine("Area of Circle with Radius 5: " + circle1.GetArea());

              
                Circle circle2 = new Circle(6);
                
                Console.WriteLine("Area of Circle with Radius 6: " + circle2.GetArea());
            }
        }
    }
    public class Circle
    {
       
        private double radius;

   
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
   
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
