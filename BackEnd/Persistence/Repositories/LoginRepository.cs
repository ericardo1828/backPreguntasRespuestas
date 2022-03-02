using BackEnd.Domain.IRepositories;
using BackEnd.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Persistence.Repositories
{
    public class LoginRepository: ILoginRepository
    {
        private readonly Persistence.Context.ApplicationDbContext _context;

        public LoginRepository(Persistence.Context.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> ValidarUser(Usuario usuario)
        {
            var user = await _context.Usuario.Where(x => x.nombreUsuario == usuario.nombreUsuario && x.Password == usuario.Password).FirstOrDefaultAsync();
            return user;

        }

    }
}
