using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Synerion.Helper;

namespace Synerion
{
    public partial class Rounding : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTest_OnClick(object sender, EventArgs e)
        {
            DateTime inpDateTime = DateTime.Parse(txtInputDateTime.Text);
            DateTime rounDateTime = Round15.Round(inpDateTime, TimeSpan.FromMinutes(15));
            lblResult.Text = rounDateTime.ToString("yyyy-MM-dd h:mm");
        }
    }
}