using EstagioTech.Data;
using EstagioTech.Models;
using EstagioTech.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EstagioTech.Repositorios
{
    public class TipoEstagioRepositorio : Interfaces.ITipoEstagioRepositorio
    {
        private readonly DBContex _dbContext;
        public TipoEstagioRepositorio(DBContex tipoEstagioDBContex)
        {
            _dbContext = tipoEstagioDBContex;
        }

        public async Task<TipoEstagioModel> BuscarPorId(int id)
        {
            return await _dbContext.TipoEstagio.FirstOrDefaultAsync(x => x.idTipoEstagio == id);
        }

        public async Task<List<TipoEstagioModel>> BuscarTodosTiposEstagios()
        {
            return await _dbContext.TipoEstagio.ToListAsync();
        }

        public async Task<TipoEstagioModel> Adicionar(TipoEstagioModel tipoEstagio)
        {
            await _dbContext.TipoEstagio.AddAsync(tipoEstagio);
            await _dbContext.SaveChangesAsync();

            return tipoEstagio;
        }

        public async Task<TipoEstagioModel> Atualizar(TipoEstagioModel tipoEstagio)
        {
            TipoEstagioModel tipoEstagioPorId = await BuscarPorId(tipoEstagio.idTipoEstagio);

            if (tipoEstagioPorId == null)
            {
                throw new Exception($"O id: {tipoEstagio.idTipoEstagio} do tipo estágio não foi encontrado no banco");
                
        public async Task<TipoEstagioModel> Atualizar(TipoEstagioModel tipoEstagio, int id)
        {
            TipoEstagioModel tipoEstagioPorId = await BuscarPorId(id);

            if (tipoEstagioPorId == null)
            {
                throw new Exception($"O id: {id} do tipo estágio não foi encontrado no banco");

            }
            tipoEstagioPorId.descricaoTipoEstagio = tipoEstagio.descricaoTipoEstagio;

            _dbContext.TipoEstagio.Update(tipoEstagioPorId);
            await _dbContext.SaveChangesAsync();

            return tipoEstagioPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            TipoEstagioModel tipoEstagioPorId = await BuscarPorId(id);

            if (tipoEstagioPorId == null)
            {
                throw new Exception($"O id: {id} do tipo estágio não foi encontrado no banco");
            }

            _dbContext.TipoEstagio.Remove(tipoEstagioPorId);
            await _dbContext.SaveChangesAsync();
            return true;

        }        
    }
}
