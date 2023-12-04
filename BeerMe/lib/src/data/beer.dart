

class Beer {
  final String name;
  final double alcoholByVolume;
  final String breweryName;
  final String description;
  final String image;
  final int rate;
  final int bdu;

  Beer(
    this.name,
    this.alcoholByVolume, {
    this.image = 'lib/assets/images/default_fallbacks/unknown_beer.png',
    this.breweryName = "Unknown",
    this.description = "No description",
    this.rate = 0,
    this.bdu = 0,
  });

  Beer fromJson(Map<String, dynamic> json) {
    return Beer(
      json['name'],
      json['alcoholByVolume'],
      image: json['image'],
      breweryName: json['breweryName'],
      description: json['description'],
      rate: json['rate'],
      bdu: json['bdu'],
    );
  }
}
