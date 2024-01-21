using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Drawing;

[Cpp2IlInjected.Token(Token = "0x200066E")]
public class WindGrid
{
	[Cpp2IlInjected.Token(Token = "0x2000A59")]
	private struct WindCoord
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008E2D")]
		public int Time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008E2E")]
		public int DirectionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E2F")]
		public int DirectionY;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006D7D")]
	private WindCoord[,] _grid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006D7E")]
	private int _width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006D7F")]
	private int _height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006D80")]
	private int _gameTime;

	[Cpp2IlInjected.Token(Token = "0x4006D81")]
	private static List<Point> points;

	[Cpp2IlInjected.Token(Token = "0x600410D")]
	[Cpp2IlInjected.Address(RVA = "0xF4C60C", Offset = "0xF4C60C", VA = "0xF4C60C")]
	public void SetSize(int targetWidth, int targetHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600410E")]
	[Cpp2IlInjected.Address(RVA = "0xF4C768", Offset = "0xF4C768", VA = "0xF4C768")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600410F")]
	[Cpp2IlInjected.Address(RVA = "0xF4C980", Offset = "0xF4C980", VA = "0xF4C980")]
	public void GetWindTime(int tileX, int tileY, int timeThreshold, out int windTimeLeft, out int directionX, out int directionY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004110")]
	[Cpp2IlInjected.Address(RVA = "0xF4C6BC", Offset = "0xF4C6BC", VA = "0xF4C6BC")]
	private void ResizeGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004111")]
	[Cpp2IlInjected.Address(RVA = "0xF4CA0C", Offset = "0xF4CA0C", VA = "0xF4CA0C")]
	private void SetWindTime(int tileX, int tileY, int directionX, int directionY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004112")]
	[Cpp2IlInjected.Address(RVA = "0xF4C7FC", Offset = "0xF4C7FC", VA = "0xF4C7FC")]
	private void ScanPlayers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004113")]
	[Cpp2IlInjected.Address(RVA = "0xF4CAA8", Offset = "0xF4CAA8", VA = "0xF4CAA8")]
	private void ScanPlayer(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004114")]
	[Cpp2IlInjected.Address(RVA = "0xF4CEDC", Offset = "0xF4CEDC", VA = "0xF4CEDC")]
	public WindGrid()
	{
	}
}
