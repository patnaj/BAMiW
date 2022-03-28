using Microsoft.AspNetCore.Identity;
namespace LAB1.Models{
    public class RoleModel : IdentityRole<int>
    {
        public RoleModel(string name){
            this.Name = name;
        }

        public RoleModel(){}
    }
}