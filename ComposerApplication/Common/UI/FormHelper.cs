using System.ComponentModel.Composition;
using Tony.Common.Composition;

namespace Tony.Common.UI
{
    /// <summary>
    /// 
    /// </summary>
    public class FormHelper
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly Composer _composer;

        /// <summary>
        /// 
        /// </summary>
        private bool _composed = false;

        /// <summary>
        /// 
        /// </summary>
        private void ComposeThis()
        {
            if(this._composed)
            {
                return;
            }

            this._composer.Compose(this);
            this._composed = true;
        }

        /// <summary>
        /// 
        /// </summary>
        [Import(typeof(IFormFactory))]
        private IFormFactory FormFactory
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public FormHelper()
        {
            this._composer = ComposerFactory.GetComporser("Common");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sysMarker"></param>
        /// <param name="formKey"></param>
        /// <returns></returns>
        public FormBase CreateForm(string sysMarker, string formKey)
        {
            this.ComposeThis();
            return FormFactory.GetFormInstance(sysMarker, formKey);
        }
    }
}
