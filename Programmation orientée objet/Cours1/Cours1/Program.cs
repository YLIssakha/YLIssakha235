// See https://aka.ms/new-console-template for more information
using System.Security.Authentication;

Console.WriteLine("Hello, World!");

// création d'une classe Contact représentant un contact


Contact lur = new Contact("Quentin", "Lurkin");
lur.SetPhoneNumber(4249);
Console.WriteLine(lur.phonenumber);

City bxl = new City("Bruxelles");
bxl.Mayor = lur;
Console.WriteLine( bxl.Mayor.phonenumber);



Die d1 = new Die(); // Dé à 6 faces
Die d2 = new Die(12); // Dé à 12 faces

Console.WriteLine(d1.VisibleFace);
Console.WriteLine(d2.VisibleFace);

