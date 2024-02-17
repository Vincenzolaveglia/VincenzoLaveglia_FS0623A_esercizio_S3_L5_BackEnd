using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateCartItems();
            }
        }

        protected void PopulateCartItems()
        {
            List<CartItem> cartItems = GetCartItemsFromCookie();

            decimal totalAmount = 0;

            foreach (CartItem item in cartItems)
            {
                TableRow row = new TableRow();

                TableCell nameCell = new TableCell();
                nameCell.Text = item.Name;
                row.Cells.Add(nameCell);

                TableCell priceCell = new TableCell();
                priceCell.Text = item.Price.ToString("C");
                row.Cells.Add(priceCell);

                totalAmount += item.Price;

                cartTable.Rows.Add(row);
            }

            TableRow totalRow = new TableRow();

            TableCell totalPriceCell = new TableCell();
            totalPriceCell.Text = totalAmount.ToString("C");
            totalRow.Cells.Add(totalPriceCell);

            TotalTbl.Rows.Add(totalRow);
        }

        protected List<CartItem> GetCartItemsFromCookie()
        {
            List<CartItem> cartItems = new List<CartItem>();

            if (Request.Cookies["Cart"] != null)
            {
                string cartJson = HttpUtility.UrlDecode(Request.Cookies["Cart"].Value);
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                cartItems = serializer.Deserialize<List<CartItem>>(cartJson);
            }

            return cartItems;
        }

        protected void SaveCartItemsToCookie(List<CartItem> cartItems)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string cartJson = serializer.Serialize(cartItems);

            HttpCookie cartCookie = new HttpCookie("Cart");
            cartCookie.Value = HttpUtility.UrlEncode(cartJson);

            cartCookie.Expires = DateTime.Now.AddDays(1);


            Response.Cookies.Set(cartCookie);
        }
        protected void btnRemoveToCart(object sender, EventArgs e)
        {
            List<CartItem> emptyCart = new List<CartItem>(); 
            SaveCartItemsToCookie(emptyCart); 
            Response.Redirect(Request.RawUrl); 
        }

    }
}