using IEnumerable_;
using System.Collections;


Depo depo = new Depo();
ArrayList list = new ArrayList() { "Pergel", "Defter", "Cetvel" };
foreach (var item in list)
{
    Console.WriteLine(item);
}

foreach (var item in depo) //IEnumerable arayüzü kullanmassak çalışmaz, çünkü getenumarator ihtiyac var
{
    Console.WriteLine(item);
}