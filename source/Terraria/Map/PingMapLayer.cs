﻿using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.GameContent.NetModules;
using Terraria.UI;

namespace Terraria.Map
{
	[global::Cpp2ILInjected.Token(Token = "0x20006BD")]
	public class PingMapLayer : IMapLayer
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003922")]
		[global::Cpp2ILInjected.Address(RVA = "0x1448418", Offset = "0x1448418", Length = "0x4B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapOverlayDrawContext), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(SpriteFrame),
			typeof(Alignment)
		}, ReturnType = typeof(MapOverlayDrawContext.DrawResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<PingMapLayer.Ping>), Member = "Remove", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public void Draw(ref MapOverlayDrawContext context, ref string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003923")]
		[global::Cpp2ILInjected.Address(RVA = "0x14488CC", Offset = "0x14488CC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TriggerPing", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetPingModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<PingMapLayer.Ping>), Member = "get_Capacity", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PingMapLayer.Ping), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<PingMapLayer.Ping>), Member = "Add", MemberParameters = new object[] { typeof(PingMapLayer.Ping) }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Add(Vector2 position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003924")]
		[global::Cpp2ILInjected.Address(RVA = "0x14489F4", Offset = "0x14489F4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<PingMapLayer.Ping>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public PingMapLayer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40079B2")]
		private const double PING_DURATION_IN_SECONDS = 15.0;

		[global::Cpp2ILInjected.Token(Token = "0x40079B3")]
		private const double PING_FRAME_RATE = 10.0;

		[global::Cpp2ILInjected.Token(Token = "0x40079B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly SlotVector<PingMapLayer.Ping> _pings;

		[global::Cpp2ILInjected.Token(Token = "0x20006BE")]
		private struct Ping
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003925")]
			[global::Cpp2ILInjected.Address(RVA = "0x1448984", Offset = "0x1448984", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PingMapLayer), Member = "Add", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Ping(Vector2 position)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40079B5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly Vector2 Position;

			[global::Cpp2ILInjected.Token(Token = "0x40079B6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly DateTime Time;
		}
	}
}
