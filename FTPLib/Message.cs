using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPLib
{
    /// <summary>
    /// メッセージタイプ
    /// </summary>
    public enum FTPMessageType
    {
        TypeInvalid,
        TypeFile,
    };

    /// <summary>
    /// メッセージデータ
    /// </summary>
    public struct FTPMessageData
    {
        /// <summary>
        /// ヘッダー
        /// </summary>
        public char[] Header { get; set; }

        /// <summary>
        /// タイプ
        /// </summary>
        public FTPMessageType Type { get; set; }

        /// <summary>
        /// データサイズ
        /// </summary>
        public UInt64 Size { get; set; }

        /// <summary>
        /// 汎用データ
        /// </summary>
        public Int32[] Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        public FTPMessageData(FTPMessageType type)
        {
            Header = MessageHeader.Clone() as char[];
            Type = type;
            Size = 0;
            Value = new Int32[8];
        }

        /// <summary>
        /// データの有効チェック
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            return (Type != FTPMessageType.TypeInvalid) && (MessageHeader.SequenceEqual(Header));
        }

        /// <summary>
        /// 
        /// </summary>
        private static char[] MessageHeader = new char[8] { 'F', 'T', 'P', 'M', 'S', 'G', 'H', 'R' };
    }
}
