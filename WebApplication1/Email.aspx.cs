using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net;
using System.Net.Mail;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime d = Convert.ToDateTime("9:58:45");
          //  Response.Write("d: " + d);
           Response.Write("<br>Time: " +  d.ToString("H:mm"));

            ///
           DateTime dateTime1, dateTime2;
           dateTime1 = DateTime.Parse("9:58:45");

           dateTime2 = DateTime.Parse("10:01:08");

            //Find the Difference 

            TimeSpan timeDiff = dateTime2.Subtract(dateTime1);
            Response.Write("<br>timeDiff: " + timeDiff);
            Response.Write("<br>timeDiff.TotalMinutes: " + timeDiff.TotalMinutes.ToString().Substring(0, 1));

            string strTest = "07:12 PM 03/15/11 CARD READER 01.2 01250                ,3/15/2011 7:57:26 PM";
            
            
            
            //11 CARD READER 01.2 01250                GRANTED,3/15/2011 7:57:26 PM";
            string [] arrValues = strTest.Split(' ');

          

        }

        protected void btnSend_Click(object sender, System.EventArgs e)
        {
            string server = ConfigurationManager.AppSettings["emailserver"].ToString();
                MailAddress to = new MailAddress(txtTo.Text);
                MailAddress from = new MailAddress("bernice@edot-solutions.com");    
                MailMessage message = new MailMessage(from, to); 

                message.Subject = txtSubject.Text;
                message.Body =  txtMessage.Text;

                SmtpClient client = new SmtpClient(server);

                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                txtTo.Text = String.Empty;
                txtSubject.Text = String.Empty;
                txtMessage.Text = String.Empty;
         }





    }
}
