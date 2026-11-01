# JokerMod

杀戮尖塔 2 角色模组。小丑开局同时带着五个角色的基础牌组和初始遗物，卡牌、遗物、药水奖励也从五个角色的池子里抽取。

依赖 [BaseLib](https://github.com/Alchyr/BaseLib) `3.3.3` 及以上。当前清单写的是游戏版本 `0.107.0`。项目由 [ModTemplate-StS2](https://github.com/Alchyr/ModTemplate-StS2) 的角色模板生成，仍处于早期版本 `v0.1.0`。

## 当前玩法

- 角色名：The Joker。生命 75，能量上限 2，初始充能球槽 3。
- 起始牌组：铁甲战士、静默猎手、故障机器人、亡灵契约者、摄政王各自的打击、防御，以及各自的非基础起始牌。
- 起始遗物：五个角色的初始遗物，外加基础游戏的 `PrismaticGem`。
- 卡牌池、遗物池、药水池：五个角色的池子合并。
- 立绘和图标仍使用模板占位资源。

`JokerDiscount`（本地化名称 Marked Deck）没有参与编译。它原本用来抵消 `PrismaticGem` 对异色牌的费用惩罚，第一次进商店测试时会卡住，所以先从 `JokerMod.csproj` 里排除。设计记录见 `MOD_PLAN.md`。

多人模式没有测过。BaseLib 对自定义卡牌存档的说明里提到过多人不同步，这个角色先按单人使用。

## 环境

- 已安装杀戮尖塔 2
- .NET 9 SDK
- BaseLib 3.3.3 或更高版本，装在游戏的 `mods` 目录
- 发布 `.pck` 时需要 MegaDot / Godot 4.5.1 mono。比这个新的 Godot 打出来的包，游戏不会加载

## 构建

1. 复制本机配置：

   ```powershell
   Copy-Item Directory.Build.props.example Directory.Build.props
   ```

2. 编辑 `Directory.Build.props`，把 `GodotPath` 改成你的 MegaDot 4.5.1 mono 可执行文件。只编译 DLL、不导出资源包时，这个路径可以先留着，发布步骤才会用到。
3. 如果自动查找不到游戏目录，在同一个文件里取消 `Sts2Path` 的注释并填上安装目录。Windows 上会先查注册表和 Steam 库。
4. 在仓库根目录执行：

   ```powershell
   dotnet build
   ```

构建成功后，`JokerMod.dll`、`JokerMod.pdb` 和 `JokerMod.json` 会复制到游戏目录的 `mods/JokerMod/`。发布资源包：

```powershell
dotnet publish
```

这一步会调用 Godot，把 `JokerMod.pck` 导出到同一个模组目录。

## 仓库里不包含的内容

- `Directory.Build.props`：本机 Godot 和游戏路径。用 `Directory.Build.props.example` 自己生成。
- `.godot/`、`bin/`：本地编译缓存。
- `.template/`：生成项目时留下的模板缓存。
- `exports/`、`tools/`：本机 Steam 库导出和截图脚本，与模组无关。

## 许可证

源码使用 MIT 许可证，见 `LICENSE`。杀戮尖塔 2、BaseLib 和游戏内资源属于各自的作者。
