using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*    Tạo class CreditCardFactory để triển khai Factory Design Pattern. 
    Bên trong tạo một phương thức nhận vào loại thẻ tín dụng,
    khi đó sẽ hiển thị các thông tin của thẻ tín dụng đó
*/



namespace The_tin_dung
{
    internal class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType)
        {
            CreditCard cardDetail = null;
            if (cardType == "MoneyBack")
                cardDetail = new MoneyBack();
            else if (cardType == "Titanium")
                cardDetail = new Titanium();
            else if (cardType == "Platinum")
                cardDetail = new Platinum();
            return cardDetail;
        }
    }
}
