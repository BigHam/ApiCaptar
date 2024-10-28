using apiCaptar._1_Domain;
using apiCaptar._6_Repository.Interface;
using apiCaptar.Configuration;
using apiCaptar.Data.ValueObjects;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace apiCaptar._6_Repository.Implementation
{
    public class AtendimentoRepository : IAtendimentoRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public AtendimentoRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<atendimentoVO>> FindAll()
        {
            List<atendimento> atend = await _context.Atendimento.ToListAsync();
            return _mapper.Map<List<atendimentoVO>>(atend);
        }

        public async Task<atendimentoVO> FindById(long id)
        {
            Console.WriteLine($"Buscando atendimento com ID: {id}"); // Log para depuração

            atendimento atend = await _context.Atendimento
                .Where(u => u.id == id)
                .FirstOrDefaultAsync();

            if (atend == null)
            {
                Console.WriteLine("Atendimento não encontrado."); // Log se não encontrar
            }

            return _mapper.Map<atendimentoVO>(atend);
        }
        public async Task<atendimentoVO> Create(atendimentoVO vo)
        {
            atendimento atend = _mapper.Map<atendimento>(vo);
            _context.Atendimento.Add(atend);
            await _context.SaveChangesAsync();
            return _mapper.Map<atendimentoVO>(atend);
        }

        public async Task<atendimentoVO> Update(atendimentoVO vo)
        {
            atendimento atend = _mapper.Map<atendimento>(vo);
            _context.Atendimento.Update(atend);
            await _context.SaveChangesAsync();
            return _mapper.Map<atendimentoVO>(atend);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                atendimento atend = await _context.Atendimento.Where(u => u.id == id).FirstOrDefaultAsync();
                if (atend == null) return false;
                _context.Atendimento.Remove(atend);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
