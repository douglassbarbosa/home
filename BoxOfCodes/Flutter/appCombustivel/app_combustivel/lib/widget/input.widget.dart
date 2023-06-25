import 'package:flutter/material.dart';
import 'package:flutter_masked_text2/flutter_masked_text2.dart';

class Input extends StatelessWidget {
  String label = ""; //
  MoneyMaskedTextController ctrl = MoneyMaskedTextController();

  Input({
    required this.label,
    required this.ctrl,
  });

  @override
  Widget build(BuildContext context) {
    return Row(
      children: <Widget>[
        Container(
          width: 100,
          alignment: Alignment.centerRight,
          child: Text(
            label,
            style: const TextStyle(
              color: Colors.white,
              fontSize: 20,
              fontFamily: "Big Shoulders Display",
            ),
          ),
        ),
        const SizedBox(
          width: 20,
        ),
        Expanded(
          child: TextFormField(
              controller: ctrl,
              keyboardType: TextInputType.number,
              style: const TextStyle(
                color: Colors.white,
                fontSize: 40,
                fontFamily: "Big Shoulders Display",
              ),
              decoration: const InputDecoration(
                border: InputBorder.none,
              )),
        ),
      ],
    );
  }
}
