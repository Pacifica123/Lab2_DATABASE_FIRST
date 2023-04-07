using System;
using System.Collections.Generic;

namespace Lab2_DATABASE_FIRST;

public partial class Playlistsong
{
    public int Id { get; set; }

    public int Songid { get; set; }

    public int Playlistid { get; set; }

    public virtual Playlist Playlist { get; set; } = null!;

    public virtual Song Song { get; set; } = null!;
}
