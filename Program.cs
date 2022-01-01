using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Iniciando com datas
            var data = new DateTime();
            //Data Atual
            data = DateTime.Now;

            //Obtendo valores da data
            data = new DateTime(2020, 10, 12, 8, 23, 14);

            //Formatando datas
            data = DateTime.Now;

            var formatada = String.Format("{0:dd-MM-yyyy hh:mm:ss}", data);


            // Padrões de formatação
            formatada = String.Format("{0:t}", data);
            formatada = String.Format("{0:T}", data);
            formatada = String.Format("{0:d}", data);
            formatada = String.Format("{0:D}", data);
            formatada = String.Format("{0:f}", data);
            formatada = String.Format("{0:g}", data);
            formatada = String.Format("{0:r}", data);
            formatada = String.Format("{0:s}", data);
            formatada = String.Format("{0:u}", data);
            // Console.WriteLine(formatada);



            //Adicionando Valores
            data = data.AddDays(12);
            data = data.AddMonths(1);
            data = data.AddYears(1);


            // Comparando datas
            data = DateTime.Now;

            if (data.Date == DateTime.Now.Date)
                Console.WriteLine("É igual");


            // CultureInfo - Globalização
            var pt = new CultureInfo("pt-BR");
            //Pega a cultura da maquina
            var atual = CultureInfo.CurrentCulture;
            //Console.WriteLine(DateTime.Now.ToString("d", pt));


            //Timezone
            var dateTime = DateTime.UtcNow;
            data = dateTime;
            data = dateTime.ToLocalTime();
            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

            // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);

            //TimeSpan
            var timeSpan = new TimeSpan();

            
            Console.WriteLine(timeSpan);

           


            Console.WriteLine(data);


        }
    }
}
