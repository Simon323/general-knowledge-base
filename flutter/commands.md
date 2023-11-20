## Table of Contents
- [Table of Contents](#table-of-contents)
- [Clean](#clean)
- [Restore packages](#restore-packages)
- [Install package](#install-package)
- [Uninstall package](#uninstall-package)
- [Update packages](#update-packages)
- [Fix code](#fix-code)
- [Generate *.g*dart](#generate-gdart)

## Clean
```bash
flutter clean
```

## Restore packages
```bash
flutter pub get
```

## Install package
```bash
flutter pub add your_package
```

## Uninstall package
```bash
dart pub remove your_package
```

## Update packages 
```bash
flutter pub upgrade --major-versions
```

## Fix code
```bash
dart fix --dry-run
dart fix --apply
```

## Generate *.g*dart

1. Install as dev dependencies:
  - build_runner
  - json_serializable
2. In dart class file
```dart
part 'user.g.dart';

@JsonSerializable(
  createToJson: false,
)

class User {
  String Name;
}
```
3. In terminal run command
```bash
flutter pub run build_runner build
```