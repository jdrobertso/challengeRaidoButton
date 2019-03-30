using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace challengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilButton.Checked)
            {
                resultImage.ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/61TrT6dIUlL._SX425_.jpg";
            }
            else if (penButton.Checked)
            {
                resultImage.ImageUrl = "https://cms.cloudinary.vpsvc.com//image/fetch/t_sitecore_images/f_auto,dpr_auto,w_700/https://s3-eu-west-1.amazonaws.com/sitecore-media-bucket/prod%2Fen%2F%7B3D1BD3F1-6E86-40F6-9377-23044E5B9A42%7D";
            }
            else if (phoneButton.Checked)
            {
                resultImage.ImageUrl = "https://ss7.vzw.com/is/image/VerizonWireless/iphone7-front-matblk?$device-lg$";
            }
            else if (tabletButton.Checked)
            {
                resultImage.ImageUrl = "http://img.bbystatic.com/BestBuy_US/images/products/6201/6201032_sa.jpg";
            }
            else
            {
                resultImage.ImageUrl = "https://image.shutterstock.com/image-illustration/try-again-red-rubber-stamp-260nw-247606309.jpg";
            }
        }
    }
}