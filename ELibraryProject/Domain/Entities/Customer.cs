﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime JoinedDate { get; set; }

        public Customer Clone()
        {
            Customer customer = new Customer();
            customer.Name = Name;
            customer.Surname = Surname;
            customer.PhoneNumber = PhoneNumber;
            customer.JoinedDate = JoinedDate;
            customer.Id = Id;
            return customer;
        }
    }
}
