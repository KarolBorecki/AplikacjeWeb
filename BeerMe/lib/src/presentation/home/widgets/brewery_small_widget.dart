import 'package:beer_me/src/assets/constants/colors.dart';
import 'package:beer_me/src/assets/constants/sizing.dart';
import 'package:flutter/material.dart';

import '../../../data/brewery.dart';

class BrewerySmallWidget extends StatelessWidget {
  Brewery brewery;

  BrewerySmallWidget(this.brewery, {super.key});

  @override
  Widget build(BuildContext context) {
    return Container(
      width: 100,
      height: 100,
      child: Column(
        children: [
          Container(
            width: 60,
            height: 60,
            child: ClipRRect(
              borderRadius: const BorderRadius.all(Radius.circular(60)),
              child: Image.network(brewery.imageUrl),
            ),
          ),
          SizedBox(height: AppSizing.extraSmallMargin),
          Center(
            child: Text(brewery.name, textAlign: TextAlign.center,),
          )
        ],
      ),
    );
  }
}
