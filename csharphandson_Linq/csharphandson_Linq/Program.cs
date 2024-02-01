using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    /* The following console application tries to solve the following
    * 1. List the sales made by a salesperson
    * 2. Pay the sales commission for a salesperson
    */

    public static void Main()
    {
        var sales = new List<Sales>() {
new Sales(){ InvoiceId = "INV102", SalesPerson="Bill", Amount=1200,CommissionPaid=60 },
new Sales(){ InvoiceId = "INV107", SalesPerson="Dave", Amount=4200,CommissionPaid=0 },
new Sales(){ InvoiceId = "INV106", SalesPerson="Paul", Amount=16000,CommissionPaid=0},
new Sales(){ InvoiceId = "INV103", SalesPerson="Mark", Amount=18000,CommissionPaid=0 },
new Sales(){ InvoiceId = "INV101", SalesPerson="Sayeed", Amount=2000,CommissionPaid=0 },
new Sales(){ InvoiceId = "INV109", SalesPerson="Christine", Amount=5200,CommissionPaid=0 },
new Sales(){ InvoiceId = "INV108", SalesPerson="Bill", Amount=6000,CommissionPaid=0 },
new Sales(){ InvoiceId = "INV104", SalesPerson="Mary", Amount=9800,CommissionPaid=0 },
new Sales(){ InvoiceId = "INV105", SalesPerson="Bill", Amount=12000,CommissionPaid=0 },
new Sales(){ InvoiceId = "INV100", SalesPerson="Melissa", Amount=12000,CommissionPaid=0 }
};
        /* Display all Bill's Sales Records(Both paid and unpaid).
        */

        // Implement here
        foreach (var sale in sales)
        {
            if (sale.SalesPerson == "Bill")
            {
                Console.WriteLine("Bill's Sales Records(Both paid and unpaid) : " + sale.InvoiceId + " " + sale.SalesPerson + " " + sale.Amount + " " + sale.CommissionPaid);
            }
        }

        /* Call a method from SalesRep class to pay the sales commission for Bill(only for the sales records with CommissionPaid=0)
        * Display the total commission that has been paid
        */

        // Implement here
        SalesRep sp = new SalesRep("Bill", sales);      // Calling method

        double bill = sp.salescommission();     // Calling function for calculating sales commission

        Console.WriteLine($"Total commission paid for Bill: {bill} ");    // displaying total sales commission for Bill paid
    }
}
public class Sales
{
    public string InvoiceId { get; set; }
    public string SalesPerson { get; set; }
    public double Amount { get; set; }
    public double CommissionPaid { get; set; }
}


public class SalesRep
{
    public string SalesPerson { get; }
    public List<Sales> SalesList { get; }

    public SalesRep(string salePerson, List<Sales> salesList)
    {
        SalesPerson = salePerson;
        SalesList = salesList;
    }

    /* Write a method to pay the sales commission for the Sales made by this salesperson
*
* Assumptions:
* Only the unpaid sales(CommissionPaid=0) records will be used for payment
*
*
* Calculation for the CommissionPaid:
* Sales commission is calculated as described below
* 5% of the invoice amount <= $2000 +
* 4% of the invoice amount >$2000 and <=$10000 +
* 3% of the invoice amount >$10000
* For examples,
* 1. If Amount is 1000 then CommissionPaid will be $50
* 2. If Amount is 6000 then CommissionPaid will be 260
* 3. If Amount is 12000 then CommissionPaid will be $480
*
* Pay
* _salesList.CommissionPaid should be updated with the correct amount as described above
* Method should return the total commission just paid.
*/


    // Implement here
    public double salescommission()
    {
        double totalcommision = 0.0;

        foreach (var s in SalesList)
        {
            if (s.CommissionPaid == 0 && s.SalesPerson == "Bill")
            {
                if (s.Amount <= 2000)
                {
                    s.CommissionPaid = ((5.0 / 100) * s.Amount);
                }
                else if (s.Amount > 2000 && s.Amount <= 10000)
                {
                    s.CommissionPaid = ((4.0 / 100) * s.Amount);
                }
                else if (s.Amount > 10000)
                {
                    s.CommissionPaid = ((3.0 / 100) * s.Amount);
                }

                //totalcommision = totalcommision + s.CommissionPaid;     // updated commsission  (only 0 commsission)
            }
            totalcommision = totalcommision + s.CommissionPaid;     // updated total commsission (both 60 + 0 commsission)
        }
        return totalcommision;
    }

    public void UpdatedList()
    {
        Console.WriteLine($"Updated List for {SalesPerson}\n");

        foreach (Sales item in SalesList)
        {
            Console.WriteLine($"Sales Records of {item.SalesPerson} : {item.InvoiceId}  {item.Amount} {item.CommissionPaid}");
        }
    }

}

