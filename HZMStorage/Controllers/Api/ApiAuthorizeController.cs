using GreenWhale.JWTAuthorize.Internal;
using HZMStorage.Helper;
using HZMStorage.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZMStorage.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiAuthorizeController : ControllerBase
    {
        private readonly ApplicationJooWMSDbContext dbContext;
        private readonly ISignInHelper signInHelper;

        public ApiAuthorizeController(ApplicationJooWMSDbContext applicationJooWMSDbContext)
        {
            this.dbContext = applicationJooWMSDbContext;
        }
        [HttpPost("CheckUserInfo")]
        public Result<object> CheckUserInfo([FromForm]Admin admin)
        {
            var userName = admin.UserName;
            var password = admin.PassWord;

            try
            {
                var userInfo_db = dbContext.Admin.Where(p => p.UserName == userName).FirstOrDefault();
                if (userInfo_db != null)
                {
                    if (password == userInfo_db.PassWord)
                    {
                        var token = signInHelper.AccessToken(new SessionUser() { UserId = userInfo_db.Id.ToString(), UserAccount = userName, UserPwd = userInfo_db.PassWord, UserName = userInfo_db.UserName, UserCode = Convert.ToInt32(userInfo_db.UserCode) }, null);

                        return new Result<object>(true, "登录成功", token);
                    }
                    else
                    {
                        return new Result<object>(false, "账户密码错误!");
                    }
                }
                else
                {
                    return new Result<object>(false, "不存在该账号!");
                }
            }
            catch (Exception e)
            {
                return new Result<object>(false, e.Message);
            }
        }
    }
}
