using SegundoappBandodeDados.Models;

namespace SegundoappBandodeDados.Repositorio.Contrato
{
    public interface IUsuarioRepositorio
    {
        // CRUD 
        IEnumerable<Usuario> ObterTodosUsuarios();

        void Cadastrar(Usuario usuario);

        void Atualizar(Usuario usuario);

        Usuario ObterUsuario(int Id);

        void Excluir(int Id);
    }
}
