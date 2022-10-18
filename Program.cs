Console.Write("Введите 2 чила через разделитель ';' : ");
String Temp_numbers = Console.ReadLine();
int length = Temp_numbers.Length;
int pozition =Temp_numbers.IndexOf(';');
string Numbers_1_str_tmp = Temp_numbers.Substring(0, pozition);
string Numbers_2_str_tmp = Temp_numbers.Substring(pozition+1, length-pozition-1);
float Numbers_1 = float.Parse(Numbers_1_str_tmp);
float Numbers_2 = float.Parse(Numbers_2_str_tmp);
if (Numbers_1>Numbers_2)
{
  Console.Write("max = ");
  Console.Write(Numbers_1);
}
else
{
  if (Numbers_1==Numbers_2)
  {
    Console.Write("оба числа равны. max =");
    Console.Write(Numbers_1);
  }
  else
  {
    Console.Write("max = ");
    Console.Write(Numbers_2);
  }
}
// по хорошему надо делать проверку на 1) наличие разделителя как такового, 2) правильность написания чила, (коррекно ли поставлена точка, нет ли прибелов и т.д.)
