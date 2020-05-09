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
        /// <summary>
        /// 無効なメッセージ
        /// </summary>
        TypeInvalid,

        /// <summary>
        /// 接続メッセージ
        /// </summary>
        TypeHandShake,

        /// <summary>
        /// 切断メッセージ
        /// </summary>
        TypeDisconnect,

        /// <summary>
        /// ファイル送信メッセージ
        /// </summary>
        TypeFile,
    };

    /// <summary>
    /// メッセージデータ
    /// </summary>
    [Serializable()]
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
        /// 汎用メッセージ
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 汎用データ
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        public FTPMessageData(FTPMessageType type)
        {
            Header = MessageHeader.Clone() as char[];
            Type = type;
            Message = string.Empty;
            Data = null;
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
