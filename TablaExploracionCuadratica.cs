using System;

public class TablaExploracionCuadratica : ExploracionTablaHash
{
	public TablaExploracionCuadratica()
	{
        
	}
    
    protected override int buscarPos(Hasheable x)
    {
        int colision = 0;
        int posicionActual = x.Hash(vector.Length);
        Console.WriteLine("hash: " + posicionActual);

        while (vector[posicionActual] != null && !vector[posicionActual].getElemento().Equals(x))
        {
            posicionActual += 2 * ++colision - 1;
            if (posicionActual >= vector.Length)
                posicionActual -= vector.Length;
        }
        Console.WriteLine("Para el elemento: " + x.Stri() + " Posicion: " + posicionActual );
        return posicionActual;
    }

    internal override void comfirmarBuscar(int posicionActual, string v)
    {
        throw new NotImplementedException();
    }

   
}
