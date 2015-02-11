using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SheriffExampleDAL
{
  /// <summary>
  /// Containing Charge Class
  /// </summary>
  public class Charge
  {
    private string _description;
    private string _statute;

    /// <summary>
    /// The default Constructor
    /// </summary>
    public Charge()
    {
      _description = String.Empty;
      _statute = String.Empty;
    }

    /// <summary>
    /// The Statute Description
    /// </summary>
    public String StatuteDesc
    {
      get { return _description; }
      set { _description = value; }
    }

    /// <summary>
    /// The Statude Code
    /// </summary>
    public String StatuteCode
    {
      get { return _statute; }
      set { _statute = value; }
    }

    /// <summary>
    /// To String override
    /// </summary>
    /// <returns>The Arrest Info as a string</returns>
    public override String ToString()
    {
      return _statute + " - " + _description;
    }

    /// <summary>
    /// Checks to see if the Arrest is equal to another one
    /// </summary>
    /// <param name="statute">The Statute</param>
    /// <param name="desc">The Description</param>
    /// <returns>True if they match</returns>
    public bool IsEqual(string statute, string desc)
    {
      return (statute == this.StatuteCode
        && desc == this.StatuteDesc);
    }
  }
}
