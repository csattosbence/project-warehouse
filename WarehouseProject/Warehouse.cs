using System;
using System.Collections.Generic;
namespace WarehouseProject
{
    public class Warehouse
    {
        private List<Phone> phoneList = new List<Phone>();
        
        public void removePhoneByIdex(int index)
        {
            phoneList.RemoveAt(index);
        }

        public void removePhone(Phone phone)
        {
            if (phoneExists(phone,phoneList))
            {
                phoneList.Remove(phone);
            }
            else throw new Exception("Ilyen telefon nem található a listában");
        }

        public void AddPhone(Phone phone)
        {
            if (phoneExists(phone,phoneList))
            {
                throw new Exception("A Telefon már hozzá van adva a listához");
            }
            else if (phone != null)
            {
                phoneList.Add(phone);
            }
            else
            {
                throw new Exception("A Megadott érték nem lehet null.");
            }
        }

        private bool phoneExists(Phone phone, List<Phone> phoneList)
        {
            for (int i = 0; i < phoneList.Count; i++)
            {
                if (phoneList[i] == phone ||
                    (phone.Brand == phoneList[i].Brand && phone.Model == phoneList[i].Model && phone.Storage == phoneList[i].Storage))
                {
                    return true;
                }
            }
            return false;


        }

        public int warehouseWorth()
        {
            int summ = 0;
            foreach (Phone phone in phoneList) {
                summ += phone.Price;
            }
            return summ;
        }

        public int getPhoneCount()
        {
            return phoneList.Count;
        }

        public void warehouseFill(int number)
        {
            Random rnd = new Random();
            Phone randomPhone;
            int i = 0;
            string[] brands = { "Samsung", "Apple", "Huawei", "Honor", "OnePlus", };
            string[] models = { "X", "Xr", "S21", "S9", "T10", "8X", "P20", };
            int[] x = { 480, 600, 768, 1080, 1440, 2560 };
            int[] y = { 640, 800, 1024, 1920,2048, 4096 };
            int[] storage = { 8, 16, 32, 64, 128, 256, 512, 1024 };
            int[] ram = { 1024,2048,4096,8192,16384};
            int[] coreSpeed = { 1000, 1400, 1600, 2400, 3200 };
            int[] price = { 100000, 200000, 300000, 245000, 670000, 32000 };


            while (i <= number)
            {
                randomPhone = new Phone(
                    brands[rnd.Next(0,5)],
                    models[rnd.Next(0,7)],
                    x[rnd.Next(0,6)],
                    y[rnd.Next(0,6)],
                    Phone.ScreenTypeEnum.OLED,
                    rnd.Next(0,8),
                    coreSpeed[rnd.Next(0,5)],
                    ram[rnd.Next(0,5)],
                    storage[rnd.Next(0,7)],
                    price[rnd.Next(0,6)]
                    
                    );


                if (!phoneExists(randomPhone,phoneList))
                {
                    phoneList.Add(randomPhone);
                    i++;
                }
                
            }
        }

        public Phone GetPhone(int index)
        {
            return phoneList[index];
        }

        public Warehouse()
        {
        }
    }
}
