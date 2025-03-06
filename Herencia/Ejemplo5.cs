// EJEMPLO 5: HERENCIA CERRADA (SEALED CLASS)
// Caso de uso: Sistema de seguridad de aplicación

public class Seguridad
{
    protected string ClaveAcceso { get; set; }

    public Seguridad(string claveAcceso)
    {
        ClaveAcceso = claveAcceso;
    }

    public virtual bool ValidarAcceso(string clave)
    {
        return ClaveAcceso == clave;
    }
}

public class SeguridadAvanzada : Seguridad
{
    private int intentosFallidos;
    private bool bloqueado;

    public SeguridadAvanzada(string claveAcceso)
        : base(claveAcceso)
    {
        intentosFallidos = 0;
        bloqueado = false;
    }

    public override bool ValidarAcceso(string clave)
    {
        if (bloqueado)
        {
            Console.WriteLine("Cuenta bloqueada por exceso de intentos fallidos");
            return false;
        }

        bool accesoCorrecto = base.ValidarAcceso(clave);
        
        if (!accesoCorrecto)
        {
            intentosFallidos++;
            Console.WriteLine($"Intento fallido: {intentosFallidos}/3");
            
            if (intentosFallidos >= 3)
            {
                bloqueado = true;
                Console.WriteLine("Cuenta bloqueada");
            }
        }
        else
        {
            intentosFallidos = 0;
        }
        
        return accesoCorrecto;
    }
}

// Esta clase no puede ser heredada
public sealed class SeguridadBiometrica : SeguridadAvanzada
{
    private string HuellaDigital { get; set; }

    public SeguridadBiometrica(string claveAcceso, string huellaDigital)
        : base(claveAcceso)
    {
        HuellaDigital = huellaDigital;
    }

    public bool ValidarHuella(string huella)
    {
        return HuellaDigital == huella;
    }

    public bool AccesoDobleAutenticacion(string clave, string huella)
    {
        return ValidarAcceso(clave) && ValidarHuella(huella);
    }
}