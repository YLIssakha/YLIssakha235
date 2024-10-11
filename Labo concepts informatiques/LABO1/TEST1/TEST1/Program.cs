// // See https://aka.ms/new-console-template for more information
// //Console.WriteLine("Hello, World!");


// // See https://aka.ms/new-console-template for more information
// //Console.WriteLine("Hello, World!");


// //using System;
// //using System.Collections.Generic;


// Console.WriteLine( "Recherche des racines de ax^2 + bx + c" );

// Console.WriteLine("coefficient a:" );
// double a = Convert.ToDouble(Console.ReadLine());
// //double a = Console.Read();

// Console.WriteLine("coefficient b:" );
// double b = Convert.ToDouble(Console.ReadLine());
// //double b = Console.Read();

// Console.WriteLine("coefficient c:" );
// double c = Convert.ToDouble(Console.ReadLine());
// //double c = Console.Read();

// Double delta = b*b - 4*a*c;

// if (delta < 0){
//     Console.WriteLine("Pas de racine réelle");

// }

// else if (delta == 0){
//     Double x = -b / 2*a;
//     Console.WriteLine("une racine double réelle : x1=x2 " + x);
// }

// else{
//     Double x1 = (-b-Math.Sqrt(delta))/ (2*a);
//     Double x2 = (-b+Math.Sqrt(delta))/ (2*a);
//     Console.WriteLine("deux racines distincetes réelles x1 et x2" +  x1 + "Et" + x2);

// }




Chapter ch =  new Chapter("Apprendre à programmer", 1);
Console.WriteLine(ch);


Book info = new Book("Python");
info.addChapter(1, "variation");
info.addChapter(2, "of_else");
info.addChapter(3, "loop");


