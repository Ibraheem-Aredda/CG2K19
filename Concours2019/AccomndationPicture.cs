//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Concours2019
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccomndationPicture
    {
        public int PictureID { get; set; }
        public Nullable<int> AccomndationTypeID { get; set; }
        public string PicturePath { get; set; }
        public string PictureTitle { get; set; }
    
        public virtual AccomdationType AccomdationType { get; set; }
    }
}