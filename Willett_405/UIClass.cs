using System;
using System.Windows.Forms;

namespace Willett_405
{
    public static class UIClass
    {

        public static void Sendmess(DataGridViewRow Row, Serial sr)
        {
            string mess = string.Empty;
            string DateProduction = DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            mess += Row.Cells[8].Value + " ";//Производитель
            mess += Row.Cells[6].Value + " ";//Заказчик
            mess += Row.Cells[7].Value + " ";//Формула
            mess += Row.Cells[2].Value + "x";
            mess += Row.Cells[3].Value + "x";
            mess += Row.Cells[4].Value + " ";
            mess += DateProduction + " ";
            UpdateMessageText Upd = new UpdateMessageText(mess);
            //sr.InitRs();
            sr.Send(Upd);
        }
    }
}
