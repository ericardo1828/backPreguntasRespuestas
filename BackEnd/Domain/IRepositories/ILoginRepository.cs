using BackEnd.Domain.Models;
using System.Threading.Tasks;

namespace BackEnd.Domain.IRepositories
{
    public interface ILoginRepository
    {
        Task<Usuario> ValidarUser(Usuario usuario);
    }
}
