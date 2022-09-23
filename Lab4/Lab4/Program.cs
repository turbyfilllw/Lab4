using Lab4;

var root = FileRoot.fileRoot;
char sep = Path.DirectorySeparatorChar;
// first,last,address,city,state,zip
var file = root + sep + "data" + sep + "data.csv";

List<Person> people = new List<Person>();
Address address1;
using (var sr = new StreamReader(file))
{
    while(!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        var info = line.Split(",");
        var FirstName = info[0];
        var LastName = info[1];
        var address = info[2];
        var city = info[3];
        var state = info[4];
        var zip = info[5];
        address1 = new Address(address, city, state, zip);
        people.Add(new Person(FirstName, LastName, address1));
    }
}
people.Sort();
foreach(var p in people)
{
    Console.WriteLine(p);
}

Console.ReadLine();