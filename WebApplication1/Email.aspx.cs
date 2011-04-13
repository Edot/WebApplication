using System;
using System.Collections;
using System.Configuration;
using System.Data;
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
            DateTime d = Convert.ToDateTime("9:58:45 PM");
          //  Response.Write("d: " + d);
           Response.Write("<br>Time: " +  d.ToString("H:mm"));

            ///






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
