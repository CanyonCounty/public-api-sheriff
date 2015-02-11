using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;

namespace SheriffExampleDAL
{
  public class Sheriff
  {
    /// <summary>
    /// Just get the data and deserialize it to objects we can use
    /// </summary>
    /// <returns>A List of Inmates</returns>
    public static List<Inmate> GetCurrentArrests()
    {
      List<Inmate> list = new List<Inmate>();
      try
      {
        WebClient client = new WebClient();
        byte[] raw = client.DownloadData("http://ccmtprod08.canyonco.org/Sheriff/CurrentArrest");
        string json = Encoding.UTF8.GetString(raw);
        list = JsonConvert.DeserializeObject<List<Inmate>>(json);
      }
      catch (Exception e)
      {
        list.Add(new Inmate(e.Message));
      }
      return list;
    }
  }
}
