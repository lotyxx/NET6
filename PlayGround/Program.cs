﻿//////////////////////////////// See https://aka.ms/new-console-template for more information
///////////////////////////////*uvod*/
///////////////////////////////* Console.WriteLine("Hello, World!");
//////////////////////////////int cislo = -13+22;
//////////////////////////////double desetinne_cislo = 308.1222;
//////////////////////////////string retezec = "ahoj svete";
//////////////////////////////char pismenko = 'A';
//////////////////////////////Console.WriteLine(10+222); */

///////////////////////////////*prvni uloha*/
///////////////////////////////*prohozeni cisel*/
///////////////////////////////*int a = 10;   
//////////////////////////////int b = 20;
//////////////////////////////int c;
//////////////////////////////c = b;
//////////////////////////////b = a;
//////////////////////////////a = c;
//////////////////////////////Console.WriteLine(a);
//////////////////////////////Console.WriteLine(b);
//////////////////////////////Console.ReadKey();
//////////////////////////////*/

///////////////////////////////* Druha uloha*/
///////////////////////////////* prevod teploty
//////////////////////////////double prevod;
//////////////////////////////Console.WriteLine("Zadej teplotu ve stupnich celsia");
//////////////////////////////double teplota = double.Parse(Console.ReadLine());
//////////////////////////////prevod = ((1.8 * teplota) + 32);
//////////////////////////////Console.WriteLine(prevod);
//////////////////////////////Console.ReadKey();
//////////////////////////////*/

///////////////////////////////* podminky - uvod */
///////////////////////////////*int a = 100;
//////////////////////////////int b = 33;
//////////////////////////////bool a_vetsi = a > b;
//////////////////////////////if (a>b)
//////////////////////////////{
//////////////////////////////    Console.WriteLine("a je vetsi nez b");
//////////////////////////////}
//////////////////////////////else
//////////////////////////////{
//////////////////////////////    Console.WriteLine("b je vetsi nez a");
//////////////////////////////}

//////////////////////////////Console.ReadKey();
//////////////////////////////*/

///////////////////////////////*podminky else if*/
///////////////////////////////*treti uloha*/

///////////////////////////////*
//////////////////////////////Console.WriteLine("Zadej tri cisla");

////////////////////////////// double a = double.Parse(Console.ReadLine());
//////////////////////////////double b = double.Parse(Console.ReadLine());
//////////////////////////////double c = double.Parse(Console.ReadLine());

//////////////////////////////if (a > b)
//////////////////////////////{
//////////////////////////////    if (a > c)
//////////////////////////////        Console.WriteLine("a je nejvetsi {0}", a);
//////////////////////////////    else Console.WriteLine("c je nejvetsi {1}", c);
//////////////////////////////}
//////////////////////////////else if (b > c)

//////////////////////////////{
//////////////////////////////    Console.WriteLine("b je nevetsi {1}", b);
//////////////////////////////}
//////////////////////////////else
//////////////////////////////{
//////////////////////////////    Console.WriteLine("c je nejvetsi {0}", c);
//////////////////////////////}
//////////////////////////////*/

///////////////////////////////* switch uloha

//////////////////////////////Console.WriteLine("Zadej číslo");
//////////////////////////////int cislo= int.Parse(Console.ReadLine());
//////////////////////////////string vystup;

//////////////////////////////   if ((cislo == 6) || (cislo == 7))
//////////////////////////////{ 
//////////////////////////////        Console.WriteLine("Zadal jsi vikend");

//////////////////////////////switch (cislo)
//////////////////////////////{
//////////////////////////////    case 1:
//////////////////////////////        Console.WriteLine("Pondělí");
//////////////////////////////        break;
//////////////////////////////    case 2:
//////////////////////////////        Console.WriteLine("utery");
//////////////////////////////        break;
//////////////////////////////    case 3:
//////////////////////////////        Console.WriteLine("streda");
//////////////////////////////        break;
//////////////////////////////    case 4:
//////////////////////////////        Console.WriteLine("ctvrtek");
//////////////////////////////        break;
//////////////////////////////    case 5:
//////////////////////////////        Console.WriteLine("Patek");
//////////////////////////////        break;

//////////////////////////////    case 6: Console.WriteLine("Sobota");

//////////////////////////////        break;
//////////////////////////////    case 7: Console.WriteLine("nedele");

//////////////////////////////        break;
//////////////////////////////    default:
//////////////////////////////        vystup = "chyba";
//////////////////////////////        break;
//////////////////////////////    }
//////////////////////////////    Console.ReadKey();
//////////////////////////////    */
///////////////////////////////*int opakovani = 10;
//////////////////////////////    for (int i = 0; i < opakovani;i++)
//////////////////////////////{
//////////////////////////////    Console.WriteLine(i);
//////////////////////////////}

//////////////////////////////int a = 10;
//////////////////////////////while (a >0)
//////////////////////////////{
//////////////////////////////    Console.WriteLine(a);
//////////////////////////////    a--;
//////////////////////////////}

//////////////////////////////*/

//////////////////////////////Console.WriteLine("Zadej cislo");
//////////////////////////////int cislo;
//////////////////////////////int vysledek = 0;
//////////////////////////////cislo=int.Parse(Console.ReadLine());
//////////////////////////////for( int i=0;i<cislo;i++)
//////////////////////////////{
//////////////////////////////    vysledek =+ i;
//////////////////////////////}
//////////////////////////////Console.WriteLine(vysledek);
////////////////////////////int vstup = 5;

////////////////////////////for ( int j = 1; j <= vstup; j++ ) {



////////////////////////////    for (int i = 1; i <= j; i++)

////////////////////////////    {
////////////////////////////        Console.Write(j);
////////////////////////////    }
////////////////////////////    Console.WriteLine();
////////////////////////////}

//////////////////////////string vstup = "";
//////////////////////////if (!string.IsNullOrEmpty(vstup))
//////////////////////////{
//////////////////////////    // neni to prazdne
//////////////////////////}

//////////////////////////DateTime datum = new DateTime(2022,04,25);
////////////////////////string date_s = "2022-04-25";
////////////////////////DateTime date = DateTime.Parse(date_s);
////////////////////////Console.WriteLine();

//////////////////////// metoda soucet dvou cisel, tvoreni
//////////////////////int Suma (int a, int b)
//////////////////////{
//////////////////////    int sum = a + b;
//////////////////////    return sum;
//////////////////////}

//////////////////////int sum = Suma(10, 15);
//////////////////////Console.WriteLine(sum);

////////////////////int cisloDnu = int.Parse(Console.ReadLine());
////////////////////Console.WriteLine(Dny);

////////////////////string Dny (int cisloDnu)
////////////////////{
////////////////////  switch (cisloDnu)
////////////////////    {
////////////////////            string vystup;
////////////////////            case 1:
////////////////////               Console.WriteLine("Pondělí");
////////////////////              break;
////////////////////            case 2:
////////////////////               Console.WriteLine("utery");
////////////////////              break;
////////////////////          case 3:
////////////////////                Console.WriteLine("streda");
////////////////////                break;
////////////////////           case 4:
////////////////////                Console.WriteLine("ctvrtek");
////////////////////             break;
////////////////////           case 5:
////////////////////                Console.WriteLine("Patek");
////////////////////                break;

////////////////////            case 6: Console.WriteLine("Sobota");
////////////////////       break;
////////////////////           case 7: Console.WriteLine("nedele");

////////////////////              break;
////////////////////          default:
////////////////////             vystup = "chyba";
////////////////////               break;
////////////////////        }
////////////////////          return vystup;
////////////////////    }


//////////////////Hello("Adam");
//////////////////Hello("Bob");
//////////////////Hello("Alice");

//////////////////void Hello (string name)
//////////////////{
//////////////////    Console.WriteLine($"Hello {name}");
//////////////////}
////////////////DateTime dob = new DateTime(2000, 11, 22);

////////////////int Vek (DateTime birth)
////////////////{
////////////////    DateTime today = DateTime.Today;
////////////////    return today.Year - birth.Year;
////////////////    if (today.Month < birth.Month) || () // dokončit


////////////////        return vek();
////////////////}
////////////////int vek = Vek(dob);
////////////////Console.WriteLine($"vek pro datum narozeni {dob} je {age}");

//////////////string pozdrav = "Ahoj ";
//////////////int delka = pozdrav.Length;
//////////////Console.WriteLine($"delka pozdravu je : {delka}");
//////////////string trimmed = pozdrav.Trim(); //odstrani mezeru v pozdravu
//////////////delka = trimmed.Length;
//////////////Console.WriteLine($"delka pozdravu je {delka}");
//////////////Console.WriteLine(pozdrav.ToLower());
//////////////Console.WriteLine(pozdrav.ToUpper());
//////////////pozdrav.Split();

////////////dodelat
////////////Console.WriteLine();       
////////////string GetDay(DenVTydnu day);
////////////{
////////////    switch (day)
////////////    {

////////////        case DenVTydnu.PONDELI:
////////////               return ("Pondělí");
////////////break;
////////////        case DenVTydnu.UTERY:
////////////               return ("utery");
////////////break;
////////////        case DenVTydnu.STREDA:
////////////                return ("streda");
////////////break;
////////////        case DenVTydnu.CTVRTEK:
////////////                return ("ctvrtek");
////////////break;
////////////           case DenVTydnu.PATEK;
////////////                return ("Patek");
////////////break;

////////////            case DenVTydnu: Console.WriteLine("Sobota");
////////////break;
////////////           case DenVTydnu: Console.WriteLine("nedele");

////////////break;
////////////            default:
////////////            return "";

////////////        }

////////////    }
////////////enum DenVTydnu // stavy ruznych veci, ktere jsou tak dane
////////////{
////////////    PONDELI,
////////////    UTERY,
////////////    STREDA,
////////////    CTVRTEK,
////////////    PATEK,
////////////    SOBOTA,
////////////    NEDELE

////////////}


//////////int sum = 0;
//////////bool konec = true;
//////////while (konec)
//////////{
//////////    Console.WriteLine("Zadavejte cisla a po ukonceni q a enter");
//////////    string vstup = Console.ReadLine();
//////////    if (vstup == "Q")
//////////        konec = false;
//////////    else
//////////        sum += int.Parse(vstup);

//////////}

//////////Console.WriteLine(sum);


////////  double NajdiVetsi (double vstup1, double vstup2) // ukazka jak se da vytvorit metoda
////////{
////////    return Math.Max(vstup1, vstup2);

////////}

//////// zmena datoveho typu  // Double se se vejde to int. Opačně to nejde
//////int a = 1;
//////ZpracujDouble(a);
//////double ZpracujDouble (double x)
//////{
//////    return x * 2;
//////}

//////// změna datoveho typu ukazka
//////int a = 1;
//////ZpracujDouble(a);
//////double d = (double)a;
//////double ZpracujDouble(double x)
//////{
//////    return x * 2;
//////}


////double d = 1.99;
////int i = (int)Math.Round(d); // Zaokrouhleni
////Console.WriteLine(Zpracuj(i));
////Console.WriteLine(i);

////int  Zpracuj(int x)
////{
////    i++;
////    x++;
////  return x * 2;
////}
//using PlayGround.Model;
//using PlayGround.Data;


////Console.WriteLine("start");
// Person person1 = new Person("Jan", "Novák");
// person1.ToString();
//Console.WriteLine(person1);
////Person p = new Person("John Doe");


////Console.WriteLine(ClassBod.GetQuadrant());

////person1.DateOfBirth = new DateTime(1999, 12, 31);


//ClassBod p1 = new ClassBod(15, 333.33);
//ClassBod p1 = new ClassBod(333,-5000);
//ClassBod p2 = new ClassBod(0, 0);


////Console.WriteLine($"x : {p1.X} y: {p1.Y}");



//double hodnotax = p1.X;
//double hodnotay = p1.Y;
//p1.X = hodnotax * 2;

//Console.WriteLine(p1);
//p1.Print();
//double plocha = p1.CalculateArea();

////for (int i = 0; i < 10; i++)
////{
//    //ClassBod p = RandomPointGenerator.GetRandomPoint();
//   // Console.WriteLine(p);
////}

//Console.WriteLine(RandomPointGenerator.GetCount());



//ClassBod p1 = RandomPointGenerator.GetRandomPoint();
//Console.WriteLine(p1);
//ClassBod p2 = new ClassBod(100, -100);
//Console.WriteLine(p2);

//ClassBod vetsi = Math2D.MaxAreaFromOrigin(p1, p2);
//Console.WriteLine($"vetsi bod ma obsah {vetsi}");





//Car c = new Car();
//c.SPZ = "AB1313";
//Kontrola.LoadStolenCars(Kontrola.stolenCarsPath);
//// CarManagement.IsCarStolen
//if (Kontrola.CanCheckStonelCars)
//{
//    bool stolen = Kontrola.IsCarStolen(c);

//    if (stolen)
//        Console.WriteLine("Auto je kradene!");
//    else
//        Console.WriteLine("auto je v poradku");
//}
//else
//{
//    Console.WriteLine("nelze kontrolovat auta, modul na kontrolu podle spz je rozbity");
//}

//Car skodovka = new Car("FFFRRGG");
//skodovka.AddKilometers(155);                //instancni metoda - vola se instance není to statická metoda
//Car auto1 = new Car("B0124578");
//Person owner1 = new Person("Marie", "Frycova");

//auto1.Owner = owner1;
//Console.WriteLine($"Auto s SPZ {auto1.SPZ} vlastní {auto1.Owner.FirstName}");
//auto1.Owner.adress.City = "Brno";
//Console.WriteLine(auto1.Owner.adress);

// Linq
//int[] cisla = { 11, 2, 13, 44, -5, 6, 127, -99, 0,256 };
//Where filtruje podle toho jakeho chceme najit uzivatele
//var x = 0;  
//var d = 12.5;
//var s = "Ahoj";
//var result = cisla.Where(cislo => cislo >= -50 && cislo <= 50); 
// Oder by
//var result = cisla.OrderByDescending(cislo => cislo);
//najit jeden prvek
//var cislo = cisla.Where(cislo => cislo == 126).FirstOrDefault();
//Console.WriteLine(cislo);
//foreach (var cislo in result)
//{
//    Console.WriteLine(cislo);
//}
//pocet kladnych cisel v kolekci
//var cnt=cisla.Where(cislo => cislo > 0).Count();
//Console.WriteLine(cnt);
// vypiste suda cisla
//var result = cisla.Where(c => c % 2 == 0);
//aboslutni hodnota, Select
//var abs = cisla.Select(cislo => Math.Abs(cislo));
// z lihchych udelat suda, ale zachovat celou kolekci;
//var result = cisla.Select(cislo => cislo % 2 == 0 ? cislo : cislo + 1);
//var result = cisla.Select(cislo => TransformujSlozite(cislo));

//foreach (var cislo in result)
//{
//    Console.WriteLine(cislo);
//}

//int TransformujSlozite (int cislo)
//{
//    if (cislo > 0)
//    {
//        return cislo + 10;
//    }
//    else if (cislo < 0)
//    {
//        return -10;
//    }
//    else
//    {
//        return cislo;
//    }

//List<Person> lide = new();
//for (int i = 0; i<50; i++)
//{
//    lide.Add(RandomPersonGenerator.GetRandomPerson());
//}
//// osoby narozene pred rokem 1989

//var result = lide.Where(osoba => osoba.DateOfBirth.Year < 1989).ToList();
//foreach (var osoba int result)
//   {
//    Console.WriteLine(osoba + "" + osoba.DateOfBirth.ToString("yyy-MM-dd"));
//   }
using PlayGround.Model;
using PlayGround.Data;

