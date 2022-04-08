using C_sharp_Shop;

Console.WriteLine("Inserisci IVA: ");
int nostraIva = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci nome prodotto: ");
string nomeProdotto = Console.ReadLine();

Console.WriteLine("Inserisci descrizione prodotto: ");
string descrizioneProdotto = Console.ReadLine();

Console.WriteLine("Inserisci prezzo prodotto: ");
double prezzoProdotto = double.Parse(Console.ReadLine());


Prodotto PrimoProdotto = new Prodotto(nomeProdotto, descrizioneProdotto, prezzoProdotto, nostraIva);

Console.WriteLine("---------PRODOTTO 1--------------");
PrimoProdotto.StampaProdottiSenzaIva();
Console.WriteLine("-----------------------");
PrimoProdotto.StampaProdottiConIva();
Console.WriteLine("-----------------------");
PrimoProdotto.StampaProdottiConcatenati();
Console.WriteLine();

Prodotto SecondoProdotto = new Prodotto("Alette Di Pollo", "Carne bianca", 6.99, 10);

Console.WriteLine("---------PRODOTTO 2--------------");
SecondoProdotto.StampaProdottiSenzaIva();
Console.WriteLine("-----------------------");
SecondoProdotto.StampaProdottiConIva();
Console.WriteLine("-----------------------");
SecondoProdotto.StampaProdottiConcatenati();
Console.WriteLine();

Prodotto TerzoProdotto = new Prodotto("Gin", "Alcolico", 26.78, 22);

Console.WriteLine("---------PRODOTTO 3--------------");
TerzoProdotto.StampaProdottiSenzaIva();
Console.WriteLine("-----------------------");
TerzoProdotto.StampaProdottiConIva();
Console.WriteLine("-----------------------");
TerzoProdotto.StampaProdottiConcatenati();
