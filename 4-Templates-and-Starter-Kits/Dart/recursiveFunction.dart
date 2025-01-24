void main() {
  var numero = 5;
  print("Calcular ${numero}! = ${calculaFatorial(numero)}");
}

int calculaFatorial(int n) => (n == 1) ? 1 : n * calculaFatorial(n - 1);
