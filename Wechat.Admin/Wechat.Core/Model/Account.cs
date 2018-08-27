using System;
using System.Collections.Generic;
using System.Text;

namespace Wechat.Core.Model
{
    class Account
    {
        public string AppID { get; set; }
        public string AppSecret { get; set; }
        public string grant_type { get; set; }
    }
}
