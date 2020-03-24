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

        /// <summary>
        /// 解析标签
        /// </summary>
        /// <param name="context">上下文</param>
        public override object ParseResult(TemplateContext context)
        {
            object path = this.path.ParseResult(context);
            LoadResource(path, context);
            return base.ParseResult(context);
        }
        /// <summary>
        /// 解析标签
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="write">write</param>
        public override void Parse(TemplateContext context, TextWriter write)
        {
            object path = this.path.ParseResult(context);
            LoadResource(path, context);
            base.Parse(context, write);
        }

        /// <summary>
        /// 加载资源
        /// </summary>
        /// <param name="path"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        protected void LoadResource(object path, TemplateContext context)
        {
            if (path != null)
            {
                var paths =
#if NETCOREAPP || NETSTANDARD
                    context.GetResourceDirectories();
#else
                    TemplateContextExtensions.GetResourceDirectories(context);
#endif
                ResourceInfo info = context.Loader.Load(path.ToString(), context.Charset, paths);
                if (info != null)
                {
                    this.TemplateContent = info.Content;
                    this.TemplateKey = info.FullPath;
                }
            }
        }

#if NETCOREAPP || NETSTANDARD

        /// <summary>
        /// 加载资源
        /// </summary>
        /// <param name="path"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        protected async Task LoadResourceAsync(object path, TemplateContext context)
        {
            if (path != null)
            {
                var paths = context.GetResourceDirectories();
                ResourceInfo info = await context.Loader.LoadAsync(path.ToString(), context.Charset, paths);
                if (info != null)
                {
                    this.TemplateContent = info.Content;
                    this.TemplateKey = info.FullPath;
                }
            }
        }

        /// <summary>
        /// 解析标签
        /// </summary>
        /// <param name="context">上下文</param>
        public override async Task<object> ParseResultAsync(TemplateContext context)
        {
            object path = await this.path.ParseResultAsync(context);
            await LoadResourceAsync(path, context);
            return base.ParseResultAsync(context);
        }
        /// <summary>
        /// 解析标签
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="write">write</param>
        public override async Task ParseAsync(TemplateContext context, TextWriter write)
        {
            object path = await this.path.ParseResultAsync(context);
            await LoadResourceAsync(path, context);
            await base.ParseAsync(context, write);
        }
#endif
    }
}