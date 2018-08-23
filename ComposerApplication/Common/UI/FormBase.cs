using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Windows.Forms;
using Tony.Common.Util;

namespace Tony.Common.UI
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class FormBase : Form, IPresentationLayer
    {
        /// <summary>
        /// 
        /// </summary>
        private FormHelper _helper;

        /// <summary>
        /// 
        /// </summary>
        private FormHelper Helper
        {
            get
            {
                return this._helper ?? (this._helper = new FormHelper());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                ApplicationDeployment appd = ApplicationDeployment.CurrentDeployment;
                this.label1.Text = value + appd.CurrentVersion.ToString();

                int LblNum = value.Length;
                int RowNum = 10;
                int RowHeight = 200;
                int ColNum = (LblNum - (LblNum / RowNum) * RowNum) == 0 ? (LblNum / RowNum) : (LblNum / RowNum) + 1;
                label1.AutoSize = false;
                label1.Width = (int)(200);
                label1.Height = RowHeight * ColNum;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public FormBase()
        {
            if(!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formKey"></param>
        /// <returns></returns>
        public virtual FormBase GetForm(string sysMarker, string formKey)
        {
            return this.Helper.CreateForm(sysMarker, formKey);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sysMarker"></param>
        /// <param name="formKey"></param>
        public void ShowDialog(string sysMarker, string formKey)
        {
            var frm = this.GetForm(sysMarker, formKey);
            frm.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sysMarker"></param>
        /// <param name="formKey"></param>
        public void ShowWindow(string sysMarker, string formKey)
        {
            var frm = this.GetForm(sysMarker, formKey);
            frm.Show(this);
        }

        private IDictionary<string, TransferDataItem> _transferData;

        /// <summary>
        /// 次画面へ受け渡す値の設定のみを行います。
        /// </summary>
        /// <param name="transferData">次画面への受渡データ</param>
        public void SetTransferData(IDictionary<string, TransferDataItem> transferData)
        {
            this._transferData = transferData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, TransferDataItem> GetTransferData()
        {
            return this._transferData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controlId"></param>
        /// <returns></returns>
        public virtual string GetControlValue(string controlId)
        {
            return this.Controls.Find(controlId, false).FirstOrDefault().Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public virtual object GetFormProperty(string propertyName)
        {
            return  ReflectionUtil.GetProperty(this, propertyName);
        }
    }
}
