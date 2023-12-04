import 'package:beer_me/src/presentation/profile/views/authorized_profile_view.dart';
import 'package:beer_me/src/presentation/profile/views/unauthorized_profile_view.dart';
import 'package:flutter/material.dart';

import '../../application/authorization/auth.dart';

class ProfilePage extends StatefulWidget {
  const ProfilePage({super.key});

  @override
  State<ProfilePage> createState() => ProfilePageState();
}

class ProfilePageState extends State<ProfilePage> {
  @override
  Widget build(BuildContext context) {
    return Auth.instance.isAuthorized()
        ? const AuthorizedProfileView()
        : const UnauthorizedProfileView();
  }
}
