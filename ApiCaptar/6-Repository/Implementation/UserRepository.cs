using apiCaptar.Configuration;
using apiCaptar.Data.ValueObjects;
using apiCaptar.Repository.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace apiCaptar.Repository.Implementation;

public class UserRepository : IUserRepository
{
    private readonly MySQLContext _context;
    private IMapper _mapper;

    public UserRepository(MySQLContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UsuarioVO>> FindAll()
    {
        List<Usuario> users = await _context.Usuarios.ToListAsync();
        return _mapper.Map<List<UsuarioVO>>(users);
    }

    public async Task<UsuarioVO> FindById(long id)
    {
        Usuario user = await _context.Usuarios.Where(u => u.Id == id).FirstOrDefaultAsync();
        return _mapper.Map<UsuarioVO>(user);
    }
    public async Task<UsuarioVO> Create(UsuarioVO vo)
    {
        Usuario user = _mapper.Map<Usuario>(vo);
        _context.Usuarios.Add(user);
        await _context.SaveChangesAsync();
        return _mapper.Map<UsuarioVO>(user);
    }

    public async Task<UsuarioVO> Update(UsuarioVO vo)
    {
        Usuario user = _mapper.Map<Usuario>(vo);
        _context.Usuarios.Update(user);
        await _context.SaveChangesAsync();
        return _mapper.Map<UsuarioVO>(user);
    }

    public async Task<bool> Delete(long id)
    {
        try
        {
            Usuario user = await _context.Usuarios.Where(u => u.Id == id).FirstOrDefaultAsync();
            if (user == null) return false;
            _context.Usuarios.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<UsuarioVO> FindByEmailAndPassword(string email, string password)
    {
        // Verifica se existe um usuário com o email informado
        var user = await _context.Usuarios
            .FirstOrDefaultAsync(u => u.email == email);

        // Se o usuário não existir, retorna null
        if (user == null)
        {
            return null;
        }

        // Compara a senha diretamente
        if (user.senha == password) // Aqui estamos comparando a senha diretamente
        {
            // Mapeia a entidade de volta para o VO
            return _mapper.Map<UsuarioVO>(user);
        }

        return null; // Senha incorreta
    }


}
