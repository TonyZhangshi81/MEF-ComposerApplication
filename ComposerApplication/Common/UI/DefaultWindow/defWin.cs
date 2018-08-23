namespace Tony.Common.UI.DefaultWindow
{
    /// <summary>
    /// 
    /// </summary>
    [Form("def")]
    public partial class defWin : FormBase
    {
        /// <summary>
        /// 
        /// </summary>
        public defWin()
        {
            if(!this.DesignMode)
            {
                InitializeComponent();

                base.Title = "Default Window";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defWin_Load(object sender, System.EventArgs e)
        {
            base.Title = base.GetTransferData()["msg"].ToString();
        }
    }
}
