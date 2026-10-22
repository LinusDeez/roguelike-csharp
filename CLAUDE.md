# Projekt-Briefing: C# Roguelike mit Online-Leaderboard

## Ziel
Portfolio-Projekt für meinen Lebenslauf, das Spieleentwicklung und Backend verbindet. Ich will dabei selbst lernen. Bitte erklär mir Konzepte und gib mir Hinweise, statt mir einfach fertigen Code zu liefern, außer ich frage explizit danach.

## Grundlage
Tutorial "Creating a Roguelike Game in C#" (roguesharp.wordpress.com), RogueSharp v3.0 RLNet Tutorials, 18 Kapitel. Das Tutorial ist veraltet (.NET Framework, RLNet wird nicht mehr gepflegt). Ich nutze es nur als Leitfaden für die Konzepte und setze es modern um.

## Tech-Stack
- .NET 8 oder neuer, SDK-style Projekte
- **RogueSharp** (NuGet) für Map, FOV und Pathfinding, behalten wie im Tutorial
- **SadConsole** (+ SadConsole.Host.MonoGame) statt RLNet für Fenster, Rendering und Input
- xUnit für Tests
- Später: ASP.NET Core Web API, EF Core (SQLite/PostgreSQL), Docker, GitHub Actions

## Solution-Struktur
```
Roguelike.sln
├── Roguelike.Core/        ← Spiellogik, nur RogueSharp, KEINE SadConsole-Referenz
├── Roguelike.Client/      ← SadConsole, Rendering, Input
└── Roguelike.Core.Tests/  ← xUnit
```

## Architektur-Regeln
1. **Keine statische `Game`-Klasse mit globalem Zustand** wie im Tutorial (`Game.Player`, `Game.DungeonMap` usw.). Stattdessen gibt es eine `GameState`-Klasse, und Abhängigkeiten kommen per Konstruktor.
2. Core kennt SadConsole nicht. Der Client liest nur den Zustand und zeichnet ihn.
3. **Zufall immer seedbar:** Der RNG mit Seed wird als Parameter übergeben (für Tests und die spätere Daily Challenge).
4. Modernes C#: Nullable an, file-scoped Namespaces, Properties statt öffentlicher Felder, `record` für einfache Datentypen.
5. Ein Git-Commit pro Tutorial-Kapitel, mit sinnvoller Nachricht.

## Übersetzung RLNet → SadConsole
| Tutorial (RLNet) | SadConsole |
|---|---|
| `RLRootConsole` | `Game.Create(...)` + Start-Screen |
| Sub-Consoles + `Blit` | `Console`-Objekte mit `Position` als Children |
| `OnRootConsoleUpdate` / `Render` | `Update()` überschreiben |
| `console.Set(x, y, fg, bg, ch)` | `SetGlyph(...)` / `Print(...)` |
| `RLKeyPress` | `ProcessKeyboard(...)` / `keyboard.IsKeyPressed(Keys.Up)` |
| `RLColor` | `Color` (SadRogue.Primitives) |

## Roadmap
1. Tutorial-Kapitel 1–18 umsetzen (mit der Architektur oben), **← aktueller Schritt**
2. Ein eigenes Feature einbauen (Items/Inventar oder Speichern/Laden als JSON)
3. Unit-Tests und GitHub Actions (Build und Tests bei jedem Push)
4. ASP.NET Core API und Datenbank für das Online-Leaderboard (Run-Ergebnisse: Score, Tiefe, Todesursache)
5. Daily Challenge (gemeinsamer Seed pro Tag), serverseitige Prüfung der Runs gegen gefälschte Scores, Docker, README mit Gameplay-GIF

## Aktueller Stand
(Hier nach jeder Session kurz notieren, wo ich stehe, z. B. "Kapitel 3 fertig, als Nächstes Kapitel 4".)