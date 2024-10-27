using dotNET_thuchanh2.Models;
using dotNET_thuchanh2.Resporitory;
using Microsoft.AspNetCore.Mvc;
namespace dotNET_thuchanh2.ViewComponents
{
    public class LoaiSpMenuViewComponent: ViewComponent
    {
        private readonly ILoaiSpRepository
            _loaiSp;
        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            _loaiSp = loaiSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSp.GetAllLoaiSp().OrderBy(x=>x.Loai);
            return View(loaisp);

        }
    }
}
