using Microsoft.EntityFrameworkCore;

namespace PROJETO_KANBAN.DATA
{
    public class appDbcontext : DbContext 
    {

        public appDbcontext(DbContextOptions<appDbcontext> options) : base(options)
        {

        }




    }
}
