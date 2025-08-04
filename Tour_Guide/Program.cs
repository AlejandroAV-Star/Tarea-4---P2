using System;


namespace TourGuide
{
    class Program
    {
        static void Main()
        {
            var service = new LugarHistoricoService();

            var lugar = new LugarHistoricoDto
            {
                Nombre = "Alcázar de Colón",
                Descripcion = "Residencia virreinal del siglo XVI",
                Horario = "9:00 AM - 5:00 PM",
                ImagenUrl = "https://example.com/alcazar.jpg"
            };

            var resultado = service.Add(lugar);
            Console.WriteLine(resultado.Message);

            var lugares = service.GetAll();
            foreach (var l in lugares.Data)
            {
                Console.WriteLine($"{l.Id}: {l.Nombre} - {l.Horario}");
            }
        }
    }
}
