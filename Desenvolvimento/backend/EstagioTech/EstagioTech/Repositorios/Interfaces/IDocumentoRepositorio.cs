﻿using EstagioTech.Models;

namespace EstagioTech.Repositorios.Interfaces
{
    public interface IDocumentoRepositorio
    {
        Task<List<DocumentoModel>> BuscarTodosDocumentos();

        Task<DocumentoModel> BuscarPorId (int id);

        Task<DocumentoModel> Adicionar(DocumentoModel documento);

        Task<DocumentoModel> Atualizar(DocumentoModel documento);

        Task<bool> Apagar (int id);
    }
}