void main() {
  callbackFunction(onChange: (msg) {
    print(msg);
  });
}

void callbackFunction({required Function(String msg) onChange}) {
  onChange("Eu estou aqui.");
}
