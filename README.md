# Design Patterns (C#)

Design pattern tasks implemented in C# (.NET 8). One solution (`DesignPatterns.sln`), one console project per task.

| Pattern | Projects |
|---|---|
| adapter | [NotificationAdapter](adapter/NotificationAdapter) — SMS / Telegram / Email notifications through one interface |
| Bridge Design Pattern | [BridgeGames](<Bridge Design Pattern/BridgeGames>) — any game × any developer |
| builder | [ComputerBuilder](builder/ComputerBuilder) — fluent computer builder<br>[PaginationBuilder](builder/PaginationBuilder) — paginated response (`PageMeta.FromTotal`, `PaginatedResponse<T>.Build`)<br>[HttpRequestBuilder](builder/HttpRequestBuilder) — HTTP request builder + director, real GET/POST |
| composite | [FileSystemComposite](composite/FileSystemComposite) — folders and files as one tree |
| decorator | [OrderDecorator](decorator/OrderDecorator) — gift wrap / express delivery added to an order |
| facade | [TravelFacade](facade/TravelFacade) — flight + hotel + payment behind one `BookTrip` call |
| factory | [CafeFactory](factory/CafeFactory) — Cafe without if/else, drinks created by `DrinkFactory`<br>[CafeComboFactory](factory/CafeComboFactory) — abstract factory: drink + dessert combo<br>[DeveloperTeamFactory](factory/DeveloperTeamFactory) — factory method (developers) + abstract factory (developer / tester / PM teams) |
| flyweight | [BlockFlyweight](flyweight/BlockFlyweight) — shared block types for a voxel world |
| prototype | [GameCharacterPrototype](prototype/GameCharacterPrototype) — game character clones<br>[DocumentPrototype](prototype/DocumentPrototype) — document clones with deep copy |
| proxy | [BankAccountProxy](proxy/BankAccountProxy) — login check before withdrawing |
| singleton | [DbConnectionSingleton](singleton/DbConnectionSingleton) — one shared DB connection<br>[LoggerSingleton](singleton/LoggerSingleton) — shared Logger + Database used by UserService |

## Run

Open `DesignPatterns.sln` in Visual Studio / Rider and set any project as startup, or:

```
dotnet run --project builder/ComputerBuilder
dotnet run --project "Bridge Design Pattern/BridgeGames"
```
