using System;

class Example {
    public static void Main(string[] args) {
        // If <Boolean Expression> { <statement> }
        // 
        if (a > b) then c = 0;

        // 
        if a > b { c = 0; }

        // Correct
        if (a > b ) c = 0;

        if (a > b ) c = 0 else b = 0;

    }
}