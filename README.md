<p align="center">
    <img src="https://github.com/thegrateminecra/bloxstrap/raw/main/Images/Bloxstrap-full-dark.png#gh-dark-mode-only" width="380">
    <img src="https://github.com/thegrateminecra/bloxstrap/raw/main/Images/Bloxstrap-full-light.png#gh-light-mode-only" width="380">
</p>

<div align="center">

[![License][shield-repo-license]][repo-license]
[![Downloads][shield-repo-releases]][repo-releases]
[![Version][shield-repo-latest]][repo-latest]

</div>

----

Bloxstrap is a third-party replacement for the standard Roblox bootstrapper, providing additional useful features and improvements.

Running into a problem or need help with something? [Submit an issue](https://github.com/thegrateminecra/bloxstrap/issues).

Bloxstrap is only supported for PCs running Windows.

## Features

- Hassle-free Discord Rich Presence to let your friends know what you're playing at a glance
- Simple support for modding of content files for customizability (death sound, mouse cursor, etc)
- See where your server is geographically located (courtesy of [ipinfo.io](https://ipinfo.io))
- Ability to configure graphics fidelity and UI experience

## Installing

Download the [latest release](https://github.com/thegrateminecra/bloxstrap/releases/latest) and run it.

## Building from source

Requirements:
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)

```bash
git clone https://github.com/thegrateminecra/bloxstrap.git
cd bloxstrap
git submodule update --init --recursive
dotnet build -c Release
```

The self-contained EXE will be output to `build\release\Bloxstrap.exe`.

## Code

Bloxstrap uses the [WPF UI](https://github.com/lepoco/wpfui) library for the user interface design, maintained as a fork at [bloxstraplabs/wpfui](https://github.com/bloxstraplabs/wpfui).

Based on [bloxstraplabs/bloxstrap](https://github.com/bloxstraplabs/bloxstrap).

[shield-repo-license]:  https://img.shields.io/github/license/thegrateminecra/bloxstrap
[shield-repo-releases]: https://img.shields.io/github/downloads/thegrateminecra/bloxstrap/latest/total?color=981bfe
[shield-repo-latest]:   https://img.shields.io/github/v/release/thegrateminecra/bloxstrap?color=7a39fb

[repo-license]:  https://github.com/thegrateminecra/bloxstrap/blob/main/LICENSE
[repo-releases]: https://github.com/thegrateminecra/bloxstrap/releases
[repo-latest]:   https://github.com/thegrateminecra/bloxstrap/releases/latest
