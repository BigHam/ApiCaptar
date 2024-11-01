using apiCaptar.Data.ValueObjects;

namespace apiCaptar._6_Repository.Interface;

public interface IAtendimentoRepository 
{
    Task<IEnumerable<atendimentoVO>> FindAll();
    Task<atendimentoVO> FindById(long id);
    Task<atendimentoVO> Create(atendimentoVO vo);
    Task<atendimentoVO> Update(atendimentoVO vo);
    Task<bool> Delete(long id);
}
