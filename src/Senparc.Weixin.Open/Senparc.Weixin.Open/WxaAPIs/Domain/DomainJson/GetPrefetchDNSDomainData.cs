﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2025 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2025 Senparc
    
    文件名：SetPrefetchDNSDomain.cs
    文件功能描述：设置DNS预解析域名请求参数
    
    
    创建标识：Yaofeng - 20220809
    

----------------------------------------------------------------*/

namespace Senparc.Weixin.Open.WxaAPIs.Domain
{
    /// <summary>
    /// 获取DNS预解析域名
    /// </summary>
    public class GetPrefetchDNSDomainData
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
    }

}
