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
    
    文件名：SingleScancodeWaitmsgButton.cs
    文件功能描述：调起扫一扫工具，然后弹出“消息接收中”提示框
    
    
    创建标识：Senparc - 20150211
    
    修改标识：Senparc - 20150303
    修改描述：整理接口

    修改标识：Senparc - 20181005
    修改描述：菜单按钮类型（ButtonType）改为使用 Senparc.NeuChar.MenuButtonType
----------------------------------------------------------------*/
using Senparc.NeuChar;

namespace Senparc.Weixin.MP.Entities.Menu
{
    /// <summary>
    /// 单个按键
    /// </summary>
    public class SingleScancodeWaitmsgButton : SingleButton
    {
        /// <summary>
        /// 类型为scancode_waitmsg时必须。
        /// 用户点击按钮后，微信客户端将调起扫一扫工具，完成扫码操作后，将扫码的结果传给开发者，同时收起扫一扫工具，然后弹出“消息接收中”提示框，随后可能会收到开发者下发的消息。
        /// 仅支持微信iPhone5.4.1以上版本，和Android5.4以上版本的微信用户，旧版本微信用户点击后将没有回应，开发者也不能正常接收到事件推送。
        /// </summary>
        public string key { get; set; }

        public SingleScancodeWaitmsgButton()
            : base(MenuButtonType.scancode_waitmsg.ToString())
        {
        }
    }
}
