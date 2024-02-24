using Bressingham.Workshop.WebTools.Data;

namespace Bressingham.Workshop.WebTools.Logic
{
    public class WebToolsLogic : IWebToolsLogic
    {
        private readonly WebToolsContext _context;

        public WebToolsLogic(WebToolsContext context)
        {
            _context = context;
        }

        public int GetNumberOfMaterials()
        {
            return _context.Materials.Count();
        }
    }
}
