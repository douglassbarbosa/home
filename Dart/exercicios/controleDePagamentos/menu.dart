class Menu {
  List<String> arguments = [];

  void printMenu(List<String> _arguments) {
    for (int i = 0; i < _arguments.length; i++) {
      print(_arguments[i]);
    }
  }
}
