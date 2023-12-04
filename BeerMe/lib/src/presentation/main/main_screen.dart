import 'package:beer_me/src/assets/constants/sizing.dart';
import 'package:beer_me/src/assets/constants/themes.dart';
import 'package:beer_me/src/presentation/main/widgets/main_navigation_widget.dart';
import 'package:flutter/material.dart';

import '../favourites/favourites_page.dart';
import '../home/home_page.dart';
import '../profile/profile_page.dart';
import '../scan/scan_page.dart';
import '../search/search_page.dart';

class NavigationPageDefinition {
  final String title;
  final IconData icon;
  final Widget page;

  const NavigationPageDefinition({
    required this.title,
    required this.icon,
    required this.page,
  });
}

class MainScreen extends StatefulWidget {
  const MainScreen({super.key});

  @override
  State<MainScreen> createState() => MainScreenState();
}

class MainScreenState extends State<MainScreen> {
  int selectedPage = 0;

  static const List<NavigationPageDefinition> pages =
      <NavigationPageDefinition>[
    NavigationPageDefinition(
      title: 'Home',
      icon: Icons.home,
      page: HomePage(),
    ),
    NavigationPageDefinition(
      title: 'Favourites',
      icon: Icons.favorite,
      page: FavouritesPage(),
    ),
    NavigationPageDefinition(
      title: 'Scan',
      icon: Icons.photo_camera_rounded,
      page: ScanPage(),
    ),
    NavigationPageDefinition(
      title: 'Search',
      icon: Icons.search,
      page: SearchPage(),
    ),
    NavigationPageDefinition(
      title: 'Profile',
      icon: Icons.person,
      page: ProfilePage(),
    ),
  ];

  void onBottomNavigationPressed(int pageIndex) {
    setState(() {
      selectedPage = pageIndex;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: DefaultTextStyle(
        style: AppTextThemes.defaultTextStyle,
        child: SingleChildScrollView(
          padding: const EdgeInsets.only(
              top: AppSizing.extraLargePadding,
              left: AppSizing.mediumPadding,
              right: AppSizing.mediumPadding),
          child: pages[selectedPage].page,
        ),
      ),
      bottomNavigationBar: MainNavigationWidget(
          pages: pages, onNavigationItemSelected: onBottomNavigationPressed),
    );
  }
}
