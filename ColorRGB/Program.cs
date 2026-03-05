using System;

ColorRGB red = new ColorRGB(255, 0, 0);
ColorRGB white = new ColorRGB(255, 255, 255);
ColorRGB custom = new ColorRGB(100, 150, 200);

Console.WriteLine("=== RGB 색상 밝기 계산 ===");
Console.Write("빨강 - ");
red.GetColors();
Console.Write("흰색 - ");
white.GetColors();
Console.Write("커스텀 - ");
custom.GetColors();
