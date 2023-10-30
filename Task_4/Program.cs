namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphicsEditor editor = new GraphicsEditor();

            Circle circle = new Circle(5, 10, 15);
            Rectangle rectangle = new Rectangle(20, 25, 30, 35);
            Triangle triangle = new Triangle(40, 45, 50);
            Group group = new Group(55, 60);

            group.AddPrimitive(circle);
            group.AddPrimitive(rectangle);

            editor.AddPrimitive(circle);
            editor.AddPrimitive(rectangle);
            editor.AddPrimitive(triangle);
            editor.AddPrimitive(group);

            editor.DrawAll();

            circle.Scale(1.5f);
            group.Scale(0.8f);

            Console.WriteLine("After Scaling:");
            editor.DrawAll();
        }
    }
}