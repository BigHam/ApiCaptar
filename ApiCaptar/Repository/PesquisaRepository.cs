using apiCaptar._1_Domain;
using apiCaptar.Configuration;
using apiCaptar.Data.ValueObjects;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace apiCaptar.Repository
{
    public class PesquisaRepository : IUpesquisaRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public PesquisaRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<pesquisaVO>> FindAll()
        {
            List<pesquisa> pesq = await _context.pesquisa.ToListAsync();
            return _mapper.Map<List<pesquisaVO>>(pesq);
        }

        public async Task<pesquisaVO> FindById(long id)
        {
            Usuario pesq = await _context.Usuarios.Where(u => u.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<pesquisaVO>(pesq);
        }
        public async Task<pesquisaVO> Create(pesquisaVO vo)
        {
            pesquisa pesq = _mapper.Map<pesquisa>(vo);
            _context.pesquisa.Add(pesq);
            await _context.SaveChangesAsync();
            return _mapper.Map<pesquisaVO>(pesq);
        }

        public async Task<pesquisaVO> Update(pesquisaVO vo)
        {
            pesquisa pesq = _mapper.Map<pesquisa>(vo);
            _context.pesquisa.Update(pesq);
            await _context.SaveChangesAsync();
            return _mapper.Map<pesquisaVO>(pesq);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                pesquisa pesq = await _context.pesquisa.Where(u => u.Id == id).FirstOrDefaultAsync();
                if (pesq == null) return false;
                _context.pesquisa.Remove(pesq);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception) {
                return false;
            }
        }

    }
}
