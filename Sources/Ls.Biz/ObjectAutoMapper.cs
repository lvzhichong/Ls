// Map
using AutoMapper;

namespace Ls.Biz
{
    /// <summary>
    /// 对象映射配置
    /// </summary>
    public class ObjectAutoMapper
    {
        private static ObjectAutoMapper instance;

        /// <summary>
        /// ObjectAutoMapper 实例
        /// </summary>
        public static ObjectAutoMapper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjectAutoMapper();

                    return instance;
                }

                return instance;
            }
        }

        /// <summary>
        /// 配置对象之间的映射
        /// </summary>
        public void Configure()
        {
            // User
            Mapper.Initialize(cgf => cgf.CreateMap<DataAccess.Models.ls_user, Models.ls_user>());
            Mapper.Initialize(cgf => cgf.CreateMap<Models.ls_user, DataAccess.Models.ls_user>());

            // Duty
            Mapper.Initialize(cgf => cgf.CreateMap<DataAccess.Models.ls_duty, Models.ls_duty>());
            Mapper.Initialize(cgf => cgf.CreateMap<Models.ls_duty, DataAccess.Models.ls_duty>());

            // Role
            Mapper.Initialize(cgf => cgf.CreateMap<DataAccess.Models.ls_role, Models.ls_role>());
            Mapper.Initialize(cgf => cgf.CreateMap<Models.ls_role, DataAccess.Models.ls_role>());

            // Module
            Mapper.Initialize(cgf => cgf.CreateMap<DataAccess.Models.ls_module, Models.ls_module>());
            Mapper.Initialize(cgf => cgf.CreateMap<Models.ls_module, DataAccess.Models.ls_module>());

            // Module
            Mapper.Initialize(cgf => cgf.CreateMap<DataAccess.Models.ls_duty_module, Models.ls_duty_module>());
            Mapper.Initialize(cgf => cgf.CreateMap<Models.ls_duty_module, DataAccess.Models.ls_duty_module>());
        }
    }
}