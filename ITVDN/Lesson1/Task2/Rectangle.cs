namespace Task2
{
    class Rectangle
    {
       double side1, side2;
        public int MyProperty { get; set; }
        public Rectangle (double side1, double side2)    // Создание коструктора
        { 
            this.side1 = side1;
            this.side2 = side2;
        }
        
        double AreaCalculator()         // Создание метода 
        {
            return side1 * side2;
        }
        public double Area              // Сoздания метода доступа      
        {
            get { return this.AreaCalculator(); }
        }

        double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
        public double Perimeter
        {
            get { return this.PerimeterCalculator(); }
        }

    }

}
