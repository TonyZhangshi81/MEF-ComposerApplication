using System.ComponentModel.Composition;
using System.Text;
using Tony.Common.UI;

namespace Tony.HelloTony
{
    /// <summary>
    /// 
    /// </summary>
    [Form("frm2")]
    public partial class Form2 : FormBase
    {
        /// <summary>
        /// 
        /// </summary>
        public Form2()
        {
            if(!this.DesignMode)
            {
                InitializeComponent();

                StringBuilder sb = new StringBuilder();
                sb.Append("Hello Tony1");
                sb.AppendLine();
                sb.Append("Hello Tony2");
                sb.AppendLine();
                sb.Append("Hello Tony3");

                base.Title = sb.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            base.ShowDialog("Window", "frm1");
        }
    }
}
