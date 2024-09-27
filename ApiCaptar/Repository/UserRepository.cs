using apiCaptar.Configuration;
using apiCaptar.Data.ValueObjects;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace apiCaptar.Repository
{
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
            catch(Exception) {
                return false;
            }
        }

    }
}
