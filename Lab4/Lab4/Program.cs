using Lab4;

# region variables
var root = FileRoot.fileRoot;
char sep = Path.DirectorySeparatorChar;
// first,last,address,city,state,zip
var file = root + sep + "data" + sep + "data.csv";
var newFile = root + sep + "data" + sep + "data.psv";
List<Person> people = new List<Person>();
Address address1;
#endregion

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

Console.WriteLine("Data has been read.\nSorting now...");
people.Sort();

using (var sw = new StreamWriter(newFile,append: false))
{
    foreach (var p in people)
    {
        sw.WriteLine(p);
    }
}

Console.WriteLine("Data has been sorted and your new file has been made...\nThank you for using.");
Console.ReadLine();