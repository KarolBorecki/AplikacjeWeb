import 'package:flutter/material.dart';

import '../../../assets/constants/sizing.dart';
import '../../../assets/constants/themes.dart';
import '../../../data/beer.dart';
import '../../../data/brewery.dart';
import '../widgets/beer_big_widget.dart';
import '../widgets/brewery_small_widget.dart';

class HomeMainView extends StatelessWidget {
  List<Beer> topBeersWeek;
  List<Brewery> checkBreweries;

  HomeMainView(
      {super.key, required this.topBeersWeek, required this.checkBreweries});

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        const Text("Hello, Karol!", style: AppTextThemes.headline),
        const SizedBox(height: AppSizing.mediumMargin),
        const Text("Check out this breweries:", style: AppTextThemes.heading),
        const SizedBox(height: AppSizing.smallMargin),
        SizedBox(
          height: AppSizing.mediumSize,
          child: ListView.separated(
            padding: EdgeInsets.zero,
            scrollDirection: Axis.horizontal,
            itemBuilder: (BuildContext context, int index) {
              return BrewerySmallWidget(checkBreweries[index]);
            },
            itemCount: checkBreweries.length,
            separatorBuilder: (BuildContext context, int index) =>
                const SizedBox(
              width: 10,
            ),
          ),
        ),
        const SizedBox(height: AppSizing.mediumMargin),
        const Text("Top beers this week:", style: AppTextThemes.heading),
        const SizedBox(height: AppSizing.smallMargin),
        Column(
          children: <Widget>[
            GridView.count(
              physics: const NeverScrollableScrollPhysics(),
              shrinkWrap: true,
              padding: EdgeInsets.zero,
              crossAxisSpacing: 10,
              mainAxisSpacing: 10,
              crossAxisCount: 2,
              childAspectRatio: 0.73,
              children:
                  topBeersWeek.map((e) => BeerBigWidget(beer: e)).toList(),
            ),
          ],
        ),
      ],
    );
  }
}
