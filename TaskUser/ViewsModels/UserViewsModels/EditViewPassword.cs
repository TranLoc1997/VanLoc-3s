using TaskUser.Models;

namespace TaskUser.ViewsModels
{
    public class EditViewPassword
    {
        public int Id { get; set; }
        public string PassWord { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        
    }
}