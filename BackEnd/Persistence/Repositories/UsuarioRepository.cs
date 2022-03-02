using BackEnd.Domain.IRepositories;
using BackEnd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Persistence.Context.ApplicationDbContext _context;
        
         
        public UsuarioRepository(Persistence.Context.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveUser(Usuario usuario)
        {
            _context.Add(usuario);
            await _context.SaveChangesAsync();

            
        }

        public async Task<bool> ValidarExistencia(Usuario usuario)
        {
            var validarExistencia = await _context.Usuario.AnyAsync(x => x.nombreUsuario == usuario.nombreUsuario);
            return validarExistencia;
        }

        public async Task<Usuario> ValidatePassword(int idUsuario, string passwordAnterior)
        {
            var usuario = await _context.Usuario.Where(x => x.Id == idUsuario && x.Password == passwordAnterior).FirstOrDefaultAsync();
            return usuario;

        }

        public async Task UpdatePassword(Usuario usuario)
        {
            _context.Update(usuario);
            await _context.SaveChangesAsync();
        }
    }
}
