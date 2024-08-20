using System.Text.Json;

namespace CLI_Task_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char? select = null;
            do
            {
                Console.WriteLine
                (@"
Selecciona una opcion:
    1- Ver tareas
    2- Agregar tareas
    3- Editar tareas
    4- Eliminar tareas
            ");

                select = Console.ReadKey().KeyChar;
                if (select >= '1' && select <= '4')
                {
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa el numero correcto.");
                }
            }while(select < '1' || select > '4');
            Console.Clear();
        }
    }
}
