using EstagioTech.Models;

namespace EstagioTech.Repositorios.Interfaces
{
    public interface ICursoRepositorio
    {
        Task<List<CursoModel>> BuscarTodosTiposEstagios();

        Task<CursoModel> BuscarPorId(int id);

        Task<CursoModel> Adicionar(CursoModel curso);

        Task<CursoModel> Atualizar(CursoModel curso, int id);

        Task<bool> Apagar(int id);
    }
}
