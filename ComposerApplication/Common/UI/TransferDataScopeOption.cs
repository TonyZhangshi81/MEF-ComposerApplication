using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tony.Common.UI
{
    /// <summary>
    /// 画面遷移時に受け渡すデータの有効期間を指定する列挙型です。
    /// </summary>
    public enum TransferDataScopeOption
    {
        /// <summary>
        /// 永続化しないことを示します。
        /// </summary>
        /// <remarks>
        /// 実装者が指定しない限り、画面遷移時に値が自動的に破棄されます。
        /// </remarks>
        Impermanent,
        /// <summary>
        /// 永続化することを示します。
        /// </summary>
        /// <remarks>
        /// 実装者が指定しないでも、画面遷移時に値が自動的に受け渡されます。
        /// </remarks>
        Permanent,
    }
}
