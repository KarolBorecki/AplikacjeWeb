import 'package:beer_me/src/presentation/authorization/auth_screen.dart';
import 'package:flutter/material.dart';

class UnauthorizedProfileView extends StatelessWidget {
  const UnauthorizedProfileView({super.key});

  @override
  Widget build(BuildContext context) {
    return Center(
        child: Column(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        const SizedBox(height: 190),
        Text("You are not logged in!", // TODO change to localization text
            style: Theme.of(context).textTheme.headline4),
        const SizedBox(height: 100),
        ElevatedButton(
          onPressed: () {
            Navigator.push(
              context,
              MaterialPageRoute(builder: (context) => const AuthScreen()),
            );
          },
          child: const Text(
              'Go to the login page'), // TODO change to localization text
        )
      ],
    ));
  }
}
