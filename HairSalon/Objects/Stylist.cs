using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace HairSalon
{
  public class Stylist
  {
    //properties
    private int _id;
    private string _name;
    //constructor
    public Stylist(string Name, int Id = 0)
    {
      _id = Id;
      _name = Name;
    }
    //Getters and Setters
    public int GetId()
    {
      return _id;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public override bool Equals(System.Object otherStylist)
    {
      if (!(otherStylist is Stylist))
      {
        return false;
      }
      else
      {
        Stylist newStylist = (Stylist) otherStylist;
        bool idEquality = (this.GetId() == newStylist.GetId());
        bool nameEquality = (this.GetName() == newStylist.GetName());
        return (idEquality && nameEquality);
      }
    }

    public override int GetHashCode()
  {
    return this.GetName().GetHashCode();
  }


}
}
