﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pets
{
    public partial class addedusers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"]!=null)
            {

            }
            else
            {
                    Response.Redirect("login.aspx");
            }
        }
    }
}