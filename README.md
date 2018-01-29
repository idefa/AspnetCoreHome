# 简介
这个仓库是Asp.net Core官网的一个合集,方便一次性Clone; 我们比任何时候更接近真相(源码)
## [Asp.net Core 简介](https://docs.microsoft.com/zh-cn/aspnet/core/)
Asp.net Core和传统的Asp.net有很大的区别,Asp.net Core是一次重新改版.比如没有了 System.Web.dll,HttpModule,HttpHandler,Global.asax等. Asp.net Core的一个核心原则是模块化, 它由一系列细粒度的Nuget包组成并且默认都不加载,当你实现某个功能才需要增加相应的Nuget包,这样就保证了你安装了最小化包集合.
> Asp.net Core 2.0 新增了一个 Microsoft.AspNet.All nuget包,用来打包Asp.net Core相关的所有包.
![.net core](https://gitee.com/uploads/images/2018/0123/145154_42b9985c_1390534.png ".net core")
![net standard](https://gitee.com/uploads/images/2018/0129/170535_6bb2348b_1390534.png "TIM截图20180129142552.png")
## 工具安装
1. [.Net Core SDK 和 Visual Studio Code下载安装](https://www.microsoft.com/net/download/)
2. [Visual Studio Code下载安装](https://code.visualstudio.com/)

## [快速入门](http://netgos.com/corequickstart/)
net core有区别于以前的开发模式，提供了类似NodeJs的开发体验，建议的开发模式[Visual Studio Code](https://code.visualstudio.com/) + [命令行工具](https://docs.microsoft.com/zh-cn/dotnet/core/tools/?tabs=netcore2x)
1. [Visual Studio 创建](https://docs.microsoft.com/zh-cn/aspnet/core/tutorials/first-mvc-app/start-mvc?tabs=aspnetcore2x)
2. [命令行创建](https://docs.microsoft.com/zh-cn/aspnet/core/getting-started)

## 基本概念

1. [NET Core 指南](https://docs.microsoft.com/zh-cn/dotnet/core/index)
2. [ASP.NET Core 基础知识](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/index?tabs=aspnetcore2x)
3. [中间件](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/middleware?tabs=aspnetcore2x)
4. [配置](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/configuration)
5. [依赖注入](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/dependency-injection)

## 更重要的概念
1. [.NET Standard](https://docs.microsoft.com/zh-cn/dotnet/standard/net-standard)
2. [命令行工具](https://docs.microsoft.com/zh-cn/dotnet/core/tools/?tabs=netcore2x)

## GitHub资料

1. [Awesome .NET Core](https://github.com/thangchung/awesome-dotnet-core/)
2. [Entropy](https://github.com/aspnet/Entropy/tree/dev/samples)

## asp.net core mvc 由一个个独立的git项目组成，相互依赖，可以灵活替换。各个模块扩展，重写也非常方便。
![repositories](https://gitee.com/uploads/images/2018/0123/150100_976cc7cc_1390534.png "clipboard1.png")

## 1.Configuration
配置是基于Key/Value形式的,提供基于命令行参数，运行环境变量， ini文件，json文件，xml文件的文件格式的Configuration Provder.
1. [读取配置信息](http://www.cnblogs.com/artech/p/asp-net-core-config-01.html)
2. [配置模型详解](http://www.cnblogs.com/artech/p/asp-net-core-config-02.html)
3. [将配置绑定为对象[上篇]](http://www.cnblogs.com/artech/p/asp-net-core-config-03.html)
4. [将配置绑定为对象[下篇]](http://www.cnblogs.com/artech/p/asp-net-core-config-04.html)
5. [多样性的配置源[上篇]](http://www.cnblogs.com/artech/p/asp-net-core-config-4-1.html)
6. [多样性的配置源[中篇]](http://www.cnblogs.com/artech/p/asp-net-core-config-4-2.html)
7. [多样性的配置源[下篇]](http://www.cnblogs.com/artech/p/asp-net-core-config-4-3.html)
8. [配置的同步[上篇]](http://www.cnblogs.com/artech/p/asp-net-core-config-5-1.html)
9. [配置的同步[下篇]](http://www.cnblogs.com/artech/p/asp-net-core-config-5-2.html)







