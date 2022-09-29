Console.WriteLine("введите имя");
string name = Console.ReadLine();
if( name.ToLower() == "маша" ){
    Console.WriteLine("Ура, это же Маша!");
} else{
    Console.Write("Privet,");
    Console.Write(name);
}