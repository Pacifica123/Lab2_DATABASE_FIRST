using System;
using System.Collections.Generic;

namespace Lab2_DATABASE_FIRST;

public partial class Song
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Playlistsong> Playlistsongs { get; } = new List<Playlistsong>();
}
