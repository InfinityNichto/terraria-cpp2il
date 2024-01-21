using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.Map;

[Cpp2IlInjected.Token(Token = "0x20004AD")]
public class PingMapLayer : IMapLayer
{
	[Cpp2IlInjected.Token(Token = "0x200093F")]
	private struct Ping
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008ADB")]
		public readonly Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008ADC")]
		public readonly DateTime Time;

		[Cpp2IlInjected.Token(Token = "0x6004D05")]
		[Cpp2IlInjected.Address(RVA = "0x39A6F0", Offset = "0x39A6F0", VA = "0x39A6F0")]
		public Ping(Vector2 position)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40065A4")]
	private const double PING_DURATION_IN_SECONDS = 15.0;

	[Cpp2IlInjected.Token(Token = "0x40065A5")]
	private const double PING_FRAME_RATE = 10.0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40065A6")]
	private readonly SlotVector<Ping> _pings;

	[Cpp2IlInjected.Token(Token = "0x6003405")]
	[Cpp2IlInjected.Address(RVA = "0xE9C114", Offset = "0xE9C114", VA = "0xE9C114", Slot = "4")]
	public void Draw(ref MapOverlayDrawContext context, ref string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003406")]
	[Cpp2IlInjected.Address(RVA = "0xE9C5E0", Offset = "0xE9C5E0", VA = "0xE9C5E0")]
	public void Add(Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003407")]
	[Cpp2IlInjected.Address(RVA = "0xE9C740", Offset = "0xE9C740", VA = "0xE9C740")]
	public PingMapLayer()
	{
	}
}
