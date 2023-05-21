void main() {
  final numbers = <int>[
    1,
    25,
    78,
    64,
    56,
    45,
    23,
    41,
    543,
    24,
    654,
  ];
  double result =
      numbers.reduce((value, element) => value + element) / numbers.length;
  print("A média é ${result}");
}
