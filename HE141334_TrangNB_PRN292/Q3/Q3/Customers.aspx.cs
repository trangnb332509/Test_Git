using Lab3_Template.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Insert(0, new ListItem("All Customers", "0"));
                DropDownList1.SelectedIndex = 0;
                DropDownList1.Items.Insert(1, new ListItem("Male Customers", "1"));
                DropDownList1.Items.Insert(2, new ListItem("Female Customers", "-1"));

                GridView1.DataSource = DAO.GetDataTable("SELECT CustomerName, Male, DOB, [Address] FROM Customer");
                GridView1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = int.Parse(DropDownList1.SelectedIndex.ToString());
            if (i == 0)
            {
                GridView1.DataSource = DAO.GetDataTable("SELECT CustomerName, Male, DOB, [Address] FROM Customer");
                GridView1.DataBind();
            }else if (i == 1)
            {
                GridView1.DataSource = DAO.GetDataTable("SELECT CustomerName, Male, DOB, [Address] FROM Customer where Male = 1");
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = DAO.GetDataTable("SELECT CustomerName, Male, DOB, [Address] FROM Customer where Male = 0");
                GridView1.DataBind();
            }

        }
    }
}