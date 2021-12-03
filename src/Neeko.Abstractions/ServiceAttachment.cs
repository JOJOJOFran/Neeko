using System.Collections.Generic;

namespace Neeko.Abstractions
{
    /// <summary>
    /// 服务附加信息
    /// </summary>
    public readonly struct ServiceAttachment
    {
        public ServiceAttachment(string tag, Dictionary<string, string> metadata, int timestamp)
        {
            Tag = tag;
            Metadata = metadata;
            Timestamp = timestamp;
        }

        /// <summary>
        /// 标签
        /// </summary>
        public string Tag { get; }
        
        /// <summary>
        /// 元数据
        /// </summary>
        public Dictionary<string,string> Metadata { get; }
        
        /// <summary>
        /// 时间戳
        /// </summary>
        public int Timestamp { get; }
    }
}