import 'package:flutter/material.dart';
import 'functions.dart';

void main() => runApp(MyApp());

class MyApp extends StatefulWidget {
  _MyAppState createState() => _MyAppState();
}

class _MyAppState extends State<MyApp> {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      home: Scaffold(
        appBar: AppBar(
          toolbarHeight: 80,
          actions: [
            Column(
                mainAxisAlignment: MainAxisAlignment.center,
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                  Text(' Automatic mode '),
                  Switch(
                    activeColor: Colors.yellow,
                    value: automaticMode,
                    onChanged: (value) {
                      setState(() {
                        automaticMode = value;
                      });
                    },
                  )
                ]),
          ],
          title: Text(
            'TIC TAC TOE',
            style: TextStyle(
              fontSize: 32,
              fontFamily: 'Ubuntu',
            ),
          ),
        ),
        body: SafeArea(
          child: Container(
            color: Colors.white,
            child: Column(
              mainAxisAlignment: MainAxisAlignment.end,
              crossAxisAlignment: CrossAxisAlignment.stretch,
              children: [
                SizedBox(
                  height: 5,
                ),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.center,
                  children: [
                    Text(message,
                        style: TextStyle(
                          fontSize: 48,
                          fontWeight: FontWeight.bold,
                          fontFamily: 'Ubuntu',
                        )),
                  ],
                ),
                SizedBox(
                  height: 5,
                ),
                Expanded(
                  child: Container(
                    padding: EdgeInsets.all(10),
                    child: GridView.builder(
                        physics: NeverScrollableScrollPhysics(),
                        gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                          crossAxisCount: 3,
                          mainAxisSpacing: 10,
                          crossAxisSpacing: 10,
                        ),
                        itemCount: 9,
                        itemBuilder: (BuildContext context, index) {
                          return GestureDetector(
                            onTap: () {
                              if (playground[index] == '') {
                                setPlayerOnPlayground(index);
                                setState(() {});
                              }
                            },
                            child: Container(
                              color: Color.fromARGB(255, 82, 137, 255),
                              child: Center(
                                child: Text(
                                  playground[index],
                                  style: TextStyle(
                                      fontFamily: 'Ubuntu',
                                      fontSize: 72,
                                      fontWeight: FontWeight.bold),
                                ),
                              ),
                            ),
                          );
                        }),
                  ),
                ),
                IconButton(
                  icon: Icon(
                    Icons.refresh_outlined,
                    size: 48,
                  ),
                  onPressed: () {
                    refreshPlayground();
                    setState(() {});
                  },
                ),
                SizedBox(
                  height: 20,
                ),
                Center(
                  child: Text(
                    'Developed by Varun Khadayate',
                    style: TextStyle(
                      fontSize: 22,
                      fontFamily: 'Ubuntu',
                    ),
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
