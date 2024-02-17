using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateProductCards();
            }
        }

        protected void PopulateProductCards()
        {

            var products = Product.GetProducts();


            string htmlContent = "";

            foreach (var product in products)
            {

                htmlContent += $@"
            <div class=""col-md-4 mb-4"">
                <div class=""card h-100 shadow"">
                    <img src=""{product.ImageUrl}"" class=""card-img-top mx-auto d-block"" alt=""{product.Name}"" style=""max-width: 300px; max-height: auto;"">
                    <div class=""card-body"">
                        <h5 class=""card-title mb-0"">{product.Name}</h5>
                        <p class=""card-text text-muted"">{product.Description}</p>
                        <p class=""card-text"">{product.Price:C}</p>
                        <div class=""card-footer bg-transparent border-0 d-flex justify-content-center"">
                           <a href=""Details.aspx?ProductId={product.Id}"" class=""btn btn-primary btn-sm me-2"">Vedi Dettagli</a>          
                        </div>
                    </div>
                </div>
            </div>";
            }


            RowCards.InnerHtml = htmlContent;
        }
    }
}