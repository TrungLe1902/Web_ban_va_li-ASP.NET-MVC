using System;
using System.Collections.Generic;

namespace Web_ban_va_li.Models;

public partial class TAnhSp
{
    public string MaSp { get; set; } = null!;

    public string TenFileAnh { get; set; } = null!;

    public short? ViTri { get; set; }

    public virtual TDanhMucSp MaSpNavigation { get; set; } = null!;
}
