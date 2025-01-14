
# ASP.NET Core MVC Login Test 项目
## 项目概述
本项目是一个基于ASP.NET Core MVC框架的登录测试项目，旨在为开发者提供一个学习与实践ASP.NET Core技术栈的示例。项目主体遵循杨中科所著《ASP.NET Core技术内幕与项目实践》一书中的指导原则和最佳实践。
## 主要技术
- **依赖注入（Dependency Injection）**：项目采用了ASP.NET Core内置的依赖注入容器，以实现控制反转和降低组件间的耦合度，提高代码的可测试性和可维护性。
- **EF Core（Entity Framework Core）**：作为ORM框架，EF Core被用于数据访问层的实现，以简化数据库操作，并支持Code First开发模式。
- **MVC三层架构**：项目遵循模型-视图-控制器（Model-View-Controller）的设计模式，将应用程序分为三个逻辑层，以实现关注点分离。
- **内存Mock库**：为了模拟和测试学生信息等数据操作，项目使用了内存Mock库，以便在不依赖实际数据库的情况下进行开发测试。
## 项目特点
- **安全性**：项目实现了用户身份验证和授权，确保只有授权用户才能访问受保护的资源。
- **可扩展性**：基于依赖注入和MVC架构，项目具有良好的可扩展性，便于未来功能的添加和修改。
- **模块化**：代码结构清晰，模块化设计使得各个组件可以独立开发和测试。
## 功能模块
- **用户认证**：提供用户注册、登录、注销功能，以及密码加密存储。
- **学生信息管理**：实现对学生信息的增删改查操作，支持分页和搜索功能。
- **单元测试**：项目包含了一系列单元测试，以确保各个模块的功能正确性和稳定性。
## 开发环境
- **IDE**：推荐使用Visual Studio 2019或更高版本。
- **.NET Core SDK**：需要安装与项目兼容的.NET Core SDK版本。
## 快速开始
1. 克隆项目到本地：
   ```bash
   git clone https://github.com/Wepre/LoginTest_MVC
   ```
2. 打开解决方案文件并编译：
   使用Visual Studio打开项目并构建解决方案。
3. 运行应用程序：
   在Visual Studio中设置项目为启动项，并运行。
## 贡献指南
我们欢迎任何形式的贡献，包括但不限于代码提交、问题报告和功能建议。请遵循以下步骤进行贡献：
1. Fork本项目。
2. 创建您的特性分支 (`git checkout -b feature/your-feature`).
3. 提交您的更改 (`git commit -m 'Add some feature'`).
4. 推送到分支 (`git push origin feature/your-feature`).
5. 创建新的Pull Request。
## 许可证
本项目采用[MIT许可证](https://opensource.org/licenses/MIT)。
请确保在贡献代码前阅读并理解许可证条款。
## 支持者
李泽昊