using System;
using System.Collections.Generic;
using System.Text;

namespace The_tin_dung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập CardType: ");
            string Card_Type = Console.ReadLine();

            CreditCard creditDetails = CreditCardFactory.GetCreditCard(Card_Type);

            if(creditDetails == null)
                Console.WriteLine("Invalid Card Type");
            else
            {
                Console.WriteLine("CardType: " + creditDetails.GetCardType());
                Console.WriteLine("CreditLimit: " + creditDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge: " + creditDetails.GetAnnualCharge());
            }    
        }
    }
}