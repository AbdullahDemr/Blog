

using TigrisTech.Shared.Entities.Abstract;

namespace TigrisTech.Entities.Concrete.Editor
{
    public class Profil : EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Picture { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string TcNo { get; set; }
        public string About { get; set; }

        public string YoutubeLink { get; set; }
        public string TwitterLink { get; set; }
        public string InstagramLink { get; set; }
        public string FacebookLink { get; set; }
        public string LinkedInLink { get; set; }
        public string GitHubLink { get; set; }
        public string WebsiteLink { get; set; }
    }
}
