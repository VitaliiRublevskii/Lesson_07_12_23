
using System;
using System.Drawing;
using System.IO;
using Lesson_07_12_23;

string path = "myFile.txt";


//   Задание  1  и  2
/*
string[] array1  = new string[10];



Random random = new Random();
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = random.Next(1, 20).ToString() + ",";
    
}

for (int i = 0;i < array1.Length; i++)
    Console.Write($"{array1[i]}");

File.WriteAllLines(path, array1);


string[] array2 = new string[10];
string[] array3 = new string[10];
array2 = File.ReadAllLines(path);

for (int i = 0; i < array2.Length; i++)
    Console.Write($"{array2[i]}");


int sumArr = 0;

for (int i = 0; i < array2.Length; i++)
{

    string a = array2[i].Split(',')[0];
    sumArr += int.Parse(a);
}

Console.WriteLine($"Сумма = {sumArr}");
*/





//  Задание  3  
/*
string[,] array1 = new string[5, 5];

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    
        array1[i, j] = random.Next(1, 20).ToString();
    
}


for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{array1[i, j]}");
    }
    Console.WriteLine();
}



for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        File.AppendAllText(path, (array1[i, j].ToString() + ','));  //  добавляем в файл каждый элемент массива 
    }
    File.AppendAllText(path, "\n");

}




string str = File.ReadAllText(path);
string[,] array2 = new string[5, 5];

for (int i = 0;i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array2[i, j] = File.ReadAllText(path).ToString();
    }
   

}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{array2[i, j]}");
    }
    Console.WriteLine();
}



string[] arr = new string[5];  //  сюда записываем 5 таких строк : 9,6,11,12,14,
string[] data = File.ReadAllLines(path);
for (int i = 0; i < 5; i++)
{
        arr[i] = data[i];
}


for (int i = 0; i < 5; i++)
    Console.WriteLine(arr[i]);  // выводим в консоль эти 5 строк

int arrSum = 0;

for (int i = 0; i < 5; i++)
{
    string[] inn = arr[i].Split(',');  // arr[i] - это строка   9,6,11,12,14,         inn  -  это массив цифр и запятых  одной строки
    int aaa = 0;  //   в эту переменную  записываем  по очереди и цифры и запятые
    for (int j = 0; j < inn.Length; j++)
    {
        if (int.TryParse(inn[j], out aaa))  // метод TryParse возвращает логическое значение, которое указывает, успешно
                                            // ли выполнено преобразование, и возвращает преобразованное число в параметр out. 
                                            // если строка успешно преобразовалась в int, записываем ее в     ааа
        {
            arrSum += aaa;
            continue;
        }
        
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма всех элементов массива =   {arrSum}");
*/





//  Задание  4
//  Создать класс Point2D 
//  Его экземпляр записать в файл и затем считать с выводом в консоль

//Point2D point2D = new Point2D(5, 10);
//point2D.WritePointFile();
//point2D.ReadPointFile();





//  Задание  5
//  5) Создать массив точек в 2д пространстве
//  Заполнить случайными координатами 1-99
//  Записать все в файл

Point2D point2D1 = new Point2D(1, 100);
Point2D point2D2 = new Point2D(1, 100);
Point2D point2D3 = new Point2D(1, 100);
Point2D point2D4 = new Point2D(1, 100);
Point2D point2D5 = new Point2D(1, 100);
Point2D point2D6 = new Point2D(1, 100);
Point2D point2D7 = new Point2D(1, 100);

// создаем массив точет

Point2D[] points2D = new Point2D[7];
points2D[0] = point2D1;
points2D[1] = point2D2;
points2D[2] = point2D3;
points2D[3] = point2D4;
points2D[4] = point2D5;
points2D[5] = point2D6;
points2D[6] = point2D7;

// записываем массив в файл
for (int i = 0; i < points2D.Length; i++)  // 
{
    points2D[i].AddPointToFile();
}





//  Задание  6
// считываем массив мз файла

Point2D[] points2D11 = new Point2D[7];

string path2D = "FilePoint2D.txt";
string[] strFromFile = File.ReadAllLines(path2D);  
                                                   
Point2D p = new Point2D();
for (int i = 0; i < strFromFile.Length; i++)
{
    string[] strStr = strFromFile[i].Split(new char[] { ' ' });  
    int a = 0;

    for (int j = 0; j < strStr.Length; j++)
    {
        p.pointX = int.Parse(strStr[0]);
        p.pointY = int.Parse(strStr[1]);
        
    }
    Console.WriteLine($"{p.pointX} {p.pointY}");
    //points2D11[i] =  p;
}
Console.WriteLine();
points2D11 = points2D;



Console.WriteLine("Несортированный список:");
for (int i = 0;i < points2D11.Length;i++)
    Console.WriteLine($" x = {points2D11[i].pointX}  y = {points2D11[i].pointY}  vector = {points2D11[i].vector}");

Console.WriteLine();
Console.WriteLine("Векторы");
void SortPoint2D(Point2D[] point2D11)
{
    bool vector2D = true;
    while (vector2D)
    {
        vector2D = false;           
        for (int j = 0; j < points2D11.Length - 1; j++)
        {
            Point2D xxx = new Point2D();
            if (points2D11[j].vector > points2D11[j + 1].vector)
            {
                xxx = points2D11[j];
                points2D11[j] = points2D11[j + 1];
                points2D11[j + 1] = xxx;
                vector2D = true;
            }
        }
    }
    
        
}

SortPoint2D(points2D11);
Console.WriteLine("Отсортированный список по длинне вектора:");
for (int i = 0; i < points2D11.Length; i++)
    Console.WriteLine($" x = {points2D11[i].pointX}  y = {points2D11[i].pointY}  vector = {points2D11[i].vector}");

Console.WriteLine("МЕНЮ") ;
Console.WriteLine("Веберите действие:");
Console.WriteLine("1  -  Создание точки и записи в файл");
Console.WriteLine("2  -  Считывание точки из файла и вывода в консоль");
Console.WriteLine("3  -  Сортировку точек по длинне вектора");
Console.WriteLine("4  -  Удаление  файла");

int menu = int.Parse(Console.ReadLine()); 


switch (menu)
{
    case 1:
        Console.Write("Введите точку Х : ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Введите точку Y : ");
        int y = int.Parse(Console.ReadLine());
        Point2D newPoint = new Point2D(x, y);
        newPoint.WritePointFile();
        break;
    case 2:
        Point2D newPointRead = new Point2D();
        newPointRead.ReadPointFile();
        break;
    case 3:
        SortPoint2D(points2D11);
        break;
    case 4:
        File.Delete(path);
        break;
   
    case 0:
        break;
}

//9) Написать консольную версию энциклопедии  флористики с хранением характеристик в файле и с использованием ООП )))








