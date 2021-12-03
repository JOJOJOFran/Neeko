namespace Neeko.Abstractions
{
    /// <summary>
    /// 服务键值
    /// </summary>
    public readonly struct ServiceKey
    {
        public ServiceKey(string name, string instanceId)
        {
            Name = name;
            InstanceId = instanceId;
        }
        
        /// <summary>
        /// 服务名称
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// 实例Id
        /// </summary>
        public string InstanceId { get; }
    }
}