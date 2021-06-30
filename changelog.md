# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.0.0-preview](https://github.com/unity-game-framework/ugf-property/releases/tag/2.0.0-preview) - 2021-06-30  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-property/milestone/3?closed=1)  
    

### Changed

- Update to Unity 2021.1 ([#6](https://github.com/unity-game-framework/ugf-property/pull/6))  
    - Update project to _Unity_ of `2021.1` version.
    - Add `PropertyValueAccess` enumeration to determine access at creation of `PropertyValue<T>`.
    - Change name of `PropertyBase<T>` class to `Property<T>`.
    - Change name of `Property<T>` class to `PropertyHandle<T>`.
    - Change constructors for `PropertyHandle<T>`, `PropertyTarget<T>` and `PropertyValue<T>` to prevent creation of properties with non-read and non-written access at the same time.

## [1.0.0-preview.1](https://github.com/unity-game-framework/ugf-property/releases/tag/1.0.0-preview.1) - 2019-08-16  

- [Commits](https://github.com/unity-game-framework/ugf-property/compare/1.0.0-preview...1.0.0-preview.1)
- [Milestone](https://github.com/unity-game-framework/ugf-property/milestone/2?closed=1)

### Added
- Package short description.
- `PropertyTarget`: to create property with reference target to get or set value.

### Changed
- Update to Unity 2019.2.

## [1.0.0-preview](https://github.com/unity-game-framework/ugf-property/releases/tag/1.0.0-preview) - 2019-07-29  

- [Commits](https://github.com/unity-game-framework/ugf-property/compare/79e52a6...1.0.0-preview)
- [Milestone](https://github.com/unity-game-framework/ugf-property/milestone/1?closed=1)

### Added
- This is a initial release.


