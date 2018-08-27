using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Wechat.Admin.API
{
    /// <summary>
    /// 个性化菜单
    /// </summary>
    public class AddconditionalMenuController : ApiController
    {
        [HttpPost]
        public async Task<string> Create(string json)
        {
            return await Task.Run(() =>
            {
                return "Addconditional";
            });
        }

        [HttpDelete]
        public async Task<string> Delete(string json)
        {
            return await Task.Run(() =>
            {
                return "Addconditional";
            });
        }
    }
}
