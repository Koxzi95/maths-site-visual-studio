using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        clsCalculations DataManager = new clsCalculations();
        Decimal AValue;
        lblError.Text = "";
        try
        {
            AValue = Convert.ToDecimal(txtInput.Text);
            DataManager.Add(AValue);
            txtInput.Text = "";
        }
        catch
        {
            lblError.Text = "Please enter a Data Value";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCalculations DataManager = new clsCalculations();
        DataManager.Clear();
    }
    protected void btnAverage_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        clsCalculations DataManager = new clsCalculations();
        if (DataManager.Count != 0)
        {
            txtOutput.Text = Convert.ToString(DataManager.Average);
        }
        else
        {
            lblError.Text = "Please enter a Data Value";
        }
    }
    protected void btnMin_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        clsCalculations DataManager = new clsCalculations();
        if (DataManager.Count != 0)
        {
            txtOutput.Text = Convert.ToString(DataManager.Min);
        }
        else
        {
            lblError.Text = "Please enter a Data Value";
        }
    }
    protected void btnMax_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        clsCalculations DataManager = new clsCalculations();
        if (DataManager.Count != 0)
        {
            txtOutput.Text = Convert.ToString(DataManager.Max);
        }
        else
        {
            lblError.Text = "Please enter a Data Value";
        }
    }
}