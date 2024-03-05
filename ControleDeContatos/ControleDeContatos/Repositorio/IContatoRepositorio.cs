using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
<<<<<<< HEAD
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }


=======
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);

    }
>>>>>>> 2895ed94175598edbbf925dd9ae96e6ebcca2d0a
}
