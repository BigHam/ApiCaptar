using apiCaptar._1_Domain;
using apiCaptar.Data.ValueObjects;
using AutoMapper;

namespace apiCaptar.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() { 
            var mappingConfing = new MapperConfiguration(config => {
                config.CreateMap<UsuarioVO, Usuario>().ReverseMap();
               
                config.CreateMap<pesquisaVO, Pesquisa>().ReverseMap();
               
            });
            return mappingConfing;
        }
    
        
    }
}
