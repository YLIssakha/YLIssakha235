const int majorite = 18;

Console.WriteLine("Veillez saisir votre prénom");
string prenom = Console.ReadLine();



Console.WriteLine("Veilleez saisir votre âge");
string age = Console.ReadLine();
int ageEntier = Convert.ToInt32(age);
//int ageEntier = Convert.Parse(age);

// ON peut faire une execussion dans une chaine de carat avec le $ et {}
// il s'agit d'une interpolation
Console.WriteLine($"Bonjour {prenom} vous avez {ageEntier} ans");



// concatenation

Console.WriteLine("Bonjour " + prenom + " vous avez " + ageEntier + " ans");
// string bonjourchaine = "bonjour" + "christophe";



bool majeur = (ageEntier >= majorite);


if (majeur == true){
    Console.WriteLine("Vous êtes majeur");
}

else{
    Console.WriteLine("Vous êtes mineur");

}
// string bonjour = "bonjour";
// string prenom = "christophe";

//le '' pour definir un caractère spécial par contre " " chaine de caractère

//char apostrophe = '\'';
//string jacquesADit = "jacques a dit \" Debout ! \"";


// TRANSFORMATION VERS UNE CHAINE
// ToString ==> vers chine de ca

// int valeurEntiere = 42;
// string entierChaine = valeurEntiere.ToString (); // convertis la valeur 

// // 

// string valeurChaine = "33";
// int trenteTrois = Convert.ToInt32(valeurChaine);

// // tres pratique et Parse 

// string saisie = Console.ReadLine();
// int saisieEntier = int.Parse(saisie); // parse offre une facilité plus que le convert