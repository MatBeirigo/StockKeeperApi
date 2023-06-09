﻿using Domain.Interfaces.IFuncionario;
using Entitities.Entidades;
using Infra.Configuracao;
using Infra.Repositorio.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositorio
{
    public class RepositorioFuncionario : RepositoryGenerics<Funcionario>, InterfaceFuncionario
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioFuncionario()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task AdicionarFuncionario(Funcionario funcionario)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                await banco.Set<Funcionario>().AddAsync(funcionario);
                await banco.SaveChangesAsync();
            }
        }

        public async Task AtualizarFuncionario(Funcionario funcionario)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                banco.Set<Funcionario>().Update(funcionario);
                await banco.SaveChangesAsync();
            }
        }

        public async Task<IList<Funcionario>> ListarFuncionarios()
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.Funcionario.Include(f => f.Id)
                    .AsNoTracking()
                    .ToListAsync();
            }
        }

        public async Task<IList<Funcionario>> ObterFuncionarioPorId(int Id)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.Funcionario.Include(f => f.Id)
                    .Where(f => f.Id == Id)
                    .AsNoTracking()
                    .ToListAsync();
            }
        }
    }
}
