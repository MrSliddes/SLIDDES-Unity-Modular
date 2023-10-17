# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/)

## [2.4.0] - 2023-10-17
### Added
- CombinedVariable.cs for float & int

## [2.3.0] - 2023-06-26
### Added
- GameObject SO value for event / variable
### Changed
- Renamed Editor Event naming to correct format
- Creating SO variables now has its own group in SO menuName

## [2.2.0] - 2023-05-07
### Added
- Associated invoker can now be set in event listener via public method
- Variable Handler for getting the values of Variables

## [2.1.1] - 2022-11-01
### Fixed
- Build error fix

## [2.1.0] - 2022-10-25
### Added
- Variable.cs now has invoker gameObject property. When set it changes the attached event invoker.

## [2.0.0] - 2022-10-20
### Changed
- Renamed Event/Event<T> to EventSDS/EventSDS<T>
- Event conditions, now more modular code structure

## [1.3.0] - 2022-07-07
### Added
- More Reference values
- Sample Example 0
### Fixed
- Small scripts adjustments
- .meta warnings
### Changed
- Folder layout
### Removed
- Test folder

## [1.2.2] - 2020-04-15
### Added
- Test values for all events (forgot to add it for some classes)

## [1.2.1] - 2022-04-15
### Fixed
- Custom Editor for Event

## [1.2.0] - 2022-04-15
### Added
- Base classes for Events, Variables, Listeners
### Changed
- Renamed `EmptyEvent` to Event

## [1.1.1] - 2022-03-11
### Fixed
- Asmdef wrong configuration with editor

## [1.1.0] - 2022-03-11
### Added
- More support for more variables

## [1.0.0] - 2022-03-11
### Added
- First public release