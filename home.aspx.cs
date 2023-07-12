using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Expense
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userName.Text = Db.getName();
            totalCost.Text = Db.getExpense();
            
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            InputDetails ip = new InputDetails();
            Db db = new Db();
            ip.amount = Convert.ToInt32(amount.Text);
            ip.date = DateTime.Parse(date_.Text);
            ip.session = SessionDropDown.SelectedValue;
            ip.msg = msg.Text;
            db.insertModel(ip);
        }

        protected void btnSearch_yearClick(object sender, EventArgs e)
        {
            Label4.Text = Db.getExpenseByYear(Convert.ToInt32(year.Text));
            Label4.Visible = true;
            Label5.Visible = false;
            Label6.Visible = false;
        }

        protected void btnSearch_monthClick(object sender, EventArgs e)
        {
            Label5.Text = Db.getExpenseByMonth(Convert.ToInt32(month.Text));
            Label4.Visible = false;
            Label5.Visible = true;
            Label6.Visible = false;
        }

        protected void btnSearch_dateClick(object sender, EventArgs e)
        {
            Label6.Text = Db.getExpenseByDate(DateTime.Parse(date.Text));
            Label4.Visible = false;
            Label5.Visible = false;
            Label6.Visible = true;
        }
    }
}