// See https://aka.ms/new-console-template for more information
string fname = "mountpoint/bind.txt";
Console.WriteLine("Hello, World!");

Console.WriteLine("trying to write to a file bind.txt");
 File.AppendAllText(fname, $"hello:{DateTime.Now + Environment.NewLine}");

Console.WriteLine("trying to read it now");
var content = File.ReadAllText(fname);
Console.WriteLine($"content is:{Environment.NewLine + content + Environment.NewLine}");
Console.WriteLine("end");
