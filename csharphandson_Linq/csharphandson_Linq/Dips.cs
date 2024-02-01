//using System.Collections.Generic;

//public class Dips
//{
//    private static void Main(string[] args)
//    {
//        var sales = new List<Sales>() {
//            new Sales(){ InvoiceId = "INV102", SalesPerson="Bill", Amount=1200,CommissionPaid=60 },
//            new Sales(){ InvoiceId = "INV107", SalesPerson="Dave", Amount=4200,CommissionPaid=0 },
//            new Sales(){ InvoiceId = "INV106", SalesPerson="Paul", Amount=16000,CommissionPaid=0},
//            new Sales(){ InvoiceId = "INV103", SalesPerson="Mark", Amount=18000,CommissionPaid=0 },
//            new Sales(){ InvoiceId = "INV101", SalesPerson="Sayeed", Amount=2000,CommissionPaid=0 },
//            new Sales(){ InvoiceId = "INV109", SalesPerson="Christine", Amount=5200,CommissionPaid=0 },
//            new Sales(){ InvoiceId = "INV108", SalesPerson="Bill", Amount=6000,CommissionPaid=0 },
//            new Sales(){ InvoiceId = "INV104", SalesPerson="Mary", Amount=9800,CommissionPaid=0 },
//            new Sales(){ InvoiceId = "INV105", SalesPerson="Bill", Amount=12000,CommissionPaid=0 },
//            new Sales(){ InvoiceId = "INV100", SalesPerson="Melissa", Amount=12000,CommissionPaid=0 }
//        };
//        // string name = Console.ReadLine();

//        foreach (var item in sales)
//        {
//            if (item.SalesPerson == "Bill")
//            {
//                Console.WriteLine($"Sales Records of {item.SalesPerson} : {item.InvoiceId} , {item.Amount} , {item.CommissionPaid}");
//            }
//        }

//        SalesRep sr = new SalesRep("Bill", sales);

//        double cpaid = sr.PaySales(sales);
//        Console.WriteLine(cpaid);

//        sr.UpdatedList(sales);
//    }
//}

//public class Sales
//{
//    public string InvoiceId { get; set; }
//    public string SalesPerson { get; set; }
//    public double Amount { get; set; }
//    public double CommissionPaid { get; set; }
//}

//public class SalesRep
//{
//    public string SalesPerson { get; }
//    public List<Sales> SalesList { get; }

//    public SalesRep(string salePerson, List<Sales> salesList)
//    {
//        SalesPerson = salePerson;
//        SalesList = salesList;
//    }
//    public double PaySales(List<Sales> salesList)
//    {
//        double totalCommisionPaid = 0.0;

//        foreach (Sales s in salesList)
//        {
//            if (s.CommissionPaid == 0 && s.SalesPerson == "Bill")
//            {
//                if (s.Amount <= 2000)
//                {
//                    s.CommissionPaid += (5.0 / 100) * s.Amount;
//                }
//                else if (s.Amount > 2000 && s.Amount <= 10000)
//                {
//                    s.CommissionPaid += (4.0 / 100) * s.Amount;
//                }
//                else if (s.Amount > 10000)
//                {
//                    s.CommissionPaid += (3.0 / 100) * s.Amount;
//                }
//                totalCommisionPaid += s.CommissionPaid;
//            }
//            //totalCommisionPaid += s.CommissionPaid;
//        }
//        return totalCommisionPaid;                  //updated commision
//    }

//    public void UpdatedList(List<Sales> salesList)
//    {
//        List<Sales> ulist = new List<Sales>();
//        ulist = salesList;

//        Console.WriteLine("Updated List\n");

//        foreach (Sales item in ulist)
//        {
//            Console.WriteLine($"Sales Records of {item.SalesPerson} : {item.InvoiceId}  {item.Amount} {item.CommissionPaid}");
//        }
//    }
//}
