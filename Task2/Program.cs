using Task2;
DataOperation dataOperation = new DataOperation();
DateTime date= DateTime.Now;
List<Customer> customerList = new List<Customer>
{
    new Customer
    {
        Id = 1,
        Name ="Md Rony Mondol",
        Address="Choto Kumira"
    },
    new Customer
    {
        Id = 2,
        Name ="Abdur Halim Khan",
        Address="Nisindara"
    },
    new Customer
    {
        Id = 3,
        Name ="Ovi",
        Address="Colony"
    },
};
List<Purchase> purchaseList = new List<Purchase>
{
   new Purchase
   {
       CustomerId = 1,
       Amount =250.5,
       PurchasedOn = date,
   },
   new Purchase
   {
       CustomerId = 2,
       Amount =350.5,
       PurchasedOn = date,
   },
   new Purchase
   {
       CustomerId = 3,
       Amount =450.5,
       PurchasedOn = date,
   },
};  
var data=dataOperation.MergeData(customerList,purchaseList);
foreach (var item in data)
{
    Console.WriteLine($"Customer Name: {item.cutomerName} Purchase Amount: {item.purchaseAmount} Purchase on: {item.purchaseDate}");
}