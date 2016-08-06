using System.Collections.Generic;
using Xunit;
using System;


namespace HairSalon.Objects
{
  public class StylistTest 
  {
    // public void Dispose()
    // {
    //   Stylist.DeleteAll();
    // }

    public StylistTest()
   {
     DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=hair_salon_test;Integrated Security=SSPI;";
   }


   [Fact]
    public void Test1_StylistGetName()
    {
      // arrange
      Stylist newStylist = new Stylist("Russ");
      // act
      string result = newStylist.GetName();

      Assert.Equal("Russ", result);
    }
}
}
