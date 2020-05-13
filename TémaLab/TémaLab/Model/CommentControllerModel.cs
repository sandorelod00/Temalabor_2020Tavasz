using TémaLab.Data.Entities;

namespace TémaLab.Model
{
    public class CommentControllerModel
    {
        public Comment comment;
        public User user;

        public CommentControllerModel(Comment comment, User user)
        {
            this.comment = comment;
            this.user = user;
        }
    }
}