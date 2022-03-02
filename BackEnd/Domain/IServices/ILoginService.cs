using BackEnd.Domain.Models;
using System.Threading.Tasks;

namespace BackEnd.Domain.IServices
{
    public interface ILoginService
    {
        Task<Usuario> ValidarUser(Usuario usuario);
    }
}
