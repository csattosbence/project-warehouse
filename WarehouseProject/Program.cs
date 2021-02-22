using System;

namespace WarehouseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Phone phone = new Phone("Samsung","Galaxy S21",2048,4096,Phone.ScreenTypeEnum.AMOLED,8,1400,8000,256,240000);
            phone.showInfo();

            Warehouse warehouse = new Warehouse();

            warehouse.warehouseFill(40);

            for (int i = 0; i < 40; i++)
            {
                warehouse.GetPhone(i).showInfo();
            }

        }
    }
}
