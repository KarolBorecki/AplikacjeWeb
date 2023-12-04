import 'package:flutter/material.dart';

import '../../../application/authorization/auth.dart';
import 'widgets/profile_menu_widget.dart';

class AuthorizedProfileView extends StatelessWidget {
  const AuthorizedProfileView({super.key});

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
        child: Container(
      padding: const EdgeInsets.all(20),
      child: Column(
        children: [
          Stack(
            children: [
              SizedBox(
                width: 120,
                height: 120,
                child: ClipRRect(
                    borderRadius: BorderRadius.circular(100),
                    child: Container()),
              ),
              Positioned(
                bottom: 0,
                right: 0,
                child: Container(
                  width: 35,
                  height: 35,
                  decoration:
                      BoxDecoration(borderRadius: BorderRadius.circular(100)),
                  child: const Icon(
                    Icons.edit,
                    color: Colors.black,
                    size: 20,
                  ),
                ),
              ),
            ],
          ),
          const SizedBox(height: 10),
          Text("${Auth.instance.userInfo?.name}",
              style: Theme.of(context).textTheme.headline4),
          Text("${Auth.instance.userInfo?.email}",
              style: Theme.of(context).textTheme.bodyText2),
          const SizedBox(height: 20),

          /// -- BUTTON
          SizedBox(
            width: 200,
            child: ElevatedButton(
              onPressed: () => {},
              style: ElevatedButton.styleFrom(
                  side: BorderSide.none, shape: const StadiumBorder()),
              child: const Text('tEditProfile'),
            ),
          ),
          const SizedBox(height: 30),
          const Divider(),
          const SizedBox(height: 10),

          ProfileMenuWidget(
              title: "Settings", icon: Icons.settings, onPress: () {}),
          ProfileMenuWidget(
              title: "Billing Details", icon: Icons.wallet, onPress: () {}),
          ProfileMenuWidget(
              title: "User Management",
              icon: Icons.manage_accounts,
              onPress: () {}),
          const Divider(),
          const SizedBox(height: 10),
          ProfileMenuWidget(
              title: "Information", icon: Icons.info, onPress: () {}),
          Center(
            child: ProfileMenuWidget(
                title: "Logout",
                icon: Icons.logout,
                textColor: Colors.red,
                endIcon: false,
                onPress: () {
                  Auth.instance.unauthenticate();
                }),
          )
        ],
      ),
    ));
  }
}
