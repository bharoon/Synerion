using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Synerion
{
    public partial class Timestamp : System.Web.UI.Page
    {
        static List<TableRow> _rows = new List<TableRow>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _rows.Clear();
            }
        }

        protected void btnLogTimestamp_Click(object sender, EventArgs e)
        {

            TableRow row = new TableRow();
            Label lblLabel = new Label();
            Label control = this.Master.FindControl("lblcurrentDateTime") as Label;
            if (control != null)
            {
                lblLabel.Text = control.Text;
            }
            TableCell cell = new TableCell();
            cell.Controls.Add(lblLabel);
            row.Cells.Add(cell);
            _rows.Add(row);
            tblTimestamp.Rows.AddRange(_rows.ToArray());
        }
    }
}