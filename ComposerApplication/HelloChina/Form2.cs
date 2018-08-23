using System.Text;
using Tony.Common.UI;

namespace Tony.HelloChina
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
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, System.EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello China");
            sb.AppendLine();
            sb.Append("Hello China");

            base.Title = sb.ToString();
        }
    }
}
