namespace trinhthuhuong_01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHANVIEN
    {
        [Key]
        public string MaNV { get; set; }

        public string TenNV { get; set; }

        public string SDT { get; set; }

        public string MaCV { get; set; }
    }
}
