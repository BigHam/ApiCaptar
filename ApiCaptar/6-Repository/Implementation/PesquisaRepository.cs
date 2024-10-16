using apiCaptar._1_Domain;
using apiCaptar.Configuration;
using apiCaptar.Data.ValueObjects;
using apiCaptar.Repository.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace apiCaptar.Repository.Implementation;

public class PesquisaRepository : IpesquisaRepository
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
        List<Pesquisa> pesq = await _context.Pesquisa.ToListAsync();
        return _mapper.Map<List<pesquisaVO>>(pesq);
    }

    public async Task<pesquisaVO> FindById(long id)
    {
        Usuario pesq = await _context.Usuarios.Where(u => u.id == id).FirstOrDefaultAsync();
        return _mapper.Map<pesquisaVO>(pesq);
    }
    public async Task<pesquisaVO> Create(pesquisaVO vo)
    {
        Pesquisa pesq = _mapper.Map<Pesquisa>(vo);
        _context.Pesquisa.Add(pesq);
        await _context.SaveChangesAsync();
        return _mapper.Map<pesquisaVO>(pesq);
    }

    public async Task<pesquisaVO> Update(pesquisaVO vo)
    {
        Pesquisa pesq = _mapper.Map<Pesquisa>(vo);
        _context.Pesquisa.Update(pesq);
        await _context.SaveChangesAsync();
        return _mapper.Map<pesquisaVO>(pesq);
    }

    public async Task<bool> Delete(long id)
    {
        try
        {
            Pesquisa pesq = await _context.Pesquisa.Where(u => u.Id == id).FirstOrDefaultAsync();
            if (pesq == null) return false;
            _context.Pesquisa.Remove(pesq);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

}
