using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tony.Common.UI
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class TransferDataItem
    {
        /// <summary>
        /// <see cref="TransferDataItem"/>の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="data">受け渡す値</param>
        public TransferDataItem(object data)
        {
            this.Data = data;
        }

        /// <summary>
        /// <see cref="TransferDataItem"/>の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="data">受け渡す値</param>
        /// <param name="scope">値を永続化するかどうかを示す値</param>
        public TransferDataItem(object data, TransferDataScopeOption scope)
            : this(data)
        {
            this.Scope = scope;
        }

        /// <summary>
        /// 受け渡すデータを取得します。
        /// </summary>
        public object Data
        {
            get;
            private set;
        }

        /// <summary>
        /// 受け渡すデータを永続化するかどうかを示す値を取得します。
        /// </summary>
        public TransferDataScopeOption Scope
        {
            get;
            private set;
        }

        /// <summary>
        /// 現在のインスタンスを表す文字列を返します。
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Data != null ? this.Data.ToString() : null;
        }
    }
}
