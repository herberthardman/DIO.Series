using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface iRepositorio<T>
    {
         List<T> Lista();

         T retornaPorId(int ID);

         void Insere(T objeto);

         void Excluir(int id);

         void Atualiza(int id, T objeto);

         int ProximoId();

    }
}