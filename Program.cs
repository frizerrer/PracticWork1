using System;

namespace ComputerApp
{
    public class Computer
    {
        
        public int InventoryNumber;
        public double ProcessorFrequencyGHz;
        public int HardDriveSizeGB;

       
        public void ShowInfo()
        {
            Console.WriteLine("Инвентарный номер: " + InventoryNumber);
            Console.WriteLine("Частота процессора: " + ProcessorFrequencyGHz + " ГГц");
            Console.WriteLine("Объём жёсткого диска: " + HardDriveSizeGB + " ГБ");
        }

        
        public double CalculateMemoryCost(double costPerGB)
        {
            return HardDriveSizeGB * costPerGB;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Computer comp = new Computer();

            
            comp.InventoryNumber = 123345;
            comp.ProcessorFrequencyGHz = 1.5;
            comp.HardDriveSizeGB = 400;

            
            comp.ShowInfo();

            double costPerGB = 100;
            double totalCost = comp.CalculateMemoryCost(costPerGB);

            Console.WriteLine("Стоимость внешней памяти: " + totalCost + " рублей");
        }
    }
}
