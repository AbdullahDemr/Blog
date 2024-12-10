

using TigrisTech.Entities.Dtos.Editor.Profils;

namespace TigrisTech.MvcUI.Models.Profil
{
    public class ProfilUpdateAjaxViewModel
    {
        public ProfilUpdateDto ProfilUpdateDto { get; set; }
        public ProfilDto ProfilDto { get; set; }
        public string ProfilUpdatePartial { get; set; }
    }
}
