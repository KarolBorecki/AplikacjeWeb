import 'dart:convert';

import 'package:flutter/services.dart';
import 'package:json_annotation/json_annotation.dart';

part 'app_settings.g.dart';

@JsonSerializable()
class AppSettings {
  @JsonKey(name: 'app_name')
  String appName;

  @JsonKey(name: 'default_locale')
  String defaultLocale;

  static AppSettings? _instance = AppSettings('', '');
  static AppSettings get instance => _instance!;

  static void load(String filePath) async {
    final String content = await rootBundle.loadString(filePath);
    final appSettingsMap = jsonDecode(content);
    _instance = AppSettings.fromJson(appSettingsMap);
  }

  AppSettings(this.appName, this.defaultLocale);
  factory AppSettings.fromJson(Map<String, dynamic> json) =>
      _$AppSettingsFromJson(json);
}
