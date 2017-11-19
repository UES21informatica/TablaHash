using System;

public interface ITablaHash
{

    String insertar(Hasheable x);

    void remover(Hasheable x);

    Object buscar(Hasheable x);

    void vaciar();
    
}
