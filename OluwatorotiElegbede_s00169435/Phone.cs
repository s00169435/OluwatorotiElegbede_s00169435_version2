using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OluwatorotiElegbede_s00169435
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public void IncreasePrice(double percentage)
        {
            Price += Price * (percentage / 100);
        }

        public Phone()
        {

        } 

        public Phone( string name, double price, string operatingsystem, string OSimage, string phoneImage)
        {
            this.Name = name;
            this.Price = price;
            this.OperatingSystem = operatingsystem;
            this.OS_Image = OSimage;
            this.Phone_Image = phoneImage;
        }
    }

    public class PhoneData : DbContext
    {
        public PhoneData() : base("MyPhoneData") { }
        public DbSet<Phone> Phones { get; set; }
    }
}
