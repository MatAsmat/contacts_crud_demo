using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace TooSharp.Models
{   
    /// <summary>
    ///  TooSharp Generated Code. Do not Modify 
    ///  Date Genereated: 2/8/2562 7:13
    ///  Author: HELLO
    /// </summary>
    /// <seealso cref="TooSharp.Core.ITSRelationShips" />
    [DebuggerStepThrough]
    public class Contacts : TooSharp.Core.ITSModel
    {
      #region CODE
	     public static string TableName = "contacts";
         public string GetTableName() { return TableName; }
         public List<string> GetColumns() {return Enum.GetValues(typeof(COLUMNS)).Cast<COLUMNS>().Select(v => v.ToString()).ToList();  }
         public static TooSharp.Core.TSQueryBuilder<Contact> Records() { return new TooSharp.Core.TSQueryBuilder<Contact>(TooSharp.TSRelationships.getInstance()); }
         public static TooSharp.Core.TSQueryBuilder<Contact> Records(object[] columns) { return new TooSharp.Core.TSQueryBuilder<Contact>(TooSharp.TSRelationships.getInstance(),columns); }
      #endregion
      #region COLUMNS
       public enum COLUMNS
       {
         id,
         FirstName,
         LastName,
         Position,
         Email,
         Mobile,
         createdAt,
         //column
       }
      #endregion
    }
     [DebuggerStepThrough]
    public class Contact: TooSharp.Core.TSmodel 
    {
     
       #region PROPERTIES
         [TSKey]
         public int Id { get; private set; }=-1;
         [TSNotEmpty]
         public string FirstName { get; set; }
         [TSNotEmpty]
         public string LastName { get; set; }
         [TSNotEmpty]
         public string Position { get; set; }
         [TSEmail]
         public string Email { get; set; }
         [TSPhone]
         public string Mobile { get; set; }
         public DateTime CreatedAt { get; set; }
         //property
       #endregion
    }
}
