//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class torrents
    {
        public int Id { get; set; }
        public string url { get; set; }
        public string hash { get; set; }
        public string quality { get; set; }
        public Nullable<long> seeds { get; set; }
        public Nullable<long> peers { get; set; }
        public string size { get; set; }
        public Nullable<long> size_bytes { get; set; }
        public string date_uploaded { get; set; }
        public Nullable<long> date_uploaded_unix { get; set; }
    }
}
