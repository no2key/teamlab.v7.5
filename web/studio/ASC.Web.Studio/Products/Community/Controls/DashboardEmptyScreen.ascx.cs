/* 
 * 
 * (c) Copyright Ascensio System Limited 2010-2014
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * http://www.gnu.org/licenses/agpl.html 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASC.Web.Community.Controls
{
    public partial class DashboardEmptyScreen : System.Web.UI.UserControl
    {
        public static String Location = VirtualPathUtility.ToAbsolute("~/Products/Community/Controls/DashboardEmptyScreen.ascx");

        public string ProductStartUrl { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}