using System.Collections.Generic;

namespace Neeko.Abstractions
{
    /// <summary>
    /// 定义服务接口
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// 服务名称
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// 实例Id
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// 服务接入点
        /// </summary>
        public string EntryPoint { get; }
        
        /// <summary>
        /// 标签数据(集群或流量标注)
        /// </summary>
        public string Tag { get; }
        
        /// <summary>
        /// 元数据
        /// </summary>
        public Dictionary<string, string> MetaData { get; }
        
        /// <summary>
        /// 服务状态
        /// </summary>
        public ServiceStatus Status { get; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public uint Timestamp { get; }
    }
    
    /// <summary>
    /// 服务状态
    /// </summary>
    public enum ServiceStatus
    {
        Initialize,
        Healthy,
        UnHealthy,
        TimeOut,
        
    }
}