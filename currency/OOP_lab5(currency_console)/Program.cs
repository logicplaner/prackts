using System;

namespace OOP_lab5_currency_console_
{
    class Product 
    {
        private string Name;
        private double Price;
        private int Quantity;
        private string Producer;
        private double Weight;
        private string Date;
        private string Type;



        private Currency[] Cost;
       /* public Product(int j)
        {
            Cost = new Currency[j];
            Cost[0] = new Currency();
        }*/
        
            public Product()
        {

        }
        public Product (string name, double price, int quantity, string producer, double weight, string date, string type)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
            Date = date;
            Type = type;
            //Cost = cost;
        }
        public string _name
        {
            get;
            set;
        }
        public string _type
        {
            get;
            set;
        }
        public double _price
        {
            get;
            set;
        }
        public double _date
        {
            get;
            set;
        }

        public int _quantity
        {
            get;
            set;
        }

        public string _producer
        {
            get;
            set;
        }

        public double _weight
        {
            get;
            set;
        }

        public void SetProduct()
        {
            string name;
            double price;
            int quantity;
            string producer;
            double weight;
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            this.Name = name;
            Console.WriteLine("Enter price:");
            price = Convert.ToDouble(Console.ReadLine());
            this.Price = price;
            Console.WriteLine("Enter quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());
            this.Quantity = quantity;
            Console.WriteLine("Enter producer:");
            producer = Console.ReadLine();
            this.Producer = producer;
            Console.WriteLine("Enter weight:");
            weight = Convert.ToDouble(Console.ReadLine());
            this.Weight = weight;
            Console.WriteLine("Enter type of date: \n1. Hours \n2. Day \n3. Month\n");
            int caseSwitch;
            caseSwitch = Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Hours");
                    this.Type = "Hours";
                    break;
                case 2:
                    Console.WriteLine("Day");
                    this.Type = "Day";
                    break;
                case 3:
                    Console.WriteLine("Month");
                    this.Type = "Month";
                    break;
                default:
                    Console.WriteLine("Hours");
                    this.Type = "Hours";
                    break;
            }


        }
        public void GetPriceInUAH()
        {
            Console.WriteLine(this.Name);
        }

        public void GetTotalPrice ()
        {
            Console.WriteLine("Price for all products: ");
            Console.WriteLine(Price*Quantity);
        } 
        public void GetProductInfo()
    {
            Console.WriteLine("Name: ");
            Console.WriteLine(this.Name);
            Console.WriteLine("Price: ");
            Console.WriteLine(this.Price);
            Console.WriteLine("Quantity: ");
            Console.WriteLine(this.Quantity);
            Console.WriteLine("Producer: ");
            Console.WriteLine(this.Producer);
            Console.WriteLine("Weight: ");
            Console.WriteLine(this.Weight);
            Console.WriteLine("Day of exp. :");
            Console.WriteLine(this.Type);

    }
    }
  

    class Currency
    {
        private string NameV;
        private float ExRate;

        public Currency(string namev, float exRate)
        {
            NameV = namev;
            ExRate = exRate;
        }

        public string _namev
        {
            get { return NameV; }
            set { NameV = value; }
        }
        public float _exrate
        {
            get { return ExRate; }
            set { ExRate = value; }
        }
        private protected static void Main()
    {

            Product pr = new Product();
            pr.SetProduct();
           // pr.GetPriceInUAH();
            //pr.GetTotalPrice();
            pr.GetProductInfo();
    }
    }
 
}


