// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// var person = new Person { FirstName = "Tracy", LastName = "Smith"};

// [Person(FirstName ="Tracy", LastName ="Smith")]

// public class Person: Attribute
// {
//     required public string FirstName { get; init; }
//     public string? MiddleName { get; init; }
//     required public string LastName { get; init; }
// }

var result = AddAll(new[] { 1, 2, 3, 4, 5});
Console.WriteLine(result);

// int AddAll(int[] values)
// {
//     int result = 0;
//     foreach (var value in values)
//     {
//         result += value;
//         return result;
//     }
// }

T AddAll <T>(T[] values) where T : INumber<T>
{
    T result = T.Zero;
    foreach (var value in values)
    {
        result += value;
    }
     return result;
}