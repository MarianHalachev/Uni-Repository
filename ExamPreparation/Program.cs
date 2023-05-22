using ExamPreparation.Interfaces;
using ExamPreparation.Models;

namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garden g = new Garden();
            string namespaceModels = "ExamPreparation.Models.";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") { break; }
                //Rose 3
                string[] data = input.Split(" ");
                Type t = Type.GetType(namespaceModels + data[0]);
                for (int i = 0; i < int.Parse(data[1]); i++)
                {
                    var obj = Activator.CreateInstance(t);
                    g.Items.Add((IGardenItem)obj);
                }
            }

            double beautyScore = g.Beauties.Sum(x => x.BeautyScore);
            double waterRequired = g.Items.Sum(x => x.WaterRequired);
            double energy = g.Foods.Sum(x => x.Energy);
            Console.WriteLine($"BeautyScore: {beautyScore}");
            Console.WriteLine($"WaterRequired: {waterRequired}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}