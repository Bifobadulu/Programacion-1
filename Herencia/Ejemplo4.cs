// EJEMPLO 4: HERENCIA CON INTERFACES
// Caso de uso: Sistema de notificaciones

public interface INotificacion
{
    void Enviar(string mensaje);
    bool VerificarEntrega();
}

public abstract class NotificacionBase : INotificacion
{
    public string Destinatario { get; set; }
    public DateTime FechaEnvio { get; set; }
    public bool Entregado { get; protected set; }

    protected NotificacionBase(string destinatario)
    {
        Destinatario = destinatario;
        Entregado = false;
    }

    public abstract void Enviar(string mensaje);

    public virtual bool VerificarEntrega()
    {
        Console.WriteLine($"Verificando entrega a {Destinatario}");
        return Entregado;
    }
}

public class NotificacionEmail : NotificacionBase
{
    public string CorreoElectronico { get; set; }

    public NotificacionEmail(string destinatario, string correoElectronico)
        : base(destinatario)
    {
        CorreoElectronico = correoElectronico;
    }

    public override void Enviar(string mensaje)
    {
        Console.WriteLine($"Enviando email a {CorreoElectronico}: {mensaje}");
        FechaEnvio = DateTime.Now;
        Entregado = true;
    }
}

public class NotificacionSMS : NotificacionBase
{
    public string NumeroTelefono { get; set; }

    public NotificacionSMS(string destinatario, string numeroTelefono)
        : base(destinatario)
    {
        NumeroTelefono = numeroTelefono;
    }

    public override void Enviar(string mensaje)
    {
        Console.WriteLine($"Enviando SMS a {NumeroTelefono}: {mensaje}");
        FechaEnvio = DateTime.Now;
        Entregado = true;
    }

    public override bool VerificarEntrega()
    {
        Console.WriteLine($"Verificando entrega de SMS a {NumeroTelefono}");
        return Entregado;
    }
}
