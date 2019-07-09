using Autofac;
using IOC.Repository;
using IOC.Service;


namespace IOC.Container
{
    public class Container
    {
        /// <summary>
        /// 容器 单例
        /// </summary>
        public static IContainer Instance;

        public static void Init()
        {
            //新建容器构建器，用于注册组件和服务
            var builder = new ContainerBuilder();
            //自定义注册
            MyBuild(builder);
            //利用构建器创建容器
            Instance = builder.Build();
        }

        /// <summary>
        /// 自定义注册
        /// </summary>
        /// <param name="builder"></param>
        public static void MyBuild(ContainerBuilder builder)
        {
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ProductService>().As<IProductService>();
        }
    }
}
