using GeekHub_WS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Services;

namespace GeekHub_WS
{
    /// <summary>
    /// Summary description for GeekHubWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GeekHubWS : System.Web.Services.WebService
    {

        public bool strVal(string str)
        {
            if (str != null && str != "") return true;
            return false;
        }

        [WebMethod]
        public DataSet FiltroSkus(string categoriaId, string nombre, string precioMin, string precioMax, string orden)
        {
            DataSet ds_response = default(DataSet);
            try
            {
                ds_response = new DataSet();
                string query = "";
                if (strVal(categoriaId)) { query += ("id_category=" + categoriaId + " and "); }
                if (strVal(nombre)) { query += ("REPLACE(n_product, ' ', '') like '%" + nombre.Replace(" ", "").ToLower() + "%'" + " and "); }
                if (strVal(precioMin)) { query += ("r_price>=" + precioMin + " and "); }
                if (strVal(precioMax)) { query += ("r_price<=" + precioMax + " and "); }
                query = query.Length == 0 ? "" : " where " + query.Substring(0, query.Length - 4);

                if (strVal(orden))
                {
                    switch (orden)
                    {
                        case "priceMinMax":
                            query += (" order by r_price asc");
                            break;
                        case "priceMaxMin":
                            query += (" order by r_price desc");
                            break;
                    }
                }

                SqlDataAdapter cmd = new SqlDataAdapter("select * from product" + query, Conexion.Conectar());
                cmd.Fill(ds_response);
                return ds_response;

            }
            catch { }
            return ds_response;
        }
        //Login (Find By Email and password)
        [WebMethod]
        public UserLogin loginFindByEmailAndPassword(string email, string password)
        {
            DataSet dataSet= default(DataSet);
            UserLogin objLogin = default(UserLogin);
            try
            {
                string query = "select * from [User] where t_email='" + email + "' and t_password='" + password + "'";
                SqlDataAdapter cmd = new SqlDataAdapter(query, Conexion.Conectar());
                dataSet=new DataSet();
                cmd.Fill(dataSet, "DevuelveLista");
                var userList = dataSet.Tables[0].AsEnumerable()
                              .Select(dataRow => new UserLogin
                              {
                                  RoleId = dataRow.Field<int>("id_role"),
                                  Email= dataRow.Field<string>("t_email"),
                                  Name = dataRow.Field<string>("t_name"),
                                  LastName = dataRow.Field<string>("t_last_name")
                              }).ToList();
                
                if (userList.Count() == 1)
                {
                    objLogin= userList.First();

                }     
            }
            catch { }
            return objLogin;
        }

        //Register(Creater users)
        [WebMethod]
        public bool registerUser(string idUser, string idRole, string password, string name, string lastName, string sex, string email, string admin, string register, string status)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[User](id_user,id_role,t_password,t_name,t_last_name,t_sex,t_email,f_admin,d_register,t_status) values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)", Conexion.Conectar());
            cmd.Parameters.AddWithValue("@a", idUser);
            cmd.Parameters.AddWithValue("@b", idRole);
            cmd.Parameters.AddWithValue("@c", password);
            cmd.Parameters.AddWithValue("@d", name);
            cmd.Parameters.AddWithValue("@e", lastName);
            cmd.Parameters.AddWithValue("@f", sex);
            cmd.Parameters.AddWithValue("@g", email);
            cmd.Parameters.AddWithValue("@h", admin);
            cmd.Parameters.AddWithValue("@i", register);
            cmd.Parameters.AddWithValue("@j", status);
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                return true;
            }
            return false;
        }

        [WebMethod]
        public string SendEmail(string subject, string body)
        {


            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("nestor.sm.95@gmail.com", "Ernesto Sanchez Matos", System.Text.Encoding.UTF8);//Correo que envia
            correo.To.Add("ernesto.sm.95@hotmail.com"); //Correo destino
            correo.Subject = subject;
            correo.Body = body;
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("nestor.sm.95@gmail.com", "clave"); //Las Credenciales de la pagina a la que envias el correo
            smtp.EnableSsl = true;
            smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
            smtp.Port = 587; //Puerto de salida
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(correo);

            return "Email sent.";
        }

        public static class Conexion
        {

            public static SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder
            {
                IntegratedSecurity = true,
                DataSource = "DESKTOP-B14EN9G\\RYZEN7",
                InitialCatalog = "db-geekhub"
            };

            public static SqlConnection Conectar()
            {
                SqlConnection Con = new SqlConnection(sqlConnection.ToString());
                Con.Open();
                return Con;
            }
        }
    }
}
