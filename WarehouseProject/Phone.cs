using System;
namespace WarehouseProject
{
    public class Phone
    {
        public enum ScreenTypeEnum
        {
            POLED,
            AMOLED,
            TFT,
            LTP,
            OLED,
            IPS
        }

        private string brand;
        private string model;
        private int id = 0;
        private int x = 640;
        private int y = 480; 
        private ScreenTypeEnum screeType = ScreenTypeEnum.IPS;
        private int cpuCoreNumber = 1;
        private int cpuCoreSpeed = 1000; //MHz
        private int ram = 1024; //Mb 
        private int storage = 8; //Gb 
        private int price = 10000; //Ft

        public void showInfo() //toString metódus
        {
            Console.WriteLine("A Telefon jellemzői: \n" +
                "Márka: {0}, Modell:{1} \n" +
                "Kijelző típusa:{2}, Felbontás:{3}x{4} pixel \n" +
                "Processzor magok száma: {5}, Proszesszor sebessége{6}Mhz \n" +
                "Memória mérete{7}Mb, Háttértár mérete:{8}Gb  \n" +
                "Vételár:{9} \n", Brand,Model,ScreenType,X,Y,CpuCoreNumber,CpuCoreSpeed,Ram,Storage,Price);
        }

        public Phone(int price)
        {
            this.id++;
            this.price = price;
        }
        public Phone(string brand,string model,int x, int y, ScreenTypeEnum screenType,
                    int cpuCoreNumber, int cpuCoreSpeed,
                    int ram, int storage, int price)
        {
            this.brand = brand;
            this.model = model;
            this.id++;
            this.x = x;
            this.y = y;
            this.screeType = screenType;
            this.cpuCoreNumber = cpuCoreNumber;
            this.cpuCoreSpeed = cpuCoreSpeed;
            this.ram = ram;
            this.storage = storage;
            this.price = price;
        }

        public string Brand
        {
            set
            {
                brand = value;
            }
            get
            {
                return brand;
            }
        }
        public string Model
        {
            set
            {
                model = value;
            }
            get
            {
                return model;
            }
        }
        public int X
        {
            set
            {
                if (value > 0 && value < 8000)
                {
                    x = value;
                }
                else throw new Exception("A Képernyő felbontás 0 és 8000 közötti értéknek kell lennie. ");
            }
            get
            {
                return x;
            }
        }
        public int Y
        {
            set
            {
                if (value > 0 && value < 8000)
                {
                    y = value;
                }
                else throw new Exception("A Képernyő felbontás 0 és 8000 közötti értéknek kell lennie. ");
            }
            get
            {
                return y;
            }
        }
        public ScreenTypeEnum ScreenType
        {
            set
            {
                screeType = value;
            }
            get
            {
                return screeType;
            }
        }
        public int CpuCoreNumber
        {
            set
            {
                if (value > 0 && value < 16)
                {
                    cpuCoreNumber = value;
                }
                else throw new Exception("A processzor magok száma 1 és 16 közötti érték lehet.");
            }
            get
            {
                return cpuCoreNumber;
            }
        }
        public int CpuCoreSpeed
        {
            set
            {
                if (value > 0 && value < 4500)
                {
                    cpuCoreSpeed = value;
                }
                else throw new Exception("A proszesszor sebesség 1 és 4500 közötti érték lehet.");
            }
            get
            {
                return cpuCoreSpeed;
            }
        }
        public int Ram
        {
            set
            {
                if (value > 0 && value < 64000)
                {
                    ram = value;
                }
                else throw new Exception("A memoria mérete 1 és 640000 Mb közötti érték lehet.");
            }
            get
            {
                return ram;
            }
        }
        public int Storage
        {
            set
            {
                if (value > 0 && value < 1024)
                {
                    storage = value;
                }
                else throw new Exception("A Háttértároló mérete 1 és 1024 Gb közötti érték lehet.");
            }
            get
            {
                return storage;
            }
        }
        public int Price
        {
            set
            {
                if (value > 10000 && value < 800000)
                {
                    price = value;
                }
                else throw new Exception("A vételárnak 10.000Ft és 800.000Ft közöttinek kell lennie.");
            }
            get
            {
                return price;
            }
        }

    }
}
