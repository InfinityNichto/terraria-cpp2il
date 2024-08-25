using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Chat;
using Terraria.Chat.Commands;
using Terraria.Cinematics;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A6B")]
	public class WorldUIAnchor
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004EA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EA2CC", Offset = "0x8EA2CC", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public WorldUIAnchor()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EA3B8", Offset = "0x8EA3B8", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "EmoteOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "FindFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "DryadConfusedEmote", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "DryadAlertEmote", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmojiCommand), Member = "ProcessOutgoingMessage", MemberParameters = new object[] { typeof(ChatMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RockPaperScissorsCommand), Member = "ProcessOutgoingMessage", MemberParameters = new object[] { typeof(ChatMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteBubble), Member = "DeserializeNetAnchor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(WorldUIAnchor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteBubble), Member = "MakeLocalPlayerEmote", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteButton), Member = "LeftClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public WorldUIAnchor(Entity anchor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EA4B0", Offset = "0x8EA4B0", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public WorldUIAnchor(Vector2 anchor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EA5B0", Offset = "0x8EA5B0", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public WorldUIAnchor(int topLeftX, int topLeftY, int width, int height)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EA74C", Offset = "0x8EA74C", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool InRange(Vector2 target, float tileRangeX, float tileRangeY)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40087C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public WorldUIAnchor.AnchorType type;

		[global::Cpp2ILInjected.Token(Token = "0x40087C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Entity entity;

		[global::Cpp2ILInjected.Token(Token = "0x40087C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Vector2 pos;

		[global::Cpp2ILInjected.Token(Token = "0x40087C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Vector2 size;

		[global::Cpp2ILInjected.Token(Token = "0x2000A6C")]
		public enum AnchorType
		{
			[global::Cpp2ILInjected.Token(Token = "0x40087C5")]
			Entity,
			[global::Cpp2ILInjected.Token(Token = "0x40087C6")]
			Tile,
			[global::Cpp2ILInjected.Token(Token = "0x40087C7")]
			Pos,
			[global::Cpp2ILInjected.Token(Token = "0x40087C8")]
			None
		}
	}
}
