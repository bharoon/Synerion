using System;
using System.Web.UI;

namespace Synerion
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !ScriptManager.IsInAsyncPostBack)
            {
                UpdateTimer.Enabled = true;
                lblcurrentDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
        }

        protected void UpdateTimer_Tick(object sender, EventArgs e)
        {
            lblcurrentDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}