using System;
using System.Collections.Generic;

namespace Web_ban_va_li.Models;

public partial class THangSx
{
    public string MaHangSx { get; set; } = null!;

    public string? HangSx { get; set; }

    public string? MaNuocThuongHieu { get; set; }

    public virtual ICollection<TDanhMucSp> TDanhMucSps { get; } = new List<TDanhMucSp>();
}
