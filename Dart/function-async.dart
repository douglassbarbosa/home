void main() async {
  print("Simuladondo um Mock");
  await functioAsync();
  print("Fim do Programa");
}

Future<void> functioAsync() async {
  print("I'm here...");
  await Future.delayed(Duration(seconds: 3));
  print("Exiting...");
}
