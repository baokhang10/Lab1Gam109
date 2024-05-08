using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Maps
{
    public string id;
    public string Name;
    public static string _inGame = "Lien minh huyen thoai";
    public Maps(string id, string name)
    {
        this.id = id;
        this.Name = name;
    }
    public string ShowData()
    {
        return "ID :" + id + " | Name :" + Name + " | inGame :" + _inGame;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var maps1 = new Maps("2024", "URF");
            Console.WriteLine(maps1.ShowData());

            var maps2 = new Maps ("2024", "URF")
            {
                id = "2024",
                Name = "URF"
            };
            Console.WriteLine(maps2.ShowData());
            Console.ReadLine();
        }
    }
}
