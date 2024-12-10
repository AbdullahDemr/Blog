using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.JsonTable;

namespace TigrisTech.MvcUI.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {

        private readonly ContactPageInfo _contactPageInfo;

        public FooterViewComponent(IOptionsSnapshot<ContactPageInfo> contactPageInfo)
        {
            _contactPageInfo = contactPageInfo.Value;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_contactPageInfo);
        }
    }
}
