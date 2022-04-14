using helloWorldInCSharp;

First first = new();
first.Id = 123;
Console.WriteLine(first.Id);
First.One();
First.Three();
//First.Two();
//First.Four();
Console.WriteLine(Second.y);//static variable, so no need of instance
Second second= new();
Console.WriteLine(second.x);//non-static variable, accesiing through instance
const float pi = 3.14f;
Console.WriteLine(pi);