using System;
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
	// Token: 0x02000326 RID: 806
	[global::Cpp2ILInjected.Token(Token = "0x2000427")]
	public class CombatText
	{
		// Token: 0x060025B0 RID: 9648 RVA: 0x00028B5F File Offset: 0x00026D5F
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

		// Token: 0x060025B1 RID: 9649 RVA: 0x00028B62 File Offset: 0x00026D62
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

		// Token: 0x060025B2 RID: 9650 RVA: 0x00028B65 File Offset: 0x00026D65
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

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x00028B68 File Offset: 0x00026D68
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

		// Token: 0x060025B4 RID: 9652 RVA: 0x00028B6B File Offset: 0x00026D6B
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

		// Token: 0x060025B5 RID: 9653 RVA: 0x00028B6E File Offset: 0x00026D6E
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

		// Token: 0x060025B6 RID: 9654 RVA: 0x00028B71 File Offset: 0x00026D71
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

		// Token: 0x060025B7 RID: 9655 RVA: 0x00028B74 File Offset: 0x00026D74
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

		// Token: 0x04002C9F RID: 11423
		[global::Cpp2ILInjected.Token(Token = "0x40033BE")]
		public static readonly Color DamagedFriendly;

		// Token: 0x04002CA0 RID: 11424
		[global::Cpp2ILInjected.Token(Token = "0x40033BF")]
		public static readonly Color DamagedFriendlyCrit;

		// Token: 0x04002CA1 RID: 11425
		[global::Cpp2ILInjected.Token(Token = "0x40033C0")]
		public static readonly Color DamagedHostile;

		// Token: 0x04002CA2 RID: 11426
		[global::Cpp2ILInjected.Token(Token = "0x40033C1")]
		public static readonly Color DamagedHostileCrit;

		// Token: 0x04002CA3 RID: 11427
		[global::Cpp2ILInjected.Token(Token = "0x40033C2")]
		public static readonly Color OthersDamagedHostile;

		// Token: 0x04002CA4 RID: 11428
		[global::Cpp2ILInjected.Token(Token = "0x40033C3")]
		public static readonly Color OthersDamagedHostileCrit;

		// Token: 0x04002CA5 RID: 11429
		[global::Cpp2ILInjected.Token(Token = "0x40033C4")]
		public static readonly Color HealLife;

		// Token: 0x04002CA6 RID: 11430
		[global::Cpp2ILInjected.Token(Token = "0x40033C5")]
		public static readonly Color HealMana;

		// Token: 0x04002CA7 RID: 11431
		[global::Cpp2ILInjected.Token(Token = "0x40033C6")]
		public static readonly Color LifeRegen;

		// Token: 0x04002CA8 RID: 11432
		[global::Cpp2ILInjected.Token(Token = "0x40033C7")]
		public static readonly Color LifeRegenNegative;

		// Token: 0x04002CA9 RID: 11433
		[global::Cpp2ILInjected.Token(Token = "0x40033C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Vector2 position;

		// Token: 0x04002CAA RID: 11434
		[global::Cpp2ILInjected.Token(Token = "0x40033C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Vector2 velocity;

		// Token: 0x04002CAB RID: 11435
		[global::Cpp2ILInjected.Token(Token = "0x40033CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public float alpha;

		// Token: 0x04002CAC RID: 11436
		[global::Cpp2ILInjected.Token(Token = "0x40033CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public int alphaDir;

		// Token: 0x04002CAD RID: 11437
		[global::Cpp2ILInjected.Token(Token = "0x40033CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public string text;

		// Token: 0x04002CAE RID: 11438
		[global::Cpp2ILInjected.Token(Token = "0x40033CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public float scale;

		// Token: 0x04002CAF RID: 11439
		[global::Cpp2ILInjected.Token(Token = "0x40033CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public float rotation;

		// Token: 0x04002CB0 RID: 11440
		[global::Cpp2ILInjected.Token(Token = "0x40033CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Color color;

		// Token: 0x04002CB1 RID: 11441
		[global::Cpp2ILInjected.Token(Token = "0x40033D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public bool active;

		// Token: 0x04002CB2 RID: 11442
		[global::Cpp2ILInjected.Token(Token = "0x40033D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int lifeTime;

		// Token: 0x04002CB3 RID: 11443
		[global::Cpp2ILInjected.Token(Token = "0x40033D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public bool crit;

		// Token: 0x04002CB4 RID: 11444
		[global::Cpp2ILInjected.Token(Token = "0x40033D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x45")]
		public bool dot;
	}
}
