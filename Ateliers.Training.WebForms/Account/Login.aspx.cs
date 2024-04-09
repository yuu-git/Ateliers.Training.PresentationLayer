using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ateliers.Training.WebForms.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // クッキーが存在するかどうかを確認します。
            if (Request.Cookies["userInfo"] != null)
            {
                // クッキーが存在する場合、クッキーから値を取得します。
                string userName = Server.HtmlEncode(Request.Cookies["userInfo"]["UserName"]);
                string userColor = Server.HtmlEncode(Request.Cookies["userInfo"]["UserColor"]);

                // ここで userName と userColor を使用する
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // 新しい HttpCookie オブジェクトを作成します。
                HttpCookie userInfo = new HttpCookie("userInfo");

                // "UserName" という名前のキーに UserName.Text という値を設定します。
                userInfo["UserName"] = UserName.Text;

                // "UserColor" という名前のキーに UserColor.Text という値を設定します。
                userInfo["UserColor"] = UserColor.Text;

                // クッキーの有効期限を設定します。この例では、クッキーは作成後1時間で有効期限が切れます。
                userInfo.Expires.Add(new TimeSpan(0, 1, 0));

                // クッキーをレスポンスに追加します。これにより、クッキーはクライアントに送信されます。
                Response.Cookies.Add(userInfo);

            }
        }
    }
}