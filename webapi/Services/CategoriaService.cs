using proyectoef;
using proyectoef.Models;

namespace webapi.Services;


public class CategoriaService
{

    TareasContext context;

    public CategoriaService(TareasContext dbContext)
    {
        context = dbContext;
    }

    public IEnumerable<Categoria> Get()
    {
        return context.Categorias;
    }


}

public interface ICategoriaService
{

}
