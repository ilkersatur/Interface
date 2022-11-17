using Interface_Ornek;

Boyahane Boyahane = new Boyahane();
Ferrari ferrari = new Ferrari();
Serce serce = new Serce();
BMX BMX = new BMX();
Console.WriteLine(ferrari);
Console.WriteLine(serce);
Console.WriteLine(BMX);

Boyahane.Boya(ferrari, ConsoleColor.Red);
Boyahane.Boya(serce, ConsoleColor.Yellow);
//Boyahane.Boya(BMX);