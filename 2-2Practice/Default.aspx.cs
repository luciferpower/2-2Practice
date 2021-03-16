using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int year = 8;
            string result = "Y";
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 != 0)
                        result = "N";
                }
            }
            else
            {
                result = "N";
            }
            Response.Write(result);
        }
    }
}