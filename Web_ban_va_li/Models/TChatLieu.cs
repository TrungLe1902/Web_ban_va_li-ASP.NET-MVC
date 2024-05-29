using System;
using System.Collections.Generic;

namespace Web_ban_va_li.Models;

public partial class TChatLieu
{
    public string MaChatLieu { get; set; } = null!;

    public string? ChatLieu { get; set; }

    public virtual ICollection<TDanhMucSp> TDanhMucSps { get; } = new List<TDanhMucSp>();
}
