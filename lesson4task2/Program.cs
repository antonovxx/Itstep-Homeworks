using System;

namespace lesson4task2
{
    enum Status
    {
        Dispatched, Sold, Transmitted, Written
    }
    abstract class Goods
    {
        public string id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public Goods(string id, string name, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return $"Id: {id}" +
                $"\nНазвание товара: {name}" +
                $"\nЦена: {price}" +
                $"\nКоличество: {quantity}\n";
        }
    }

    class Food : Goods
    {
        public Food (string id, string name, double price, int quantity)
            : base(id, name, price, quantity) { }
    }
    class HouseholdChemicals : Goods
    {
        public HouseholdChemicals (string id, string name, double price, int quantity)
            : base(id, name, price, quantity) { }
    }
    class Flow
    {
        public Goods [] lot { get; set; }
        public Status condition { get; set; }

        public Flow(Goods [] lot, Status Condition)
        {
            this.lot = lot;
            this.condition = condition;
        }

        public override string ToString()
        {
            return String.Format($"Состояние товара: {condition}");
        }
        public void Info()
        {
            foreach (var item in lot)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine($"Состояние товара: {condition}\n");
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            Goods[] lot =
            {
                new Food ("ID: 12313", "Apple", 58.9, 10),
                new Food ("ID: 98790", "Rice", 89.8, 20),
                new HouseholdChemicals ("ID: 43543", "Domestos", 232.2, 5),
                new HouseholdChemicals ("ID: 13123", "Soap", 157.3, 10)
            };

            Flow flow1 = new Flow(lot, Status.Dispatched);

            flow1.Info();
            flow1.condition = Status.Sold;
            flow1.Info();

        }
    }
}