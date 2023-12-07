using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


     class Car
    {
    private String brand;
    private String year;
    private String price;

     public Car(string brand, string year, string price )
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }
    public void Display()
    {
        System.Console.WriteLine(this.brand);
        System.Console.WriteLine(this.year);
        System.Console.WriteLine(this.price);


    }
}
   
