using System;

class Circle : Shape
{
   private double _radius;

      public virtual double GetArea(){
      var area = 2*_radius;
      return area;
   }
   public double GetRadius(){
      return _radius;
   }
   public void SetRadius(double radius){
      _radius = radius;
   }
}