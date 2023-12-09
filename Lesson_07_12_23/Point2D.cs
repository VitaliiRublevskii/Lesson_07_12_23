using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_12_23
{
    internal class Point2D
    {
        public int pointX {  get; set; }
        public int pointY { get; set; }
        public double vector { get; set; }
        public string path2D = "FilePoint2D.txt";

        public Point2D() 
        {
            pointX = 5;
            pointY = 10;
        }

        public Point2D(int one, int two)  // конструктор создания точки с помощью рандома
        {
            Random rnd = new Random();
            this.pointX = rnd.Next(one, two);
            this.pointY = rnd.Next(one, two);
            this.vector = Math.Sqrt((this.pointX * this.pointX) + (this.pointY * this.pointY));
        }  

        public void WritePointFile()  // метод записи одной точки в файл
        {
            File.WriteAllText(path2D, pointX.ToString() + " " + pointY.ToString());
        }
        public void ReadPointFile()  //  метод считывания точки из файла
        {
            string[] strings = File.ReadAllLines(path2D);
            for (int i = 0; i < strings.Length; i++)
            {
                string[] point = strings[i].Split(new char[] { ' ' });
                Console.WriteLine($" x = {point[0]},  y = {point[1]}");
            }
        }


        public void AddPointToFile()  //  метод добавлений точет в файл (для массива) 
        {
            File.AppendAllText(path2D, pointX.ToString() + " " + pointY.ToString() + "\n");
        }

    
        
        public Point2D ReadPointFromFile(string path2D)  //  метод считывания массива точек из файла
        {
            string[] strFromFile = File.ReadAllLines(path2D);  // сюда массив записывается в формате  strFromFile[i] = 80 87
            //Point2D[] point2DFromFile = new Point2D[strFromFile.Length];
            Point2D p = new Point2D();
            for (int i = 0; i < strFromFile.Length; i++)
            {
                string[] strStr = strFromFile[i].Split(new char[] { ' ' });  // сюда записываем строку 80 87; 
                int a = 0;
                
                for (int j = 0; j < strStr.Length; j++)
                {
                    p.pointX = int.Parse(strStr[0]);
                    p.pointY = int.Parse(strStr[1]);
                    
                }
                Console.WriteLine($"{p.pointX} {p.pointY}");
                //point2DFromFile[i] = p;
            }
            return p;
        }

       



    }
}
