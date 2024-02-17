using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Ecommerce
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ProductId"]))
                {
                    int productId;
                    if (int.TryParse(Request.QueryString["ProductId"], out productId))
                    {
                        var product = Product.GetProductById(productId);
                        if (product != null)
                        {
                            lblProductName.Text = product.Name;
                            lblProductDescription.Text = product.Description;
                            lblMoreDescription.Text = product.MoreDescription;
                            lblProductPrice.Text = $" {product.Price:C}";
                            imgProduct.ImageUrl = product.ImageUrl;
                        }

                    }

                }

            }
        }

        protected void BtnAddToCart(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ProductId"]))
            {
                int productId;
                if (int.TryParse(Request.QueryString["ProductId"], out productId))
                {
                    var product = Product.GetProductById(productId);

                    if (product != null)
                    {
                        CartItem cartItem = new CartItem
                        {
                            Id = product.Id,
                            Name = product.Name,
                            Price = product.Price,
                            
                        };

                        List<CartItem> cartItems = GetCartItemsFromCookie();
                        cartItems.Add(cartItem);

                        SaveCartItemsToCookie(cartItems);
                    }
                }
            }

            Response.Redirect("Cart.aspx");
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
        
            Response.Cookies.Add(cartCookie);
        }
    }
}

        


