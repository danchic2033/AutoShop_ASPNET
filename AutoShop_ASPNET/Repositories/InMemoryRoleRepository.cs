using AutoShop_ASPNET.Models;
using System.Data;

namespace AutoShop_ASPNET.Repositories
{
    public class InMemoryRoleRepository : IRoleRepository
    {
        private readonly List<Role> _roles = [];
        public void Add(Role role)
        {
            role.Id = Guid.NewGuid();

            _roles.Add(role);
        }

        public void Remove(Guid roleId)
        {
            var existingRole = TryGetById(roleId);

            if (existingRole != null)
            {
                _roles.Remove(existingRole);
            }
        }

        public List<Role> GetAll() => _roles;


        public Role? TryGetById(Guid roleId) =>
            _roles.FirstOrDefault(role => role.Id == roleId);

        public Role? TryGetByName(string roleName) =>
            _roles.FirstOrDefault(role => role.Name == roleName);

    }
}
