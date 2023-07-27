using System.Globalization;

//Colocando os dados no DateTime.
using System.ComponentModel;
using System.Reflection;

DateTime data = DateTime.Today;
Console.WriteLine(data);

//Colocando as horas no DateTime.
DateTime data2 = new DateTime(2004, 03, 26, 12, 26, 30);
Console.WriteLine(data2);

//Colocando dados informados pelo usuario.

/*
Console.WriteLine("informe o dia:");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("informe o mes:");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("informe o ano:");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("informe o hora:");
int hour = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("informe o minuto:");
int minute = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("informe o segundo:");
int second = Convert.ToInt32(Console.ReadLine());

DateTime data3 = new DateTime(year, month, day, hour, minute, second);
Console.WriteLine(data3);*/

//informando os dados no proprio DateTime.
DateTime data4 = DateTime.Parse("11-09-2001");
Console.WriteLine(data4);

//Mostra qual foi o dia da semana.
Console.WriteLine(data4.DayOfWeek);
//Mostra qual é o numero do dia perante o ano.
Console.WriteLine(data4.DayOfYear);

//Mostra o horario atual e o horario de grendwish.
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.UtcNow);

//Retornar o dia da semana em string.
Console.WriteLine(data.ToString("dddd", new CultureInfo("pt-BR")));

//Armazenar horas.
TimeSpan ts = new TimeSpan(10, 5, 18);

//Calcular datas.
TimeSpan ts2 = data.Subtract(data2);
Console.WriteLine(ts2.Days);

//DateOnly pega só a data.
DateOnly dol = new DateOnly(2004, 03, 26);
Console.WriteLine(dol);

//comparando datas.
int difDatas = DateTime.Compare(data, data2);
int dif = data.CompareTo(data2);
Console.WriteLine("O resultado é: {0}",difDatas);
Console.WriteLine("O resultado é: {0}",dif);

//====================================================================================================================================
//LISTAS
//====================================================================================================================================

/*double[] notas = new double[3];
Console.WriteLine("Digite a 1° nota do aluno:");
notas[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a 2° nota do aluno:");
notas[1] = Convert.ToInt32(Console.ReadLine());
notas[2] = (notas[0] + notas[1]) / 2;
Console.WriteLine($"Nota 1: {notas[0]}\nNota 2: {notas[1]}\nMedia: {notas[2]}");*/

List<string> list = new List<string>();
list.Add("mulekeNeutro");
list.Add("dante");
list.Add("samasquini");
list.Add("jonas");
list.Add("abrel");
list.Sort();
list.Insert(0, "Aldebair");

list.Remove("jonas");
list.RemoveAt(3);

foreach(string str in list)
{
    Console.WriteLine(str);
}
