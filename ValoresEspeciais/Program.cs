﻿using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbmin = sbyte.MinValue;
            sbyte sbmax = sbyte.MaxValue;

            short shmin = short.MinValue;
            short shmax = short.MaxValue;

            int inmin = int.MinValue;
            int inmax = int.MaxValue;

            long lomin = long.MinValue;
            long lomax = long.MaxValue;

            byte bymin = byte.MinValue;
            byte bymax = byte.MaxValue;

            ushort usmin = ushort.MinValue;
            ushort usmax = ushort.MaxValue;

            uint uimin = uint.MinValue;
            uint uimax = uint.MaxValue;

            ulong ulmin = ulong.MinValue;
            ulong ulmax = ulong.MaxValue;

            char chmin = char.MinValue;
            char chmax = char.MaxValue;

            Console.WriteLine($"sbyte max e min values: {sbmin}  {sbmax}");
            Console.WriteLine($"short max e min values: {shmin}  {shmax}");
            Console.WriteLine($"int max e min values: {inmin}  {inmax}");
            Console.WriteLine($"long max e min values: {lomin}  {lomax}");
            Console.WriteLine($"byte max e min values: {bymin}  {bymax}");
            Console.WriteLine($"ushort max e min values: {usmin}  {usmax}");
            Console.WriteLine($"uint max e min values: {uimin}  {uimax}");
            Console.WriteLine($"ulong max e min values: {ulmin}  {ulmax}");
            Console.WriteLine($"char max e min values: {chmin}  {chmax}");
        }
    }
}
