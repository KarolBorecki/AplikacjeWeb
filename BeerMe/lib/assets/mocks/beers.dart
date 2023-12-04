import 'dart:math';

import '../../src/data/beer.dart';
import 'breweries.dart';

const beersNames = [
  "Harnaś",
  "Żywiec",
  "Tyskie",
  "Lech",
  "Warka",
  "Perła",
  "Okocim",
  "Łomża",
  "Książęce",
  "Kasztelan",
  "Żubr",
  "Ciechan",
  "Kormoran",
  "Kozel",
  "Komes",
];

const beersDescriptions = [
  "Król gór, złociste i bardzo jasne, dobre piwo w smaku normalnie nie śmierdzi a trzepie",
  "Złociste, klarowne, piana biała, obfita, drobna, średnio trwała. W aromacie słodowe, lekko chmielowe. W smaku słodowe, lekko chmielowe, lekko kwaskowe. Goryczka niska, wysycenie średnie.",
];

const beersImagesLinks = [
  //"lib/assets/images/default_fallbacks/unknown_beer.png",
  'https://egroszek.pl/image,offer,4838,5840,546,546,0.jpg',
  'https://www.delikatesyemis.pl/content/images/thumbs/0019273_5900014002128-okocim-ok-beer-piwo-jasne-500-ml_550.jpeg',
  'https://www.estop24.pl/thumbs/w1000h1200q88/img/products/big/5900490000427_lp.JPG?v=907ca9a582bbb9c77dc734272e080405',
  'https://www.estop24.pl/thumbs/w1000h1200q88/img/products/big/2eddfdrdddtd56c.png?v=e511266b33d04cc0541f47103f6caf86',
  'https://www.estop24.pl/thumbs/w1000h1200q88/img/products/big/harnasbut.jpg?v=1f56f4b817716419ff62f4ab91773ce4'
      'https://www.limi.pl/2597-large_default/kozel-lezak-butelka-zwrotna-500ml-wraz-z-kaucja-05zl.jpg',
  'https://www.piwnemosty.pl/hpeciai/60ed9589754c7f135887987f3ab21c9a/pol_pl_Arcyksiazecy-Browar-Zamkowy-Cieszyn-Pilsner-butelka-500-ml-5753_1.webp',
  'https://polskikoszyk.pl/media/catalog/product/290720/Somersby_Somersby_MangoLime_Beer_Drink_400_ml_butelka_46262952_0_350_350.jpg',
];

List<Beer> generateBeersMocks(int count) {
  return List.generate(
      count,
          (index) => Beer(beersNames[Random().nextInt(beersNames.length - 1)],
          Random().nextDouble() * 15,
          breweryName: breweryNames[Random().nextInt(breweryNames.length - 1)],
          image: beersImagesLinks[Random().nextInt(beersImagesLinks.length)],
          description:
          beersDescriptions[Random().nextInt(beersDescriptions.length - 1)],
          rate: Random().nextInt(10),
          bdu: Random().nextInt(100)));
}
