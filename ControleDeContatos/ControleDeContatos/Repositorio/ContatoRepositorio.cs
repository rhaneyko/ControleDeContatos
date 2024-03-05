using ControleDeContatos.Data;
using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
<<<<<<< HEAD
        private readonly BancoContext _context;
        public ContatoRepositorio(BancoContext bancoContext) 
        {
            this._context = bancoContext;
        }
        public ContatoModel ListarPorId(int id)
        {
            return _context.Contatos.FirstOrDefault(x => x.Id == id);
        }
        public List<ContatoModel> BuscarTodos()
        {
            return _context.Contatos.ToList();
=======
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }
        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
>>>>>>> 2895ed94175598edbbf925dd9ae96e6ebcca2d0a
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
<<<<<<< HEAD
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);
            if (contatoDB == null) throw new Exception("Houve um erro na atualização do contato!");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _context.Contatos.Update(contatoDB);
            _context.SaveChanges();

            return contatoDB;

        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);
            if (contatoDB == null) throw new Exception("Houve um erro na deteleção do contato!");

            _context.Contatos.Remove(contatoDB);
            _context.SaveChanges();

            return true;
=======
            //gravar no banco de dados

            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;

>>>>>>> 2895ed94175598edbbf925dd9ae96e6ebcca2d0a
        }
    }
}
