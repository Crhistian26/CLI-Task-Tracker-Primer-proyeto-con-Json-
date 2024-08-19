using System.Text.Json;

namespace CLI_Task_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string json = JsonSerializer.Serialize(new Objeto("Jose", 829567));
            Console.WriteLine(json);

            Objeto? desjson = JsonSerializer.Deserialize<Objeto>(json);

            //Console.WriteLine(
            //@$"
            //Nombre: {desjson.Nombre}
            //Numero: {desjson.Numero}
            

            //{desjson}
            //");
            string name = "Archivo.json";
            string[,] array2d =
            {
                { JsonSerializer.Serialize(new Objeto("Jose", 829567)), "hola"},
                {"hola2","hola3"}
            };
            //File.OpenWrite(name);
            //foreach (string n in newjson)
            //{
            //    File.AppendText(n);
            //}
            //Console.WriteLine(File.ReadAllText(name));

            Console.WriteLine(@$"
            0,0: {array2d[0, 0]}
            1,0: {array2d[1, 0]}
            0,1: {array2d[0, 1]}
            1,1: {array2d[1, 1]}
            ");


            string[,,] array3d = new string[,,]
            {
                {{ JsonSerializer.Serialize(new Objeto("Jose", 829567)), "hola","hola2"} , {"hola3","hola4","hola 5"}},
                {{"Hola6", "hola7","hola7"} , {"hola9","hola10","hola11"}}
            };

            Console.WriteLine(@$"
            0,0,0: {array3d[0, 0, 0]} #json
            1,0,0: {array3d[1, 0, 0]} #hola6
            0,1,0: {array3d[0, 1, 0]} #hola3
            0,0,2: {array3d[0, 0, 1]} #hola2
            ");

        }
    }
}
