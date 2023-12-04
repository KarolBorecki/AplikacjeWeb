import 'package:beer_me/src/assets/constants/themes.dart';
import 'package:flutter/material.dart';

import '../../../assets/constants/colors.dart';
import '../../../data/beer.dart';

class BeerBigWidget extends StatelessWidget {
  final Beer beer;
  const BeerBigWidget({super.key, required this.beer});

  @override
  Widget build(BuildContext context) {
    return ClipRRect(
      borderRadius: const BorderRadius.all(Radius.circular(10)),
      child: Container(
        color: AppColor.secondaryBackground,
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Image.network(beer.image),
            Container(
              padding: const EdgeInsets.all(5),
              child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween, children: [
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Row(
                      mainAxisAlignment: MainAxisAlignment.start,
                      children: [
                        Text(beer.name, style: AppTextThemes.subheading, overflow: TextOverflow.ellipsis,),
                        Text(" "),
                        Text(beer.alcoholByVolume.toStringAsFixed(1),
                            style: AppTextThemes.smallemphasis),
                        Text("%", style: AppTextThemes.smallemphasis),
                      ],
                    ),
                    Row(
                      children: [
                        Text(beer.breweryName, style: AppTextThemes.smallweak),
                      ],
                    )
                  ],
                ),
                Container(
                  width: 20,
                  height: 35,
                  alignment: Alignment.center,
                  decoration: BoxDecoration(
                    //color: AppColor.secondary,
                    // borderRadius: const BorderRadius.all(Radius.circular(60)),
                    // border: Border.all(
                    //   color: AppColor.secondary,
                    //   width: 0,
                    // ),
                  ),
                  child: Text(beer.rate.toString(),
                      style: AppTextThemes.headingaccent)
                )
              ])
            )
          ],
        ),
      ),
    );
  }
}
