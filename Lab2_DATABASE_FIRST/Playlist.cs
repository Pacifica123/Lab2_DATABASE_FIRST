using System;
using System.Collections.Generic;

namespace Lab2_DATABASE_FIRST;

public partial class Playlist
{
    public int Id { get; set; }

    public string Titleplaylist { get; set; } = null!;

    public int Userid { get; set; }

    public virtual ICollection<Playlistsong> Playlistsongs { get; } = new List<Playlistsong>();

    public virtual User User { get; set; } = null!;
}
