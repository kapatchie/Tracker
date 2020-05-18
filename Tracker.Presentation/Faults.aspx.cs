using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tracker.Presentation
{
    public partial class Faults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myDatabaseEntities db = new myDatabaseEntities();
            var faults = db.Faults;

            faultsGridView.DataSource = faults.ToList();
            faultsGridView.DataBind(); 
                       
        }

        protected void faultsGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = faultsGridView.Rows[index];

            var referenceNumber = row.DataItem;

            
            
            
        }
    }
}