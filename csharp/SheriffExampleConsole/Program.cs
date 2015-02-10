using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SheriffExampleDAL;

namespace SheriffExampleConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Inmate> list = Sheriff.GetCurrentArrests();
      foreach (Inmate inmate in list)
      {
        Console.Out.WriteLine(String.Format("Name: {0}, {1} {2}", inmate.LastName, inmate.FirstName, inmate.MiddleName));
        //Console.Out.WriteLine(String.Format("      ID: {0}", inmate.IDNumber));
        //Console.Out.WriteLine(String.Format("   Image: {0}", inmate.ImageFull));
        //Console.Out.WriteLine(String.Format("   Thumb: {0}", inmate.ImageThumb));
        //Console.Out.WriteLine(String.Format("    Link: {0}", inmate.VineLink));
        //Console.Out.WriteLine(String.Format("     URL: {0}", inmate.VineURL));

        foreach (Arrest arrest in inmate.Arrests)
        {
          Console.Out.WriteLine(String.Format("  Arrest: {0}", arrest.ArrestDate));
        }

        foreach (Charge charge in inmate.Charges)
        {
          Console.Out.WriteLine(String.Format("  Charge: {0}: {1}", charge.StatuteCode, charge.StatuteDesc));
        }
      }

      Console.WriteLine("Press Any Key to Continue");
      Console.ReadKey();
    }
  }
}
