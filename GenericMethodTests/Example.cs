namespace GenericMethods
{
    public interface IExample
    {

    }

    public class ExampleImplementation : IExample
    {
        public required string myValue { get; set; }
    }

    public class ExampleImplementation2 : IExample
    {
        public required int myValue { get; set; }
    }


    public class Example
    {
        public static IEnumerable<T> Generic<T>(IExample toDisplay)
            where T : IExample
        {
            var myList = new List<T>
            {
                (T)toDisplay,
            };

            return myList;
        }
    }
}
