using System;

namespace Exams2
{
    public abstract class Product
    {
        public int id{get;set;}
        public string name{get;set;}
        public int price{get;set;}

        public Product(){
            
        }

        public Product(int id, string name, int price){
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public abstract double computeTax();

    
    }   
}