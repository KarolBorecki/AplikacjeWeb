import 'dart:core';
import 'dart:io';

import 'package:beer_me/src/utils/logger.dart';
import 'package:openid_client/openid_client.dart';
import 'package:openid_client/openid_client_io.dart' as io;
import 'package:url_launcher/url_launcher.dart';

class Auth {
  static const String keycloakUri = 'http://localhost:8080/realms/beerme';
  static const List<String> scopes = ['profile'];
  static const String clientId = 'beerme_mobile';
  static const int authenticatorPort = 4000;

  late Client client;
  Credential? credential;
  late UserInfo? userInfo;

  static final Auth _instance = Auth();
  static Auth get instance => _instance;

  Future<void> init() async {
    try {
      client = await getClient();
      credential = await getRedirectResult();
    } catch (e) {
      logError(e.toString());
    }
  }

  Future<Client> getClient() async {
    var uri = Uri.parse(keycloakUri);

    var issuer = await Issuer.discover(uri);
    return Client(issuer, clientId);
  }

  Future<Credential?> getRedirectResult() async {
    return null;
  }

  Future<void> authenticate() async {
    urlLauncher(String url) async {
      var uri = Uri.parse(url);
      if (await canLaunchUrl(uri) || Platform.isAndroid) {
        await launchUrl(uri);
      } else {
        throw 'Could not launch $url';
      }
    }

    var authenticator = io.Authenticator(client,
        scopes: scopes, port: authenticatorPort, urlLancher: urlLauncher);
    credential = await authenticator.authorize();

    if (Platform.isAndroid || Platform.isIOS) {
      closeInAppWebView();
    }

    userInfo = await credential?.getUserInfo();
  }

  void unauthenticate() {
    credential = null;
    userInfo = null;
  }

  bool isAuthorized() {
    return credential != null;
  }
}
