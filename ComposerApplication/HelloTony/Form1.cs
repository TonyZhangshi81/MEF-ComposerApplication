using System.ComponentModel.Composition;
using Tony.Common.Composition;
using Tony.Common.UI;

namespace Tony.HelloTony
{
    /// <summary>
    /// 
    /// </summary>
    [Form("frm1")]
    public partial class Form1 : FormBase
    {
        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            if(!this.DesignMode)
            {
                InitializeComponent();

                base.Title = "Hello Tony";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            base.ShowWindow("Tony", "frm2");
            //var type = ComposerFactory.GetComporser("Tony").GetExportedValue<FormBase>("frm2").GetType();
            //var frm = (FormBase)Activator.CreateInstance(type);
            //var frm = ComposerFactory.GetComporser("Tony").GetExport<FormBase>("frm2").Value;
            //Lazy<FormBase> aa = new Lazy<FormBase>(() => new Form2());
            //frm.Show();
        }
    }
}
