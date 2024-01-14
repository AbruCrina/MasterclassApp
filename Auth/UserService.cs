using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterclassApp.Models;

namespace MasterclassApp.Auth
{
    public class UserService
    {
        // AuthenticateClientAsync
        public async Task<Client> AuthenticateClientAsync(string email, string password)
        {
            // Try to authenticate as a Client
            Client authenticatedClient = await App.Database.AuthenticateClientAsync(email, password);
            return authenticatedClient;
        }

    }
}
