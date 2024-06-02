using System;
using System.Formats.Asn1;

class Square : Shape
{
   private double _side;
   public override double GetArea(){
    var Area = _side * _side;
    return Area;
   }
   public void SetSide(double Side){
      _side = Side;
   }
   public double GetSide(){
      return _side;
   }
}