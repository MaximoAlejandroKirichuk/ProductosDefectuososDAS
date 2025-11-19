using BE;
using System;

public class Log : ICloneable, IComparable<Log>
{
    public int Id { get; set; }
    public int? UsuarioId { get; set; }
    public DateTime FechaEvento { get; set; } = DateTime.Now;

    public NivelLog NivelLog { get; set; }
    public ModuloSistema ModuloInvolucrado { get; set; }
    public Criticidad Criticidad { get; set; }
    public string AccionRealizada { get; set; }

    public Log() { }

    public Log(int? usuarioId, NivelLog nivel, ModuloSistema modulo, string accion)
    {
        UsuarioId = usuarioId;
        FechaEvento = DateTime.Now;
        NivelLog = nivel;
        ModuloInvolucrado = modulo;
        AccionRealizada = accion;
    }

    // CLONADO
    public object Clone()
    {
        return this.MemberwiseClone();
    }

    // COMPARACIÓN por fecha
    public int CompareTo(Log other)
    {
        return FechaEvento.CompareTo(other.FechaEvento);
    }
}
