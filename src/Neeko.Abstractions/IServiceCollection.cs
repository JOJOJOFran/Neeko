namespace Neeko.Abstractions
{
    /// <summary>
    /// 定义服务集合
    /// </summary>
    public interface IServiceCollection
    {
        /// <summary>
        /// 注册服务
        /// </summary>
        /// <param name="service">服务</param>
        bool Register(IService service);

        /// <summary>
        /// 注销指定的服务
        /// </summary>
        /// <param name="serviceKey">服务唯一键值</param>
        bool UnRegister(ServiceKey serviceKey);
        
        /// <summary>
        /// 更新服务内容
        /// </summary>
        /// <param name="serviceKey">服务唯一键值</param>
        /// <param name="attachment">服务附加信息</param>
        /// <returns></returns>
        bool Update(ServiceKey serviceKey,ServiceAttachment attachment);
    }
}