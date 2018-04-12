using System;
using System.Collections.Generic;

namespace Ls.Cache
{
    /// <summary>
    /// redis 管理类
    /// </summary>
    public class redis_manager
    {
        /// <summary>
        /// redis_manager 私有实例
        /// </summary>
        private static redis_manager instance;

        /// <summary>
        /// redis_manager 实例
        /// </summary>
        public static redis_manager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new redis_manager();

                    return instance;
                }

                return instance;
            }
        }

        /// <summary>
        /// trs 连接
        /// </summary>
        private ServiceStack.Redis.RedisClient redis_client;

        /// <summary>
        /// 初始化trs connection
        /// </summary>
        public redis_manager()
        {
            try
            {
                redis_client = new ServiceStack.Redis.RedisClient("192.168.0.220", 6390, "");
            }
            catch (Exception ex)
            {
                Common.Logger.Error("开启trs连接出错，ERROR：", ex);
            }
        }

        public T get_value<T>(string key)
        {
            if (!string.IsNullOrEmpty(key))
            {
                try
                {
                    return redis_client.Get<T>(key);
                }
                catch (Exception ex)
                {
                    Common.Logger.Error("从redis里获取数据出错，ERROR：", ex);
                }
            }

            return default(T);
        }

        /// <summary>
        /// 从redis获取数据
        /// </summary>
        /// <param name="key"></param>
        public IEnumerable<T> get_values<T>(string key)
        {
            if (!string.IsNullOrEmpty(key))
            {
                try
                {
                    return redis_client.Get<IEnumerable<T>>(key);
                }
                catch (Exception ex)
                {
                    Common.Logger.Error("从redis里获取列表数据出错，ERROR：", ex);
                }
            }

            return null;
        }

        public bool set_value<T>(string key, T value)
        {
            if (!string.IsNullOrEmpty(key) && value != null)
            {
                try
                {
                    return redis_client.Set(key, value);
                }
                catch (Exception ex)
                {
                    Common.Logger.Error("向redis里写入单个数据出错，ERROR：", ex);
                }
            }
            return false;
        }

        /// <summary>
        /// 向redis里写入数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public bool set_values<T>(string key, IEnumerable<T> values)
        {
            if (!string.IsNullOrEmpty(key) && values != null)
            {
                try
                {
                    return redis_client.Set(key, values);
                }
                catch (Exception ex)
                {
                    Common.Logger.Error("向redis里写入数据出错，ERROR：", ex);
                }
            }

            return false;
        }
    }
}
