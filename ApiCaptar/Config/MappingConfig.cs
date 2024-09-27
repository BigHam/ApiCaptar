using apiCaptar._1_Domain;
using apiCaptar.Data.ValueObjects;
using AutoMapper;

namespace apiCaptar.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() { 
            var mappingConfing = new MapperConfiguration(config => {
                config.CreateMap<UsuarioVO, Usuario>();
                config.CreateMap<Usuario, UsuarioVO>();
                config.CreateMap<pesquisaVO, pesquisa>();
                config.CreateMap<pesquisa, pesquisaVO>();
            });
            return mappingConfing;
        }
    
        
    }
}
