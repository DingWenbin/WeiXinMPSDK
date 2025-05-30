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
    
    文件名：MessageHandlerException.cs
    文件功能描述：微信消息异常处理类
    
    
    创建标识：Senparc - 20150211
    
    修改标识：Senparc - 20150303
    修改描述：整理接口

    修改标识：Senparc - 20170101
    修改描述：统一构造函数调用（将第一个构造函数的base改为this）

----------------------------------------------------------------*/


using System;

namespace Senparc.Weixin.Exceptions
{
    /// <summary>
    /// MessageHandler异常
    /// </summary>
    public class MessageHandlerException : WeixinException
    {
          public MessageHandlerException(string message)
            : this(message, null)
        {
        }

          public MessageHandlerException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
