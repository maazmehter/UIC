﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Download : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_Unload(object sender, EventArgs e)
    {
        Session["ShopcartID"] = null;
        Session["OrderID"] = null;

    }
}