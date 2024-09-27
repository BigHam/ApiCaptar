
using apiCaptar.Data.ValueObjects;

namespace apiCaptar.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<UsuarioVO>> FindAll();
        Task<UsuarioVO> FindById(long id);
        Task<UsuarioVO> Create(UsuarioVO vo);
        Task<UsuarioVO> Update(UsuarioVO vo);
        Task<bool> Delete(long id);
    }
}
