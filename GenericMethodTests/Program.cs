// Get the MethodInfo for the generic method:
using GenericMethods;
using System.Reflection;

MethodInfo mi = typeof(Example).GetMethod("Generic")!;

// Assign the desired type (e.g., int) to the type parameter:
MethodInfo miConstructed = mi.MakeGenericMethod(typeof(ExampleImplementation));


object[] myArgs = [new ExampleImplementation { myValue = "1" }];
// Invoke the constructed generic method:
IEnumerable<IExample> ret = (IEnumerable<IExample>)miConstructed.Invoke(null, parameters: myArgs);


miConstructed = mi.MakeGenericMethod(typeof(ExampleImplementation2));

myArgs = [new ExampleImplementation2 { myValue = 100 }];
// Invoke the constructed generic method:
IEnumerable<IExample> ret2 = (IEnumerable<IExample>?)miConstructed.Invoke(null, parameters: myArgs);

Console.ReadLine();