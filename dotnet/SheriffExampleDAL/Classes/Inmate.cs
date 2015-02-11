using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace SheriffExampleDAL
{
  /// <summary>
  /// Public data on an individual in County Jail
  /// </summary>
  public class Inmate
  {
    private const string _server = "http://images.canyonco.org";

    private string _number;
    private string _lastName;
    private string _firstName;
    private string _middleName;
    private ChargeList _chargeList;
    private ArrestList _arrestList;
    private string _error;
    private string _thumb;
    private string _image;
    private string _vineURL;
    private string _vineLink;

    /// <summary>
    /// Default Constructor
    /// </summary>
    public Inmate(): this(String.Empty){}

    /// <summary>
    /// Constructor that takes an error
    /// </summary>
    /// <param name="error">The error as to why we could not proceed</param>
    public Inmate(string error)
    {
      _number = String.Empty;
      _lastName = String.Empty;
      _firstName = String.Empty;
      _middleName = String.Empty;
      _chargeList = new ChargeList();
      _arrestList = new ArrestList();
      _vineURL = String.Empty;
      _vineLink = String.Empty;

      _error = error;
    }

    /// <summary>
    /// A List of Charge <see cref="Charge"/>
    /// </summary>
    [DataMember]
    public ChargeList Charges
    {
      get { return _chargeList; }
      set { _chargeList = value; }
    }

    /// <summary>
    /// The Inmate ID
    /// </summary>
    public String IDNumber
    {
      get { return _number; }
      set { _number = value; }
    }

    /// <summary>
    /// A List of Arrest <see cref="Arrest"/>
    /// </summary>
    /// <seealso cref="Arrest"/>
    [DataMember]
    public ArrestList Arrests
    {
      get { return _arrestList; }
      set { _arrestList = value; }
    }

    /// <summary>
    /// Inmates Last Name
    /// </summary>
    public String LastName
    {
      get { return _lastName; }
      set { _lastName = value; }
    }

    /// <summary>
    /// Inmates First Name
    /// </summary>
    public String FirstName
    {
      get { return _firstName; }
      set { _firstName = value; }
    }

    /// <summary>
    /// Inmates Middle Name
    /// </summary>
    public String MiddleName
    {
      get { return _middleName; }
      set { _middleName = value; }
    }

    /// <summary>
    /// The VINE URL for Inmate
    /// </summary>
    public String VineURL
    {
      get { return _vineURL; }
      set { _vineURL = value; }
    }

    /// <summary>
    /// The HTML link for the VINE URL
    /// </summary>
    public String VineLink
    {
      get { return _vineLink; }
      set { _vineLink = value; }
    }

    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public String Error
    {
      get { return _error; }
      set { _error = value; }
    }

    /// <summary>
    /// The URL to the thumbnail image
    /// </summary>
    public String ImageThumb
    {
      get { return _thumb; }
      set { _thumb = value; }
    }

    /// <summary>
    /// The URL to the full sized image
    /// </summary>
    public String ImageFull
    {
      get { return _image; }
      set { _image = value; }
    }

    /// <summary>
    /// Just the string representation of Inmate
    /// </summary>
    /// <returns>A Simple string of id - first middle last name</returns>
    public override String ToString()
    {
      return _number;// +" - " + _firstName + " " + _middleName + " " + _lastName;
    }

    ///// <summary>
    ///// Tests to see if the Inmate is Equal
    ///// </summary>
    ///// <param name="id">The ID to test for</param>
    ///// <returns>True if they are equal</returns>
    //public bool IsEqual(string id)
    //{
    //  return (id == this.IDNumber);
    //}
  }
}
