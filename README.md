# Howe-Framework

---

Todo:

- HCore

    框架的核心类，以门面模式对外提供`服务容器`等功能()

- IService
    
    为服务定义基础生命周期`Initialize`、`IDispose`
  
- IProcedureService

    提供贯穿游戏的流程状态机服务，参考`GameFramework`的`Procedure`设计
  
- IFsmService

    提供状态机的创建、销毁、托管等服务
  
- IAssetService

    提供资产加载与管理的功能(异步加载、同步加载)
  
- IDatabaseService

    提供持久化数据的读取与写入功能
  
