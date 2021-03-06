/********************************************************************************
 Copyright (c) jiniannet (http://www.jiniannet.com). All rights reserved.
 Licensed under the MIT license. See licence.txt file in the project root for full license information.
 ********************************************************************************/

using System;
using System.Reflection;
namespace JinianNet.JNTemplate.Dynamic
{
    /// <summary>
    /// 动态方法信息
    /// </summary>
    public class DynamicMethodInfo
    {
        private ExcuteMethodDelegate excuteDelegate;
        private ParameterInfo[] parameters;
        private string name;
        private string fullName;

        /// <summary>
        /// 执行方法委托
        /// </summary>
        public ExcuteMethodDelegate Delegate
        {
            get { return excuteDelegate; }
            set { excuteDelegate = value; }
        }
        /// <summary>
        /// 形参
        /// </summary>
        public ParameterInfo[] Parameters
        {
            get { return parameters; }
            set { parameters = value; }
        }
        /// <summary>
        /// 方法名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 方法完整名称
        /// </summary>
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        /// <summary>
        /// 形参实参是否匹配
        /// </summary>
        public bool IsMatchParameters { get; set; }
    }
}