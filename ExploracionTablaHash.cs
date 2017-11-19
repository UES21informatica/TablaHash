using System;
using System.Windows;

public abstract class ExploracionTablaHash : ITablaHash
{
    private static int Tamaño_tabla_defecto = 10;

    protected EntradaHash[] vector;
    private int tamañoActual;

    private void crearVector(int tamañoVector)
    {
        vector = new EntradaHash[tamañoVector];
    }

    public void vaciar()
    {
        this.tamañoActual = 0;
        for (int i = 0; i < vector.Length; i++)
            vector[i] = null;
    }

    public ExploracionTablaHash()
    {
        crearVector(Tamaño_tabla_defecto);
        vaciar();
    }

    public string insertar(Hasheable x)
    {
        int posicionActual = buscarPos(x);
        vector[posicionActual] = new EntradaHash(x, true);
        return posicionActual.ToString();
    }



    public void remover(Hasheable x)
    {
        int posicionActual = buscarPos(x);
        comfirmarBuscar(posicionActual, "eliminar de ExploracionTablaHash");
        vector[posicionActual].setEstaActivo(false);
    }

    object ITablaHash.buscar(Hasheable x)
    {
        int posicionActual = buscarPos(x);
        comfirmarBuscar(posicionActual, "buscar de ExploracionTabalaHash");
        return vector[posicionActual].getElemento();
    }


    internal abstract void comfirmarBuscar(int posicionActual, string v);
    protected abstract int buscarPos(Hasheable x);



}
