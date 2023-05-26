using System;
using System.Globalization;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /*
            // Guid
            var id = Guid.NewGuid();
            id.ToString();

            //id = new Guid("27cfb7e8-4ce9-4738-911a-1ab531a5d83b");
            Console.WriteLine(id); 

            // Interpolação
            var price = 10.2;
            Console.WriteLine($@"O preço do 
            produto é \nR${price.ToString("F2", CultureInfo.InvariantCulture)}");

            // Comparação de String
            var textoTeste = "Testando";
            Console.WriteLine(textoTeste.CompareTo("Testando"));
            Console.WriteLine("Estou testando agora".Contains("testando"));
            Console.WriteLine("Estou testando agora".Contains("Testando", StringComparison.OrdinalIgnoreCase));

            // StartWith / EndsWith
            var texto = "Este é um texto teste";
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.EndsWith("teste"));

            // Equals
            Console.WriteLine(texto.Equals("Este texto é um Teste", StringComparison.OrdinalIgnoreCase));

            // IndexOf
            Console.WriteLine(texto.IndexOf("texto"));
            Console.WriteLine(texto.LastIndexOf("s"));

            // Métodos Adicionais
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.Insert(5, "AQUI "));
            Console.WriteLine(texto.Remove(4, 5));
            Console.WriteLine(texto.Length);

            Console.WriteLine(texto.Replace("Este", "Isto"));
            Console.WriteLine(texto.Split(" ")[0]);

            Console.WriteLine(texto.Trim());

            var resultado = texto.Substring(5, 5);
            Console.WriteLine(resultado);

            // StringBuilder
            var textoBuilder = new StringBuilder();
            textoBuilder.Append(texto);
            textoBuilder.Append("Isto é um texto");
            Console.WriteLine(textoBuilder);
            

            // DateTime
            // Retornando a data de agora
            var data = DateTime.Now;

            // Definindo uma data
            var data = new DateTime(2023, 05, 12, 8, 11, 00);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine((int)data.DayOfWeek);
            Console.WriteLine((int)data.DayOfYear);

            // y = year, M = month, d = day, h = hour, m = minute, s = second
            var formatada = String.Format("{0:y}", data);
            Console.WriteLine($"{data:dd/MM/yyyy hh:mm:ss.fff z}");

            //Padrões de formatação
            // d = short date, t = short time, D = long date, T = long time, f = combination D + T, g = conbination d + t, s = datetime type json, u = datetime type database
            Console.WriteLine($"{data:d}");
            Console.WriteLine($"{data:t}");
            Console.WriteLine($"{data:g}");
            Console.WriteLine($"{data:s}");

            // Adicionando Valores
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(-20));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1));

            // Comparação de Datas
            if(data.Date == DateTime.Now.Date)
                Console.WriteLine("É igual");
            
            Console.WriteLine(data);

            // Cultura de Datas
            var pt = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(data.ToString("D", pt));
            Console.WriteLine(data.ToString("D", en));
            Console.WriteLine(data.ToString("D", de));
            Console.WriteLine(data.ToString("D", atual));
            
            
            // Timezone
            var dateTime = DateTime.UtcNow;
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("New Zealand Standard Time");
            Console.WriteLine(timezoneAustralia);

            var hourAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
            Console.WriteLine(hourAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach(var timezone in timezones){
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
                Console.WriteLine("-----------");
            }

            // Timespan
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanosegundos);

            var timeHoraMinutoSegundo = new TimeSpan(10, 31, 10);
            Console.WriteLine(timeHoraMinutoSegundo);
            */

            Console.WriteLine(DateTime.DaysInMonth(2023, 5));
            Console.WriteLine(IsWeekDay(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        }

        static bool IsWeekDay(DayOfWeek today){
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}