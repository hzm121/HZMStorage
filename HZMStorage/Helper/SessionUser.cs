using GreenWhale.JWTAuthorize.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZMStorage.Helper
{
    public class SessionUser : ISessionUser
    {

        public SessionUser() { }
        public SessionUser(string userId, string userPwd, string userName, int UserCode) { }

        public string UserAccount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UserCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserPwd { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
