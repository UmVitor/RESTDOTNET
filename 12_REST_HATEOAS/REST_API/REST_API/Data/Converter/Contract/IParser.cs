using System.Collections.Generic;

namespace REST_API.Data.Converter.Contract
{
    public interface IParser<O , D>
    {
        //D - Destino
        //O - Origem 
        D Parse(O origin); //vai receber um objeto origem, e vai reveber um objeto destino

        List<D> Parse(List<O> origin);
    }
}
