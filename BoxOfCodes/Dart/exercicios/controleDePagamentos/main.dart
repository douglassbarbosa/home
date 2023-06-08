import 'menu.dart';

void main() {
  // chamar Menu
  Menu menu = Menu();
  menu.arguments = [
    "Menu - escolha uma opção",
    "1- Débito",
    "2- Crédito",
    "3- Dinheiro",
    "4- PIX",
    "5- SAIR"
  ];
  menu.printMenu(menu.arguments);
}
