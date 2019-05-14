﻿using System.Collections.Generic;
using TaskUser.Models.Production;

namespace TaskUser.Models.Sales
{
    public class Store
    {
        public Store()
        {
            
        }
        public Store(int id, string storeName, string email,string phone, string street, string city, string state, string zipCode)
        {
            Id = id;
            StoreName = storeName;
            Email = email;
            Phone = phone;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
        
        public int Id { get; set; }
        public string StoreName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        
        public virtual ICollection<User>users { get; set; }
        
        public virtual ICollection<Stock>Stocks { get; set; }
    }
}