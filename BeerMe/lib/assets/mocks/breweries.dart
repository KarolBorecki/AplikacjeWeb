import 'dart:math';

import '../../src/data/brewery.dart';

const breweriesImagesLinks = [
  //"lib/assets/images/default_fallbacks/unknown_brewery.png",
  'https://www.flesch.pl/fleschpolska/www/js/kcfinder/upload/images/Browar-Tenczynek.JPEG',
  'https://takiepiwo.pl/admin/upload/images/browar/1609194654-logo-grodziskie.png',
  'https://www.jestesmyspoko.pl/wp-content/uploads/2019/06/Browar-spoldzielczy.jpg',
  'https://img.freepik.com/premium-wektory/vintage-browar-logo-firmy-piwa_807399-102.jpg',
  'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRrNIp5FbNtdAtWYInEwH5-V9dA-tRD0erMsA&usqp=CAU',
  'https://hurtpiwa.pl/wp-content/uploads/2020/08/polanin_logo.jpg',
  'https://minibrowary.files.wordpress.com/2013/09/logo.jpg',
  'https://darspremium.pl/media/PageElement/144/56b857cdb71c9.png',
  'https://zipbier.com/wp-content/uploads/2022/07/browar-warszawski-logo.jpg',
  'https://www.flesch.pl/fleschpolska/www/js/kcfinder/upload/images/Browar-Tenczynek.JPEG'
];

const breweryNames = [
  "Browar Okocim",
  "Browar Żywiec",
  "Browar Tyskie",
  "Browar Lech",
  "Browar Warka",
  "Browar Perła",
  "Browar Łomża",
  "Browar Książęce",
  "Browar Kasztelan",
  "Browar Żubr",
  "Browar Ciechan",
  "Browar Kormoran",
  "Browar Kozel",
  "Browar Komes",
];

const breweriesDescriptions = [
  "Król gór, złociste i bardzo jasne, dobre piwo w smaku normalnie nie śmierdzi a trzepie",
  "Złociste, klarowne, piana biała, obfita, drobna, średnio trwała. W aromacie słodowe, lekko chmielowe. W smaku słodowe, lekko chmielowe, lekko kwaskowe. Goryczka niska, wysycenie średnie.",
];

List<Brewery> generateBreweryMocks(int count) {
  return List.generate(
      count,
          (index) => Brewery(
          name: breweryNames[Random().nextInt(breweryNames.length - 1)],
          description:
          breweriesDescriptions[Random().nextInt(breweriesDescriptions.length - 1)],
          websiteUrl: "https://www.google.com",
          established: "1999",
          imageUrl: breweriesImagesLinks[Random().nextInt(breweriesImagesLinks.length)]));
}