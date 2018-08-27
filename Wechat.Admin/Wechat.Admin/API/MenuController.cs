using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Wechat.Admin.API
{
    public class MenuController : ApiController
    {
        [HttpGet]
        public async Task<string> All(int id)
        {
            return await Task.Run(() =>
            {
                return "Get";
            });
        }

        [HttpPost]
        public async Task<string> Create(string json)
        {
            return await Task.Run(() =>
            {
                return "Create";
            });
        }

        /// <summary>
        /// 在个性化菜单时，调用此接口会删除默认菜单及全部个性化菜单。
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<string> Delete(string json)
        {
            return await Task.Run(() =>
            {
                return "Delete";
            });
        }

        
    }
}
