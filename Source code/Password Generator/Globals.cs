﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password_Generator
{
    public static class Globals
    {
        public static int[] charSet1 = { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57 };
        public static int[] charSet2 = { 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122 };
        public static int[] charSet3 = { 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 109, 110, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122 };
        public static int[] charSet4 = { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 };
        public static int[] charSet5 = { 65, 66, 67, 68, 69, 70, 71, 72, 74, 75, 76, 77, 78, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 };
        public static int[] charSet6 = { 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 58, 59, 60, 61, 62, 63, 64, 91, 92, 93, 94, 95, 96, 123, 124, 125, 126 };
        public static int[] charSet7 = { 33, 35, 36, 37, 38, 40, 41, 42, 43, 45, 46, 58, 59, 60, 61, 62, 63, 64, 91, 93, 95, 123, 125 };
        public static int[] charSet8 = { 33, 35, 36, 37, 38, 40, 41, 42, 43, 45, 46, 58, 60, 61, 62, 63, 95 };
        public static int[] charSet9 = { 33, 35, 36, 37, 38, 42, 43, 63 };
    }
}