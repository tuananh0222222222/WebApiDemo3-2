



using System.Text;

Console.OutputEncoding =System.Text.Encoding.UTF8;



string? dbname = "";

string? db = "";
string? user = "";
string?  pass = "";

Console.WriteLine("Nhập ten co so du lieu :");
dbname = Convert.ToString(Console.ReadLine());
Console.WriteLine("Nhập db :");
db = Convert.ToString(Console.ReadLine());
Console.WriteLine("Nhập user  :");
user = Convert.ToString(Console.ReadLine());
Console.WriteLine("Nhập pass :");
pass = Convert.ToString(Console.ReadLine());

StringBuilder sb = new StringBuilder();


sb.Append($"Data Source={dbname};");
sb.Append($"Persist Security Info=True;");
sb.Append($"Initial Catalog={db};");
sb.Append($"User ID={user};");
sb.Append($"Password={pass}");


Console.WriteLine(sb.ToString());

