# Design Patterns (C#)

Design pattern tasks implemented in C# (.NET 8). One solution (`DesignPatterns.sln`), one console project per task.

| Pattern | Projects |
|---|---|
| adapter | [NotificationAdapter](adapter/NotificationAdapter) — SMS / Telegram / Email notifications through one interface |
| Bridge Design Pattern | [BridgeGames](<Bridge Design Pattern/BridgeGames>) — any game × any developer |
| builder | [ComputerBuilder](builder/ComputerBuilder) — fluent computer builder<br>[PaginationBuilder](builder/PaginationBuilder) — paginated response (`PageMeta.FromTotal`, `PaginatedResponse<T>.Build`) |
| factoriy | [CafeFactory](factoriy/CafeFactory) — Cafe without if/else, drinks created by `DrinkFactory` |
| prototype | [GameCharacterPrototype](prototype/GameCharacterPrototype) — game character clones<br>[DocumentPrototype](prototype/DocumentPrototype) — document clones with deep copy |
| singleton | [DbConnectionSingleton](singleton/DbConnectionSingleton) — one shared DB connection |

## Run

Open `DesignPatterns.sln` in Visual Studio / Rider and set any project as startup, or:

```
dotnet run --project builder/ComputerBuilder
dotnet run --project "Bridge Design Pattern/BridgeGames"
```
