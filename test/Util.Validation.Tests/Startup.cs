using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Util.Aop;
using Xunit.DependencyInjection;
using Xunit.DependencyInjection.Logging;

namespace Util.Validation.Tests {
    /// <summary>
    /// 启动配置
    /// </summary>
    public class Startup {
        /// <summary>
        /// 配置主机
        /// </summary>
        public void ConfigureHost( IHostBuilder hostBuilder ) {
            hostBuilder.AddUtil( t => t.UseAop() );
        }

        /// <summary>
        /// 配置日志提供程序
        /// </summary>
        public void Configure( ILoggerFactory loggerFactory, ITestOutputHelperAccessor accessor ) {
            loggerFactory.AddProvider( new XunitTestOutputLoggerProvider( accessor ) );
        }
    }
}
