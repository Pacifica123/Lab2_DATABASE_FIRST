using System;
using System.Collections.Generic;

namespace Lab2_DATABASE_FIRST;

public partial class User
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public DateOnly Datereg { get; set; }

    public virtual ICollection<Playlist> Playlists { get; } = new List<Playlist>();
}
