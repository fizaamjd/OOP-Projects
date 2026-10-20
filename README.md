# OOP Projects

Original object-oriented coursework organized into two C# applications and a small Python exercise archive.

| Project | Implementation | Start here |
| --- | --- | --- |
| Store management | Windows Forms, C#, .NET Framework 4.7.2 | [Application guide](docs/STORE.md) |
| PacMan | C# console maze game, .NET Framework 4.7.2, EZInput | [Game guide](docs/PACMAN.md) |
| Python exercises | Original classroom exercises | [Source](python-exercises) |

## Run

Use Windows and Visual Studio 2022 with the .NET desktop development workload and .NET Framework 4.7.2 targeting pack. Open `store-management/thiscmsapp2.sln` or `pacman/PacMan.sln`. Restore NuGet packages for PacMan before building. The GUI-only `PacManGUI.sln` from the source folder has no matching project files, so it is documented in provenance rather than presented as a runnable game.

The store app includes **synthetic demo accounts only**, `DemoAdmin` and `DemoCustomer`, both with password `CourseworkOnly123`. Its historical plaintext authentication is for local coursework, not production use. No original account records were published. The stock file starts empty.

## Repository checks

Windows CI restores and compiles both C# solutions. Python files receive syntax checks only. The original exercise code is preserved, including incomplete OOP design in `userBL.py`; syntax checking is not a functional test.

## Scope and provenance

Both PacMan folders were compared. Their Program.cs files differ only in whitespace, so only the OOP copy is kept. The missing PacManGUI project is not invented. PF coursework belongs in [Cpp-Fundamentals](https://github.com/fizaamjd/Cpp-Fundamentals), and is not duplicated here.

[Contributing](CONTRIBUTING.md) · [Security](SECURITY.md) · [Third-party notices](THIRD_PARTY_NOTICES.md)
