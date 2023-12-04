import 'package:beer_me/src/presentation/main/main_screen.dart';
import 'package:flutter/material.dart';

import '../../../assets/constants/colors.dart';

class MainNavigationWidget extends StatefulWidget {
  final List<NavigationPageDefinition> pages;
  final Function(int) onNavigationItemSelected;

  const MainNavigationWidget({
    super.key,
    required this.pages,
    required this.onNavigationItemSelected,
  });

  @override
  State<MainNavigationWidget> createState() => MainNavigationWidgetState();
}

class MainNavigationWidgetState extends State<MainNavigationWidget> {
  int selectedIndex = 0;

  void onItemPressed(int index) {
    widget.onNavigationItemSelected(index);
    setState(() {
      selectedIndex = index;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Container(
        decoration: const BoxDecoration(
          color: AppColor.secondary,
          borderRadius: BorderRadius.all(Radius.circular(30)),
          boxShadow: [
            BoxShadow(
                color: AppColor.primaryBlack, spreadRadius: 0, blurRadius: 10),
          ],
        ),
        child: ClipRRect(
          borderRadius: const BorderRadius.all(Radius.circular(30)),
          child: BottomNavigationBar(
            selectedItemColor: AppColor.accent,
            unselectedItemColor: AppColor.primary,
            backgroundColor: AppColor.secondary,
            type: BottomNavigationBarType.fixed,
            items: widget.pages.map((page) {
              return BottomNavigationBarItem(
                  icon: Icon(page.icon), label: page.title);
            }).toList(),
            onTap: onItemPressed,
            currentIndex: selectedIndex,
          ),
        ));
  }
}
