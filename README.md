# CsvReader

#H2 Sample

```c#
var personReader = new CsvReader<Person>("TestData/person.csv");
var locationReader = new CsvReader<Location>("TestData/location.csv");
var testCsv = new CsvReader<TestCsv>("TestData/test.csv");

Console.WriteLine("Persons:");
foreach (var person in personReader)
{
    Console.WriteLine($"{person.Id} {person.FirstName} {person.LastName}");
}

Console.WriteLine("\nLocations:");
foreach (var location in locationReader)
{
    Console.WriteLine($"{location.Id} {location.Name}");
}

Console.WriteLine("\nTestCsv:");
foreach (var test in testCsv)
{
    Console.WriteLine($"{test.String} {test.Decimal} {test.ULongNull}");
}
```
