
namespace ClasificacionesCategorias.Class
{
    public class calcular
    {
        public void ClasificacionesCategorias()

        {
            int Clasificacion_1 = 0;
            int Clasificacion_2 = 0;
            int Clasificacion_3 = 0;
            decimal promedio = 0;

            try
            {
                Console.WriteLine("Digite la Clasificacion #1");
                Clasificacion_1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite la Clasificacion #2");
                Clasificacion_2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite la Clasificacion #3");
                Clasificacion_3 = Convert.ToInt32(Console.ReadLine());

                promedio = (Clasificacion_1 + Clasificacion_2 + Clasificacion_3) / 3;
                Console.WriteLine($"Su promedio de calificaciones es: {promedio}.");

                if (promedio >= 7)

                {
                    Console.WriteLine("Promocionado!");
                }

                if (promedio >= 4 && promedio < 7)

                {
                    Console.WriteLine("Regular");
                }
                if (promedio < 4)
                {
                    Console.WriteLine("Reprobado!");
                }
            }
            catch (Exception ex)

            {
                Console.WriteLine($"Error en los datos suministrados. {ex.Message}");
            }
          

        }
}    } 