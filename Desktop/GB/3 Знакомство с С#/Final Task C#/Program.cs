// Контрольное задание C#

string [] arrayFirst =  {"Hello", "2", "World", ":)"};
Console.WriteLine($"[{string.Join(", ", arrayFirst)}]");

string [] arraySecond = FindStringBelow4(arrayFirst);
Console.WriteLine($"[{string.Join(", ", arraySecond)}]");

string [] FindStringBelow4(string[] arrayStart)
{
int n=0,j=0;
foreach (string item in arrayStart)
{
   if (item.Length<4) n++;
}
string []arrayResult= new string [n];
foreach (string item in arrayStart)
{
   if (item.Length<4) {arrayResult[j]=item; j++;}
}
return arrayResult;
}