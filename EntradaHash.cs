using System;

public class EntradaHash
{

    private Hasheable elemento;
    private bool estaActivo;

    public EntradaHash(Hasheable x, bool b)
    {
        this.elemento = x;
        this.estaActivo = b;
    }


    public EntradaHash(Hasheable e)
    {
        this.elemento = e;
        this.estaActivo = true;

    }

    internal object getElemento()
    {
        return elemento;
    }

    internal void setEstaActivo(bool v)
    {
        this.estaActivo = v;

    }


    
}