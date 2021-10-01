using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace HotelGestion.Models
{
    public class MyRoleProvider : RoleProvider
    {
        public Model1 db = new Model1();
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            return db.Roles.Select(item => item.NomRole).ToArray<String>();
        }

        public override string[] GetRolesForUser(string username)
        {
            User u = db.Users.FirstOrDefault(item => item.Login == username);
            if (u != null)
            {
                return new string[] { u.UserRole.NomRole };
            }
            return null;
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            User u = db.Users.FirstOrDefault(item => item.Login == username);
            if (u != null)
            {
                if (u.UserRole.NomRole == roleName)
                    return true;
                return false;
            }
            return false;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}