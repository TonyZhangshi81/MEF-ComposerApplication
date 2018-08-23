using System;
using System.ComponentModel.Composition;

namespace Tony.Common.UI
{
    /// <summary>
    /// 
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class FormAttribute : ExportAttribute, IFormMetadataView
    {
        public FormAttribute(string formKey)
            : base(typeof(FormBase))
        {
            this.FormKey = formKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public string FormKey
        {
            get;
            private set;
        }
    }
}
