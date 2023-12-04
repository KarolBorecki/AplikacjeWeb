import 'package:beer_me/src/presentation/main/main_screen.dart';
import 'package:beer_me/src/utils/logger.dart';
import 'package:flutter/material.dart';

import 'package:intl/intl.dart';
import 'package:flutter_gen/gen_l10n/app_localizations.dart';

import 'src/application/authorization/auth.dart';
import 'src/assets/constants/themes.dart';
import 'src/assets/settings/app_settings.dart';


Future<void> main() async {
  Logger().setLogLevel(LogLevel.debugFinest);

  await Auth.instance.init();

  runApp(const BeerMe());
}

class BeerMe extends StatelessWidget {
  const BeerMe({super.key});

  @override
  Widget build(BuildContext context) {
    logDebug('Building the app.');
    AppSettings.load('lib/assets/appsettings.json');
    Intl.defaultLocale = AppSettings.instance.defaultLocale;

    return MaterialApp(
      title: AppSettings.instance.appName,
      theme: AppThemes.light,
      darkTheme: AppThemes.light,
      localizationsDelegates: AppLocalizations.localizationsDelegates,
      supportedLocales: AppLocalizations.supportedLocales,
      home: const MainScreen()
    );
  }
}
