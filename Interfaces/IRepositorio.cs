using System.Colletions.Generic;
namespace DioSeries.interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere( T entidade);
        void exclui(int id);
        void Atualiza(int id,T entidade);
        int proximoId();
       
    } 
}