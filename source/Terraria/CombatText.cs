﻿using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Cinematics;
using Terraria.DataStructures;
using Terraria.Utilities;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x2000427")]
	public class CombatText
	{
		[global::Cpp2ILInjected.Token(Token = "0x60027AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C7C2C", Offset = "0x10C7C2C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HealEffect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "StrikeNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "UpdateNPC_BuffApplyDOTs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HealEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ManaEffect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateLifeRegen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Hurt", MemberParameters = new object[]
		{
			typeof(PlayerDeathReason),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CombatText), Member = "NewText", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Color),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int NewText(Rectangle location, Color color, int amount, bool dramatic = false, bool dot = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C7CD8", Offset = "0x10C7CD8", Length = "0x458")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CombatText), Member = "NewText", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Color),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHostOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static int NewText(Rectangle location, Color color, string text, bool dramatic = false, bool dot = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C8130", Offset = "0x10C8130", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "PerFrameSettings", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void clearAll()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700055C")]
		public static float TargetScale
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x10C81A0", Offset = "0x10C81A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C81A8", Offset = "0x10C81A8", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CombatText), Member = "UpdateCombatText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C8400", Offset = "0x10C8400", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CombatText), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void UpdateCombatText()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C8498", Offset = "0x10C8498", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_Entities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public CombatText()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60027B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C84F8", Offset = "0x10C84F8", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static CombatText()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40033BE")]
		public static readonly Color DamagedFriendly;

		[global::Cpp2ILInjected.Token(Token = "0x40033BF")]
		public static readonly Color DamagedFriendlyCrit;

		[global::Cpp2ILInjected.Token(Token = "0x40033C0")]
		public static readonly Color DamagedHostile;

		[global::Cpp2ILInjected.Token(Token = "0x40033C1")]
		public static readonly Color DamagedHostileCrit;

		[global::Cpp2ILInjected.Token(Token = "0x40033C2")]
		public static readonly Color OthersDamagedHostile;

		[global::Cpp2ILInjected.Token(Token = "0x40033C3")]
		public static readonly Color OthersDamagedHostileCrit;

		[global::Cpp2ILInjected.Token(Token = "0x40033C4")]
		public static readonly Color HealLife;

		[global::Cpp2ILInjected.Token(Token = "0x40033C5")]
		public static readonly Color HealMana;

		[global::Cpp2ILInjected.Token(Token = "0x40033C6")]
		public static readonly Color LifeRegen;

		[global::Cpp2ILInjected.Token(Token = "0x40033C7")]
		public static readonly Color LifeRegenNegative;

		[global::Cpp2ILInjected.Token(Token = "0x40033C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Vector2 position;

		[global::Cpp2ILInjected.Token(Token = "0x40033C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Vector2 velocity;

		[global::Cpp2ILInjected.Token(Token = "0x40033CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public float alpha;

		[global::Cpp2ILInjected.Token(Token = "0x40033CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public int alphaDir;

		[global::Cpp2ILInjected.Token(Token = "0x40033CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public string text;

		[global::Cpp2ILInjected.Token(Token = "0x40033CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public float scale;

		[global::Cpp2ILInjected.Token(Token = "0x40033CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public float rotation;

		[global::Cpp2ILInjected.Token(Token = "0x40033CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Color color;

		[global::Cpp2ILInjected.Token(Token = "0x40033D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public bool active;

		[global::Cpp2ILInjected.Token(Token = "0x40033D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int lifeTime;

		[global::Cpp2ILInjected.Token(Token = "0x40033D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public bool crit;

		[global::Cpp2ILInjected.Token(Token = "0x40033D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x45")]
		public bool dot;
	}
}
