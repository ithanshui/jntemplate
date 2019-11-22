﻿/********************************************************************************
 Copyright (c) jiniannet (http://www.jiniannet.com). All rights reserved.
 Licensed under the MIT license. See licence.txt file in the project root for full license information.
 ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace JinianNet.JNTemplate.Resources
{
    /// <summary>
    /// 默认加载提供器
    /// </summary>
    public class DefaultLoaderProvider : ILoaderProvider
    {
        private IResourceLoader loader;

        /// <summary>
        /// 构造函数
        /// </summary>
        public DefaultLoaderProvider(IResourceLoader loader)
        {
            this.loader = loader;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public DefaultLoaderProvider()
            : this(new FileLoader())
        {

        }

        /// <summary>
        /// 创建文件加载器
        /// </summary>
        /// <returns></returns>
        public IResourceLoader CreateLoader()
        {
            return loader;
        }
    }
}