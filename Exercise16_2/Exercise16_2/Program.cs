
using Exercise16_2.Ex1;
using Exercise16_2.Ex4;
using System.Reflection.Metadata.Ecma335;

void Ex1()
{
    var globalEmployeeWithCommition = new GlobalEmployeeWithCommition();
    var globalEmployeeWithPerformance = new GlobalEmployeeWithPerformance();
    var commisionBonus = new CommitionBonus(8, "closed premium deal with FHB tech", 1000);
    var performanceBonus = new PerformanceBonus(1000, "delivered project X4 faster");

    globalEmployeeWithCommition.AddExtraPayment(commisionBonus);
    var amountLeftToPay = globalEmployeeWithCommition.AmountLeftToPay();
    globalEmployeeWithCommition.Pay();

    globalEmployeeWithPerformance.AddExtraPayment(performanceBonus);
    var LeftToPay = globalEmployeeWithPerformance.AmountLeftToPay();
    globalEmployeeWithPerformance.Pay();

}
//__________________________________________________________________________________________________________________
void Ex2()
{
    List<Product> products = new List<Product>()
        {
            new Product { Name = "Product A", Price = 99.99 },
            new Product { Name = "Product B", Price = 19.99 },
            new Product { Name = "Product C", Price = 49.99 },
            new Product { Name = "Product D", Price = 149.99 },
            new Product { Name = "Product E", Price = 9.99 }
        };

    Console.WriteLine("Products before sorting:");
    foreach (Product p in products)
    {
        Console.WriteLine("{0}: {1:C}", p.Name, p.Price);
    }

    products.Sort();

    Console.WriteLine("\nProducts after sorting by price:");
    foreach (Product p in products)
    {
        Console.WriteLine("{0}: {1:C}", p.Name, p.Price);
    }
}
//__________________________________________________________________________________________________________________
void DataStore_Notifies_All_Subscribed_Observers_On_X_Change()
{

    var dataStore = new DataStore(5);
    var observer1 = new ImObserver();
    var observer2 = new ImObserver();
    observer1.Subscribe(dataStore);
    observer2.Subscribe(dataStore);

   
    dataStore.X = 10;

}


void DataStore_Unsubscribes_Observer()
{
    var dataStore = new DataStore(5);
    var observer1 = new ImObserver();
    var observer2 = new ImObserver();
    observer1.Subscribe(dataStore);
    observer2.Subscribe(dataStore);


    observer1.Unsubscribe(dataStore);
    dataStore.X = 10;

  
}
