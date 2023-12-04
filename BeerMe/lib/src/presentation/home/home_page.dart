import 'dart:math';

import 'package:beer_me/src/data/brewery.dart';
import 'package:beer_me/src/presentation/home/views/home_main_view.dart';
import 'package:flutter/material.dart';

import '../../../assets/mocks/beers.dart';
import '../../../assets/mocks/breweries.dart';
import '../../data/beer.dart';

class HomePage extends StatefulWidget {
  const HomePage({super.key});

  @override
  State<HomePage> createState() => HomePageState();
}

class HomePageState extends State<HomePage> {
  List<Beer> topBeersWeek = generateBeersMocks(20);
  List<Brewery> checkBreweries = generateBreweryMocks(10);

  @override
  Widget build(BuildContext context) {
    return HomeMainView(
        topBeersWeek: topBeersWeek, checkBreweries: checkBreweries);
  }
}
