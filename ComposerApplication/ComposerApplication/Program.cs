using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Tony.Common;
using Tony.Common.Composition;
using Tony.Common.UI;

namespace ComposerApplication
{
    /// <summary>
    /// 
    /// </summary>
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Thread.GetDomain().UnhandledException += new UnhandledExceptionEventHandler(ConsoleMain_UnhandledException);

            ComposerFactory.Init();

            FormBase frm;
            try
            {
                frm = ComposerFactory.GetComporser("Tony").GetExports<FormBase, IFormMetadataView>().Where(s => s.Metadata.FormKey.Equals("frm1")).FirstOrDefault().Value;
            }
            catch (ComposerException ex)
            {
                frm = ComposerFactory.GetComporser("Common").GetExports<FormBase, IFormMetadataView>().Where(s => s.Metadata.FormKey.Equals("def")).FirstOrDefault().Value;
                var dict = new Dictionary<string, TransferDataItem>
                {
                    { "msg", new TransferDataItem(ex.Message) }
                };
                frm.SetTransferData(dict);
            }
            Application.Run(frm);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static private void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            try
            {
                Exception ex = e.Exception;
                MessageBox.Show(ex.InnerException.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static private void ConsoleMain_UnhandledException(object sender, System.UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
