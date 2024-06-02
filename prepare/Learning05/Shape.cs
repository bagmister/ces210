using System;

class Shape
{
   private string _color;

   public string GetColor(){
    return _color;
   }
   public void SetColor(string color){
    color = _color;
   }
   public virtual double GetArea(){
    return 0;
   }
}