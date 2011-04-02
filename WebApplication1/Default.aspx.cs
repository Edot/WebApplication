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
using System.IO;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LatestFile();
        }

        public void LatestFile()
        {
            string path = ConfigurationSettings.AppSettings["csvfilepath"].ToString();
            Response.Write("File Path: " + path);
            string[] files = System.IO.Directory.GetFiles(ConfigurationSettings.AppSettings["csvfilepath"].ToString());

            string LatestFile = string.Empty;
            DateTime time ;
            time = File.GetCreationTimeUtc(files[0]);
            LatestFile = files[0];
            for (int i = 0; i < files.Count()-1;i++ )
            {
                for (int j = i + 1; j < files.Count(); j++)
                {

                    if (File.GetCreationTimeUtc(files[i]) > File.GetCreationTimeUtc(files[j]))
                    {
                        time = File.GetCreationTimeUtc(files[i]);
                        LatestFile = files[i];
                    }
                    else
                    {
                        time = File.GetCreationTimeUtc(files[j]);
                        LatestFile = files[j];
                    }
                }

            }

           Response.Write("<br>Latest File: " + LatestFile);


        }




    }
}
