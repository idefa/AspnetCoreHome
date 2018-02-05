# 简介
这个仓库是Asp.net Core官网的一个合集,方便一次性Clone; 我们比任何时候更接近真相(源码)

## [Asp.Net Core 是开源,跨平台,模块化,快速而简单的Web框架](https://docs.microsoft.com/zh-cn/aspnet/core/)

![.net core](https://gitee.com/uploads/images/2018/0123/145154_42b9985c_1390534.png ".net core")

![modules](https://gitee.com/uploads/images/2018/0202/130232_dfeea866_1390534.png "aspnetcore_modules.png")

![net standard](https://gitee.com/uploads/images/2018/0129/170535_6bb2348b_1390534.png "TIM截图20180129142552.png")
## 工具安装
1. [.Net Core SDK 和 Visual Studio Code下载安装](https://www.microsoft.com/net/download/)
2. [Visual Studio Code下载安装](https://code.visualstudio.com/)

## 快速入门
net core有区别于以前的开发模式，提供了类似NodeJs的开发体验，建议的开发模式[Visual Studio Code](https://code.visualstudio.com/) + [命令行工具](https://docs.microsoft.com/zh-cn/dotnet/core/tools/?tabs=netcore2x)
- [安装](http://netgos.com/corequickstart/)
- [一个最小的应用](http://netgos.com/corequickstart/)
- [项目模板](http://netgos.com/corequickstart/)
- [路由](http://netgos.com/corequickstart/)
- [静态文件](http://netgos.com/corequickstart/)
- [页面渲染](http://netgos.com/corequickstart/)
- [Razor模板引擎](http://netgos.com/corequickstart/)
- [请求](http://netgos.com/corequickstart/)
- [错误和重定向](http://netgos.com/corequickstart/)
- [关于响应](http://netgos.com/corequickstart/)
- [会话](http://netgos.com/corequickstart/)
- [日志](http://netgos.com/corequickstart/)
- [配置](http://netgos.com/corequickstart/)
- [国际化和多语言](http://netgos.com/corequickstart/)

## 请求流程

![输入图片说明](https://gitee.com/uploads/images/2018/0205/153224_f46d7b73_1390534.png "请求流程.png")
![输入图片说明](https://gitee.com/uploads/images/2018/0205/153401_a3ded117_1390534.png "请求流程2.png")

asp.net core实现了一个跨平台的宿主和web服务器. 一旦你调用了WebHost对象的Start方法,你就运行了一个监听Http请求的Web服务器,它可以运行在32位的linux系统甚至是树莓派上.然而在生产环境还是建议你使用一些反向代理工具,如Nginx,IIs,Apache等.为什么需要反向代理,因为Kestrel只是一个简单的Web服务器,其他语言像java,python,nodejs,ruby,你会看到一些Web服务器PM2或者Passenger结合反向代理工具使用.这些Web服务器提供了监控,日志,负载均衡和流程管理功能,对于一个成熟的Web服务器而言.在Windows平台,你可以使用IIS反向代理,在linux服务器使用nginx/apache来实现反向代理.

- [宿主](http://netgos.com/corequickstart/)
- [Web服务器](http://netgos.com/corequickstart/)
- [请求委托](http://netgos.com/corequickstart/)
- [代码模拟](https://gitee.com/defa/aspnetcore_study)

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
3. [官方DotNetTools](https://github.com/aspnet/DotNetTools)
3. [dotnet-tools](https://github.com/natemcmaster/dotnet-tools)

## 国外博客
1. [joonasw.net](https://joonasw.net)
2. [dotnetliberty](https://dotnetliberty.com)

## 国内博客
1. [jessetalk](http://www.jessetalk.cn/category/tech/)
2. [vipyoumay](http://www.cnblogs.com/vipyoumay/category/842989.html)


# Mvc
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







