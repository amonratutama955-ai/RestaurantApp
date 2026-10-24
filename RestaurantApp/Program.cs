using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT.1/1");
        }
    }
}
public class Restaurant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string type { get; set; }
    public double rate { get; set; }

    public Restaurant(int id, string name,string t, double r)
    {
        Id = id;
        Name = name;
        type = t;
        rate = r;
    }
}


