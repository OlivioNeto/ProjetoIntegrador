using EstagioTech.Data;
using EstagioTech.Models;
using EstagioTech.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EstagioTech.Repositorios
{
    public class TipoDocumentoRepositorio : ITipoDocumentoRepositorio
    {
        private readonly DBContex _dbContex;
        public TipoDocumentoRepositorio(DBContex tipoDocumentoDBContext) 
        {
            _dbContex = tipoDocumentoDBContext;
        }
        public async Task<TipoDocumentoModel> BuscarPorId(int id)
        {
            return await _dbContex.TipoDocumento.FirstOrDefaultAsync(x => x.idTipoDocumento == id);
        }

        public async Task<List<TipoDocumentoModel>> BuscarTodosTiposDocumentos()
        {
            return await _dbContex.TipoDocumento.ToListAsync();
        }
        public async Task<TipoDocumentoModel> Adicionar(TipoDocumentoModel tipoDocumento)
        {
            await _dbContex.TipoDocumento.AddAsync(tipoDocumento);
            await _dbContex.SaveChangesAsync();

            return tipoDocumento;
        }


        public async Task<TipoDocumentoModel> Atualizar(TipoDocumentoModel tipoDocumento, int id)
        {
            TipoDocumentoModel tipoDocumentoPorId = await BuscarPorId(id);

            if (tipoDocumentoPorId == null)
            {
                throw new Exception($"O id: {id} do tipo documento não foi encontrado no banco");
            }
            tipoDocumentoPorId.descricaoTipoDocumento = tipoDocumento.descricaoTipoDocumento;

            _dbContex.TipoDocumento.Update(tipoDocumentoPorId);
            await _dbContex.SaveChangesAsync();

            return tipoDocumentoPorId;
        }
        public async Task<bool> Apagar(int id)
        {
            TipoDocumentoModel tipoDocumentoPorId = await BuscarPorId(id);

            if (tipoDocumentoPorId == null)
            {
                throw new Exception($"O id: {id} do tipo documento não foi encontrado no banco");
            }
            _dbContex.TipoDocumento.Remove(tipoDocumentoPorId);
            await _dbContex.SaveChangesAsync();
            return true;
        }
    }
}
