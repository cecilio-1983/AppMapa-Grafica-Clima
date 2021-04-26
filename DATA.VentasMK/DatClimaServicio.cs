using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DATA.VentasMK
{
    public class DatClimaServicio
    {
        public string GetCurrentWeather(string ciudad= "Mexico", string key= "b0e8e7140ac976fa104961be36da697e") 
        {
            string responseBody = "";
            try
            {

             // http://api.openweathermap.org/data/2.5/weather?q=Mexico&appid=b0e8e7140ac976fa104961be36da697e
                string url = string.Concat("http://api.openweathermap.org/data/2.5/weather?q=", ciudad, "&appid=",key);
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            responseBody = objReader.ReadToEnd();
                         
                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

            return responseBody;
        }
    }
}
