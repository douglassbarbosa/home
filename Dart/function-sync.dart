void main() {
  print(someFunction(2, 4));
  var horaAtual = DateTime.now();
  print("HORA: ${horaAtual.hour}:${horaAtual.minute}");
}

int someFunction(int a, int b) => a + b;
