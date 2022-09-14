Console.Write("Введите имя: ");
String name = Console.ReadLine();
//Console.WriteLine(name);
if (name.ToLower() == "anton") {
    Console.WriteLine("Ух ты! Это же Антон!");
}
else { 
    Console.WriteLine("Привет " + name);
}
