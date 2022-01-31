using ReadyApp.Services;
using ReadyApp.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Models
{
    /// <summary>
    /// The auth model will have properties to verify the user authentication type.
    /// </summary>
    public class Auth : ModelBase
    {
        public static AuthType AuthType { get; private set; }
        //public User? User => GetUser();
        public bool IsAuthenticated;
        //public delegate void CustomAuth(string? email = null, string? password = null);
        public delegate void Authentication(string? email = null, string? password = null);
        //public delegate void SocialAuth();

        /// <summary>
        /// Account instances must specify which kind of authentication type was used
        /// This will allow data for log out information, providing the application with a logout method based on type of login
        /// </summary>
        /// <param name="authType">Authentication supported by application</param>
        //public Auth(AuthType authType, string? email = null, string? password = null)
        //{
        //    AuthType = authType;
        //    //CustomAuth customAuth;
        //    Authentication authentication;
        //    //SocialAuth socialAuth;

        //    if (AuthType.Equals(AuthType.ready))
        //    {
        //        authentication = async (email, password) => { await SignInWithReady(email, password); };
        //    }
        //    else if(AuthType.Equals(AuthType.google))
        //    {
        //        authentication = async (email, password) => { await SignInWithGoogle(); };
        //    }
        //    else
        //    {
        //        authentication = async (email, password) => { await SignInAnonymously(); }; ;
        //   }
        //    authentication();
        //}
        /// <summary>
        /// Initialize auth with a user will set its user value. Use when user has authenticated thier self.
        /// Also acts as a place to find out if a user has passed authentication, and much more
        /// </summary>
        /// <param name="authType">Authentication supported by application</param>
        /// <param name="user">Authenticated user</param>
        //public Auth(AuthType authType, User user)
        //{
        //    AuthType = authType;
        //    User = user;
        //}
        //public async Task SignInAnonymously()
        //{
        //    IsAuthenticated = await AuthService.SignInAnonymously();
        //}

        //public async Task SignInWithReady(string? email, string? password)
        //{
        //    IsAuthenticated = await AuthService.SignInWithReady(email, password);
        //}

        //public async Task SignInWithGoogle()
        //{
        //    IsAuthenticated = await AuthService.SignInWithGoogle();
        //}
        //private User? GetUser()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
