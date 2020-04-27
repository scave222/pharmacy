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
        private int ManufacturedDate{get; set;}
        private int ExpiryDate{get; set;}
    public Medicine(string medicineCode, string medicineName, string manufacturerName, int batchNumber,decimal unitPrice, int quantity, int manufacturedDate, int expiryDate)
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
            if(unitPrice > 0){
                unitPrice = value;
            }
        }
    }

    public int Quantity{
        get {return quantity;}
        set 
        {
            if(quantity > 0){
                quantity = value;
            }
        }
    }

    

    public string Print()
    {
    return $"Medicine code: {MedicineCode}\nMedicine name: { MedicineName}\nManufacturer name: {ManufacturerName}\nBatch number: {BatchNumber}\nUnit price {UnitPrice:C}\nQuantity: {Quantity}\nManufactured date: {ManufacturedDate}\nExpiry date: {ExpiryDate}";
    }

    public int Print(int qty)
    {

        return qty;
    }

    public string Print(int mDate, int exDate)
    {

        return $"{mDate} {exDate}";
    }

    public int ZeroStock()
       {
           if(Quantity == 0)
           {
               Quantity += 50;  
           }
           return Quantity;
       }


    }
}