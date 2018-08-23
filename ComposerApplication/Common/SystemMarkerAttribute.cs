using System;

namespace Tony.Common
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    public sealed class SystemMarkerAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public SystemMarkerAttribute(string id)
        {
            this.SystemId = id;
        }

        /// <summary>
        /// 
        /// </summary>
        public string SystemId
        {
            get;
            set;
        }
    }
}
