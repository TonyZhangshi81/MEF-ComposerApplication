using System;
using System.Linq;
using System.ComponentModel.Composition;
using Tony.Common.Composition;
using System.Collections.Generic;

namespace Tony.Common.UI
{
    /// <summary>
    /// 
    /// </summary>
    [PartCreationPolicy(CreationPolicy.Shared)]
    [Export(typeof(IFormFactory))]
    public class FormFactory : IFormFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public FormFactory()
		{
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sysMarker"></param>
        /// <param name="formKey"></param>
        /// <returns></returns>
        public virtual FormBase GetFormInstance(string sysMarker, string formKey)
        {
            var value = ComposerFactory.GetComporser(sysMarker).GetExports<FormBase, IFormMetadataView>().Where(f => f.Metadata.FormKey.Equals(formKey)).FirstOrDefault();
            if(value == null)
            {
                throw new Exception("err");
            }

            var frm = (FormBase)Activator.CreateInstance(value.Value.GetType());
            return frm;
        }
    }
}
