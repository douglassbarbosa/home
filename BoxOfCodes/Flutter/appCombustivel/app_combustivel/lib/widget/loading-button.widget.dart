import 'package:flutter/material.dart';

class LoadingButton extends StatelessWidget {
  final bool busy;
  final bool invert;
  final VoidCallback func;
  final String text;

  LoadingButton({
    super.key,
    required this.busy,
    required this.func,
    required this.invert,
    required this.text,
  });

  @override
  Widget build(BuildContext context) {
    return busy
        ? Container(
            alignment: Alignment.center,
            height: 50,
            child: const CircularProgressIndicator(
              backgroundColor: Colors.white,
            ),
          )
        : Container(
            margin: const EdgeInsets.all(30),
            height: 60,
            width: double.infinity,
            decoration: BoxDecoration(
              color: invert
                  ? Theme.of(context).primaryColor
                  : Colors.white.withOpacity(0.8),
              borderRadius: BorderRadius.circular(25),
            ),
            child: TextButton(
              style: ElevatedButton.styleFrom(
                backgroundColor: const Color.fromARGB(28, 255, 255, 255),
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(60),
                ),
              ),
              onPressed: func,
              child: Text(
                text,
                style: TextStyle(
                  color: invert ? Colors.white : Theme.of(context).primaryColor,
                  fontSize: 20,
                  fontFamily: "Big Shoulders Display",
                ),
              ),
            ),
          );
  }
}
