using EstagioTech.Models;

namespace EstagioTech.Repositorios.Interfaces
{
    public interface ITipoDocumentoRepositorio
    {
        Task<List<TipoDocumentoModel>> BuscarTodosTiposDocumentos();

        Task<TipoDocumentoModel> BuscarPorId (int id);

        Task<TipoDocumentoModel> Adicionar(TipoDocumentoModel tipoDocumento);

        Task<TipoDocumentoModel> Atualizar(TipoDocumentoModel tipoDocumento, int id);

        Task<bool> Apagar(int id);
    }
}
