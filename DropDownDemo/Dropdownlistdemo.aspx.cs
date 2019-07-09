using System;
using System.Data.SqlClient;
using System.Data;


public partial class Dropdownlistdemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        string CS = @"data source = (LocalDb)\MSSQLLocalDB; database = Sample; Integrated Security = SSPI";
        using (SqlConnection con = new SqlConnection(CS))
        {
            SqlCommand command = new SqlCommand("Select * from tblCity", con);
            con.Open();
            DropDownList1.DataSource= command.ExecuteReader();
            //DropDownList1.DataTextField = "CityName";
            //DropDownList1.DataValueField = "CityId";
            //Response.Write("Print" + DropDownList1.ID);
            DropDownList1.DataBind();
        }
        //Bind XML data to dropdown list

        DataSet ds = new DataSet();
        //Pass the Physical path
        ds.ReadXml(@"C:\Users\shukl\source\repos\DropDownDemo\DropDownDemo\Country.xml");
        //If you don't know the physical path use the method Server.MapPath to find the physical path
        ds.ReadXml(Server.MapPath("Country.xml"));


        DropDownList3.DataSource = ds;
        DropDownList3.DataTextField = "CountryName";
        DropDownList3.DataValueField = "CountryId";
        DropDownList3.DataBind();

        //Add will add at the end of the list but we want at the beginning. Use Insert
        DropDownList3.Items.Insert(0, "Select");
        


    }
}