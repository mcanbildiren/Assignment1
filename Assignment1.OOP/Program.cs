using Assignment1.OOP.Abstraction;
using Assignment1.OOP.Encapsulation;
using Assignment1.OOP.Inheritance;
using Assignment1.OOP.Polymorphism;

// Encapsulation: Bir sınıfa ait olan bilgilere diğer sınıfların erişimini kısıtlamak için kullanılır. Methodlarda da kullanılır. get, set tanımlanarak erişim seviyesi istenilen şekilde belirlenir. Public Private Protected Internal access modifiers kullanılır.
// Encapsulation Örneği
Console.WriteLine("Encapsulation Örneği: ");
AnimalEncapsulation animalEncapsulation = new AnimalEncapsulation();

Console.WriteLine(animalEncapsulation.name1);
//Console.WriteLine(animalEncapsulation.name2); Erişim Hatası

animalEncapsulation.animalSound();
//animalEncapsulation.animalSound2(); Erişim Hatası
Console.WriteLine("-------------------------");

// Inheritance: Bir sınıfın diğerinden miras almasıdır. Mirasla field'lar ve method'lar diğer sınıfa aktarılır.
// Inheritance Örneği
Console.WriteLine("Inheritance Örneği: ");
DogInheritance dogInheritance = new DogInheritance();

dogInheritance.animalSound();

Console.WriteLine("Hayvan: {0}, Türü: {1}", dogInheritance.Type, dogInheritance.Breed);
Console.WriteLine("-------------------------");

// Abstraction: Belirli detayların saklanıp sadece gerekli bilgilerin kullanıcıyla paylaşılması için kullanılır. 
// Abstract Class: Obje yaratmak için kullanılamaz. ulaşmak için başka bi sınıftan miras alınması gerekir.
// Abstract Method: Sadece abstract sınıflar içinde kullanılabilir. İçeriği miras alınan sınıf tarafından belirlenir. Abstract Method gövdesi, kullanılacak olan sınıfın içinde yazılır.
// Abstraction Örneği
Console.WriteLine("Abstraction Örneği: ");
DogAbstraction dogabs = new DogAbstraction();
dogabs.animalSound();
Console.WriteLine("-------------------------");

// Polymorphism: Bir objenin birden fazla şekilde davranış sergiliyebilmesidir. Methodlar overload ve override yapılarak kullanılır. Ana bir sınıftan diğer sınıflara miras verilerek methodlar aktarılır.
// Polymorphism Örneği
Console.WriteLine("Polymorphism Örneği: ");
AnimalPolymorphism animalpoly = new AnimalPolymorphism();
AnimalPolymorphism dogpoly = new DogPolymorphism();
AnimalPolymorphism catpoly = new CatPolymorphism();

animalpoly.animalSound();
dogpoly.animalSound();
catpoly.animalSound();
Console.WriteLine("-------------------------");