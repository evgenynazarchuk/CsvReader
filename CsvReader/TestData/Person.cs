namespace CsvReader
{
    public class Person : CsvAutoMapperModel
    {
        public int? Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
