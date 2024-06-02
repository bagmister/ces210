using System;

class Rectangle: Shape
{
   private double _length;
   private double _width;

   public override double GetArea(){
    var area = _length * _width;
    return area;
   }
   public double SetLength(double length){
      return _length = length;
   }
   public double SetWidth(double width){
      return _width = width;
   }
   public double GetLength(){
      return _length;
   }
   public double GetWidth(){
      return _width;
   }
}