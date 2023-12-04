import 'package:beer_me/src/application/authorization/auth.dart';
import 'package:beer_me/src/utils/logger.dart';
import 'package:flutter/material.dart';
import 'package:flutter_gen/gen_l10n/app_localizations.dart';

import '../../assets/constants/colors.dart';
import '../../assets/settings/app_settings.dart';

class AuthScreen extends StatefulWidget {
  const AuthScreen({super.key});

  @override
  State<AuthScreen> createState() => AuthScreenState();
}

class AuthScreenState extends State<AuthScreen> {
  // TODO rename to AuthView
  void onGoBackPressed() {
    Navigator.pop(context);
  }

  void onLoginPressed() async {
    await Auth.instance.authenticate().then((value) {
      if (Auth.instance.isAuthorized()) {
        logInfo("Authorized user: ${Auth.instance.userInfo!.name!}");
        Navigator.pop(context);
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        leading: IconButton(
          onPressed: onGoBackPressed,
          icon: const Icon(Icons.arrow_back),
          color: AppColor.hookersgreen,
        ),
        title: null,
        backgroundColor: Colors.transparent,
        elevation: 0,
      ),
      body: Center(
          //padding: const EdgeInsets.all(80.0),
          child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          Text(
            AppSettings.instance.appName,
            style: Theme.of(context).textTheme.displayMedium,
          ),
          const SizedBox(
            height: 24,
          ),
          ElevatedButton(
            onPressed: onLoginPressed,
            child: Text(AppLocalizations.of(context)!.login),
          ),
        ],
      )),
    );
  }
}
