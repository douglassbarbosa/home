import 'package:app_combustivel/widget/success.widget.dart';
import 'package:flutter/material.dart';
import 'package:flutter_masked_text2/flutter_masked_text2.dart';

import '../widget/logo.widget.dart';
import '../widget/submit-form.dart';

class HomePage extends StatefulWidget {
  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  var _gasCtrl = MoneyMaskedTextController();
  var _etanolCtrl = MoneyMaskedTextController();
  Color _color = Colors.deepPurple;
  var _busy = false;
  var _completed = false;
  String _resultText = '';

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Theme.of(context).primaryColor,
      body: AnimatedContainer(
        duration: const Duration(
          milliseconds: 1000,
        ),
        color: _color,
        child: ListView(
          children: <Widget>[
            const Logo(),
            _completed
                ? Success(
                    result: _resultText,
                    reset: _reset,
                  )
                : SubmitForm(
                    gasCtrl: _gasCtrl,
                    etanolCtrl: _etanolCtrl,
                    busy: _busy,
                    submitFunc: calculate),
          ],
        ),
      ),
    );
  }

  Future calculate() async {
    double priceEtanol =
        double.parse(_etanolCtrl.text.replaceAll(RegExp(r'[,.]'), ''));
    double priceGas =
        double.parse(_gasCtrl.text.replaceAll(RegExp(r'[,.]'), ''));
    double res = priceEtanol / priceGas;

    return Future.delayed(const Duration(seconds: 1), () {
      setState(() {
        if (res >= 0.7) {
          _resultText = "Use Gasolina";
        } else {
          _resultText = "Use Etanol";
        }
        _color = Colors.deepPurpleAccent;
        _completed = true;
        _busy = false;
      });
    });
  }

  Future<void> _reset() {
    setState(() {
      _gasCtrl = MoneyMaskedTextController();
      _etanolCtrl = MoneyMaskedTextController();
      _busy = false;
      _completed = false;
      _color = Theme.of(context).primaryColor;
    });
    return Future<void>.value();
  }
}
