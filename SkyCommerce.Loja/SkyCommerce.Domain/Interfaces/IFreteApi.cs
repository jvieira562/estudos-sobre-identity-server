using Refit;

using SkyCommerce.ViewObjects;
using SkyCommerce.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkyCommerce.Interfaces
{
    public interface IFreteApi
    {
        [Get("/fretes/para/{lat},{lon}/calcular")]
        Task<IEnumerable<Frete>> Calcular([AliasAs("lat")] double latitude, [AliasAs("lon")] double longitude, Embalagem embalagem, [Header("Authorization")] string token);

        [Get("/fretes")]
        Task<IEnumerable<DetalhesFrete>> Modalidades();
    }
}