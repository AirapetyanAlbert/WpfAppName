using System.Windows;
using WpfApplDemo2018.ViewModel;
namespace WpfApplDemo2018.Helper
{
    public class FindRole
    {
        int id;
        public FindRole(int id)
        {
            this.id = id;
        }
        public bool RolePredicate(Model.Role role)
        {
            return role.Id == id;
        }
    }
}
