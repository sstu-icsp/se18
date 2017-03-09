using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*TriangleChecker. Модуль для определения типа треугольника на основе значений длин трёх сторон. Функциональность:
3.1. Определять Равносторонний, Вырожденный или Неизвестный треугольник.
3.2. Определять Равнобедренный треугольник.
3.3. Бросать исключение если длина хотя бы одной из сторон меньше нуля.
3.4. Определять Прямоугольный треугольник.
 
 * 0-нет такого треугольника
 1-НЕизвестный
 2-Равнобедренный
 3-Равносторонний
 4- прямоугольный
 5-Прямоугольный и равнобедренный
 
 */

namespace ThemeUnitTesting.Library
{

    public class Triangle
    {
        public static int Pover(double side1, double side2, double side3)
       {
           if ((side1 <= 0) || (side2 <= 0) || (side3 <= 0)) { throw new ArgumentException(); }

           if ((side1 + side2 > side3) & (side1 + side3 > side2) & (side2 + side3 > side1))
           {
                    if (((side1 > side2) & (side1 > side3) & (side1 * side1 == side2 * side2 + side3 * side3)) ||
                            ((side2 > side1) & (side2 > side3) & (side2 * side2 == side1 * side1 + side3 * side3)) ||
                                 ((side3 > side2) & (side3 > side2) & (side3 * side3 == side2 * side2 + side1 * side1)))  return 4;  
               
                    if ((side1 == side2)&(side2 == side3)) return 3;

                     if ((side1 == side2) || (side1 == side3) || (side2 == side3)) return 2;
                return 1; 
           }
           else return 0;
       }
    }

    public class TriangleTDD
    { 
     public static int PvTDD (int s1, int s2, int s3)
     {
         if ((s1 <= 0) || (s2 <= 0) || (s3 <= 0)) { throw new ArgumentException(); }

         if ((s1 + s2 > s3) & (s2 + s3 > s1) & (s1 + s3 > s2)) 
         {
             if (((s1 > s2) & (s1 > s3) & (s1 * s1 == s2 * s2 + s3 * s3)) ||
                           ((s2 > s1) & (s2 > s3) & (s2 * s2 == s1 * s1 + s3 * s3)) ||
                                ((s3 > s2) & (s3 > s2) & (s3 * s3 == s2 * s2 + s1 * s1))) return 4;
             if ((s1 == s2) & (s1 == s3)) return 3; 
             if ((s1 == s2) || (s1 == s3) || (s2 == s3)) return 2;
             
             
             return 1; 
         }
         else return 0;
         
     }

          
    
    }
    class Program
    {
        static void Main(string[] args)
        {
           // Triangle.Pover(5, 5, Math.Sqrt(50));
        }
    }
}
