using System;
using System.Globalization;
using C_.Entities;
using C_.Entities.Enums;


namespace C_{
    class Ex14_1Enum{

        public static void Ex1(){

            Order order = new Order{
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

        System.Console.WriteLine(order);

        string txt = OrderStatus.PendingPayment.ToString();

        System.Console.WriteLine(txt);

        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        System.Console.WriteLine(os);
        }
    }
}