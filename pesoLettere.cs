using System;
using System.Collections.Generic;

public static class PesoLettere
{
    public static int Pesa(string input)
    {
        int value = 0;
        foreach(char c in input){
            char f = c;
            switch(char.ToLower(f)){
                case'a':case'e':case'i':case'o':case'u':case'l':case'n':case'r':case's':case't':
                    value+=1;
                break;
                case'd':case'g':
                    value+=2;
                break;
                case'b':case'c':case'm':case'p':
                    value+=3;
                break;
                case'f':case'h':case'v':case'w':case'y':
                    value+=4;
                break;
                case'k':
                    value+=5;
                break;
                case'j':case'x':
                    value+=8;
                break;
                case'q':case'z':
                    value+=10;
                break;
                default:
                break;
            }
        }
        return value;
    }
}