namespace NovertisPharmaLtd
{
    public class Sales 
    {
       public string MedicineCode{get; set;}
       public string Region{get; set;}
       private int quantitySold;
       private decimal plannedSales;
       private decimal actualSales;

    public Sales(string medicineCode, string region, int quantitySold, decimal plannedSales, decimal actualSales)
    {
        MedicineCode = medicineCode;
        Region = region;
        QuantitySold = quantitySold;
        PlannedSales = plannedSales;
        ActualSales = actualSales;
    }
       public int QuantitySold{
           get {return quantitySold;}
           set {
               if(value > 0){
                   quantitySold = value;
               }
           }
       } 

       public decimal PlannedSales{
           get {return plannedSales;}
           set {
               if(value > 0){
                   plannedSales = value;
               }
           }
       }

       public decimal ActualSales{
           get {return actualSales;}
           set {
               if(value > 0){
                   actualSales = value;
               }
           }
       }

       public string Display()
       {
           return $"Medicine code {MedicineCode}\nRegion: {Region}\nPlanned sales: {PlannedSales}  Actual sales: {ActualSales}\nQuantity sold: {QuantitySold}\n===================== ";
       }

       public string Display(decimal PlannedSales, decimal ActualSales)
       {
           if(PlannedSales > ActualSales)
           {
               decimal num = PlannedSales - ActualSales;
               return $"We have excess sales of {num}";
           } else if (ActualSales > PlannedSales)
           {
               decimal num1 = ActualSales - PlannedSales;
               return $"We have less sales of {num1}";
           }
           else return $"We met our exact target sales";
       } 

       

    }
}