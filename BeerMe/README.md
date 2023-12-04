# beer_me

A mobile app allowing You to scan Your beer and get information about it!

## Getting Started

### Setting up environment
#### Dart/Flutter SDK
We use Intellij us our default IDE so everything comes pre-installed.
What is more if You didn't check flutter/dart support during installation, the IDE will propes to install it for You.
Nevertheless if You still don't have it, You can find plugins in Intellij's plugin settings.

#### Setting up the project
- Install **dependencies**:
    ```bash
    flutter pub get
    ```
- Generate code for **serialization**:
    ```bash
    flutter pub run build_runner build --delete-conflicting-outputs
    ```
  
- Generate code for **internalization**:
    ```bash
    flutter gen-l10n
    ```
  
### Running the app
  ```bash
  flutter run
  ```

## Development

### Internalization classes
To provide translations we use *.arb files. To generate dart classes from them use this command:
```bash
flutter gen-l10n
```
Flutter docs says that `flutter pub get` is enough bet they are lying ;)

See more: [https://docs.flutter.dev/ui/accessibility-and-internationalization/internationalization)

### Code generation for serializeable objects

We use serialization so when we provide changes to serialized classes we need to re-generate the code.
Use this commands to do so:
    
- For one time generation:
    ```bash
    flutter pub run build_runner build --delete-conflicting-outputs
    ```
- For continuous generation:
    ```bash
    flutter pub run build_runner watch --delete-conflicting-outputs
    ```

See more: [Flutter and JSON serialization](https://docs.flutter.dev/data-and-backend/serialization/json)

### Project structure

Project has been structured in Layer-First convention.
This means we keep all source code inside `lib/src` folder divided into layers:
- **presentation** - contains all UI related code
- **application** - contains all application logic
- **domain** - contains all business logic
- **data** - contains all data sources and repositories

Additionally we have:
- **utils** - contains all utilities and helpers
- **assets** - contains all assets-related files (like app settings, constants, etc.)
- **shared** - contains all shared code (like models, enums, widghets, components etc.)

### Naming convention
Remember to use flutter naming convention:
- **classes** - UpperCamelCase
- **variables** - lowerCamelCase
- **enums** - UpperCamelCase
- **functions** - lowerCamelCase
- **parameters** - lowerCamelCase
- **constants** - UPPER_SNAKE_CASE
- **files** - snake_case
- **packages** - snake_case

Also we are using custom naming convention for presentation-oriented code:
- ***_screen** - components taking space of the whole screen
- ***_page** - components taking space of the part of the screen (tabs of main navigation)
- ***_view** - components being subpage of page component

### Common flutter/dart fixes

Here are some common commands fixing problems with flutter/dart:

- Cleaning project:
  ```bash
    flutter clean
    ```
  Remember to run `flutter pub get` after cleaning.

- Fixing imports:
    ```bash
    flutter pub get
    ```
- Fixing formatting:
    ```bash
    flutter format .
    ```
- Fixing analysis issues:
    ```bash
    flutter analyze .
    ```
  
### Stupid issues found:
#### Problem with generating serialization code for AppSettings.dart:
The generator keep either resulting in error: `[SEVERE] Nothing can be built, yet a build was requested.` or it could not find `pubspeck.yml` in `flutter_gen` folder.

Solution:
Create `pubspeck.yml` in `flutter_gen` folder:
```bash
mkdir .dart_tool/flutter_gen && touch .dart_tool/flutter_gen/pubspec.yaml
```

And copy the content of `pubspec.yaml` from root folder to the newly created file.

Now the generator should work properly.

#### "Invalid depfile: ...kernel_snapshot.d"

1. Make sure You are not using ANY packages that is not supported on given platform
2. Run 
    ```bash
    flutter clean
    ```
3. Delete `kernel_snapshot.d` and `kernel_snapshot.stamp` files in `.dart_tool/flutter_build` if it was not done by this command.
3. Re-run

You can also try 
```bash
flutter pub get
```

## Credits

### Icons / Images

- [Beer bottle icon] <a href="https://www.flaticon.com/free-icons/beer" title="beer icons">Beer icons created by Freepik - Flaticon</a>
- [Brewery icon] <a href="https://www.flaticon.com/free-icons/brew" title="brew icons">Brew icons created by dDara - Flaticon</a>
- [Circle icon] <a href="https://www.flaticon.com/free-icons/circle" title="circle icons">Circle icons created by Freepik - Flaticon</a>