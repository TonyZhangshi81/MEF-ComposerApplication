
using Tony.Common.Composition;
using Tony.Common.UI;
namespace Tony.HelloChina
{
    [Form("frm1")]
    public partial class Form1 : FormBase
    {
        public Form1()
        {
            if(!this.DesignMode)
            {
                InitializeComponent();
                base.Title = "Hello China";
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var frm = ComposerFactory.GetComporser("Tony").GetExport<FormBase>("frm2").Value;
            frm.Show();
        }
    }
}
