using Tony.Common.UI;

namespace HelloWindow
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

                base.Title = "Hello Window";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            base.ShowWindow("China", "frm2");
        }
    }
}
