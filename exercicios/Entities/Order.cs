using System;
using System.Globalization;
using C_.Entities.Enums;

namespace C_.Entities{
    class Order{

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString(){
            return Id + ", " + Moment + ", " + Status;
        }
    }
}


    




