using System;
namespace NovertisPharmaLtd
{
    public class Medicine
    {
        public string MedicineCode{get; set;}
        public string MedicineName{get; set;}
        public string ManufacturerName{get; set;}
        public int BatchNumber{get; set;}
        private decimal unitPrice;
        private int quantity;
        public Date ManufacturedDate{get; set;}
        public Date ExpiryDate{get; set;}
    public Medicine(string medicineCode, string medicineName, string manufacturerName, int batchNumber,decimal unitPrice, int quantity, Date manufacturedDate, Date expiryDate) 
    {
        MedicineCode = medicineCode;
        MedicineName = medicineName;
        ManufacturerName = manufacturerName;
        BatchNumber = batchNumber;
        UnitPrice = unitPrice;
        Quantity = quantity;
        ManufacturedDate = manufacturedDate;
        ExpiryDate = expiryDate;
    }


    public decimal UnitPrice{
        get {return unitPrice;}
        set 
        {
            if(value > 0){
                unitPrice = value;
            }
        }
    }

    public int Quantity{
        get {return quantity;}
        set 
        {
            if(value > 0){
                quantity = value;
            }
        }
    }
    

    

    public string Print()
    {
    return $"Medicine code: {MedicineCode}\nMedicine name: { MedicineName}\nManufacturer name: {ManufacturerName}\nBatch number: {BatchNumber}\nUnit price {UnitPrice:C}\nQuantity: {Quantity}\nManufactured date: {ManufacturedDate}\nExpiry date: {ExpiryDate}\n========================";
    }

    public string Print(int qty)
    {

        return $"Quantity available is {qty}";
    }

    public string Print(Date mDate, Date exDate)
    {

        return $"Manufacturing date is {mDate} Expiry date is {exDate}\n";
    }

    public string ZeroStock()
       {
           if(Quantity == 0)
           {
               Quantity += 50;  
           }
           return $"New goods has been purchased for finished goods quantity available is now {Quantity}";
       }


    }
}