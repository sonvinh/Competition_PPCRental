
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace PPCRental_Project.Models
{

using System;
    using System.Collections.Generic;
    
public partial class DISTRICT
{

    public DISTRICT()
    {

        this.PROPERTY = new HashSet<PROPERTY>();

        this.STREET = new HashSet<STREET>();

        this.WARD = new HashSet<WARD>();

    }


    public int ID { get; set; }

    public string DistrictName { get; set; }

    public Nullable<bool> Status { get; set; }



    public virtual ICollection<PROPERTY> PROPERTY { get; set; }

    public virtual ICollection<STREET> STREET { get; set; }

    public virtual ICollection<WARD> WARD { get; set; }

}

}
