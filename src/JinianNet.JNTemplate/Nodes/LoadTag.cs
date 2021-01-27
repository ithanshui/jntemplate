/********************************************************************************
 Copyright (c) jiniannet (http://www.jiniannet.com). All rights reserved.
 Licensed under the MIT license. See licence.txt file in the project root for full license information.
 ********************************************************************************/
using JinianNet.JNTemplate.Resources;
using System;
using System.IO;
#if !NET20
using System.Threading.Tasks;
#endif

namespace JinianNet.JNTemplate.Nodes
{
    /// <summary>
    /// LOAD标签
    /// </summary>
    [Serializable]
    public class LoadTag : BlockTag
    {
        private ITag path;
        /// <summary>
        /// 模板路径
        /// </summary>
        public ITag Path
        {
            get { return this.path; }
            set { this.path = value; }
        } 
    }
}