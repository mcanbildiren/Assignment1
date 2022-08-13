// ArrayList: Boyutu bilinmeyen verileri eklemek için kullanılır. Belirli bir boyutu yoktur, veri eklendikçe değişir. İçine değer olarak başka bir collection alabilir.
// Methodları: Add/AddRange, Insert/InsertRange, Remove/RemoveRange, RemoveAt, Sort, Reverse, Contains, Clear, CopyTo, GetRange, IndexOf, ToArray
using System.Collections;

Console.WriteLine("ArrayList Example: ");
ArrayList arrayList1 = new ArrayList()
                {
                    100, 200, 600
                };

ArrayList arrayList2 = new ArrayList()
                {
                    300, 400, 500
                };
arrayList1.InsertRange(2, arrayList2);

foreach (var item in arrayList1) 
{ 
    Console.WriteLine(item);
}
Console.WriteLine("--------------------------------");

// List: Belirli bir tipteki verileri tutar. Index şeklinde barındırdığı için bir değerin liste numarası üzerinden işlem yapılabilir. Index 0'dan başlar. ArrayList'e göre daha hızlıdır. 
// Methodları: Add/AddRange, BinarySearch, Clear, Contains, Find, Foreach, Insert/InsertRange, Remove/RemoveAt/RemoveRange, Sort, TrimExcess, TrueForAll
Console.WriteLine("List Example: ");
var cities = new List<string>();
cities.Add("New York");
cities.Add("London");
cities.Add("Mumbai");
cities.Add("Chicago");
cities.Add(null);
cities.Remove("London");

foreach (var item in cities)
{
    Console.WriteLine(item);
}
Console.WriteLine("--------------------------------");

// SortedList: Bir değere karşılık gelen başka bir değer şeklinde veri tutar. Key-Value ilişkisi vardır. İçerisindeki Key'leri ve onlara karşılık gelen Value'leri, Key'lere göre, artan bir şekilde sıralayarak saklar. Key'ler unique olmalıdır.
Console.WriteLine("SortedList Example: ");
SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };

Console.WriteLine("Başlangıçta atanmış olan değerler: ");

foreach (KeyValuePair<int, string> item in numberNames)
{
    Console.WriteLine("key: {0}, value: {1}", item.Key, item.Value);
}

numberNames.Add(6, "Six");
numberNames.Add(2, "Two");
numberNames.Add(4, "Four");

Console.WriteLine("Yeni değerler eklendikten sonraki hali: ");

foreach (var item in numberNames)
{
    Console.WriteLine("key: {0}, value: {1}", item.Key, item.Value);
}
Console.WriteLine("--------------------------------");

// Dictionary: Bir değere karşılık başka bir değerin tutulduğu collection tipidir. Veri tipleri aynı olmak zorunda değildir. Key - value olarak değerler birbirine bağlıdır.
Console.WriteLine("Dictionary Example: ");
var currency = new Dictionary<string, double>(){
    {"Dolar", 17.9},
    {"Euro", 18.4},
    {"Sterlin", 21.8},
    {"Bitcoin", 438754.18},
    {"Altın", 1039.3}
};

foreach (var item in currency)
{
    Console.WriteLine("{0}: {1} TL", item.Key, item.Value);
}
Console.WriteLine("--------------------------------");

// Hashtable: Dictionary interface'i kullanarak aynı mantıkta çalışır. Elemanları DictionaryEntry olarak saklanır. Herhangi bir değerde veri saklayabilir.
Console.WriteLine("Hashtable Example: ");
var currency2 = new Hashtable(){
    {"Dolar", 17.9},
    {"Euro", 18.4},
    {"Sterlin", 21.8},
    {"Bitcoin", 438754.18},
    {"Altın", 1039.3}
};

foreach (DictionaryEntry dictionaryEntry in currency2)
{
    Console.WriteLine("{0}: {1} TL", dictionaryEntry.Key, dictionaryEntry.Value);
}
Console.WriteLine("--------------------------------");

// Stack: Son giren ilk çıkar mantığıyla veri saklar. Indexleme desteklemez. Push methodu ile yeni veri eklenir. Pop en baştaki veriyi siler ve geri döndürür.
// Methodları: Push, Pop, Peek, Contains, Clear
Console.WriteLine("Stack Example: ");
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);

foreach (var item in stack)
{
    Console.WriteLine(item);
}
Console.WriteLine("--------------------------------");

// Queue: İlk giren ilk çıkar mantığıyla veri saklar. Veriler sıraya göre eklenir. Veri güncelleme yapılamaz.
// Methodlar: Enqueue, Dequeue, Peek, Contains, Clear
Console.WriteLine("Queue Example: ");
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Dequeue();

foreach (var item in queue)
{
    Console.WriteLine(item);
}
Console.WriteLine("--------------------------------");

