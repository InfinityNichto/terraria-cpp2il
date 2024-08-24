using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000346 RID: 838
	[global::Cpp2ILInjected.Token(Token = "0x200045C")]
	public class Star
	{
		// Token: 0x06002778 RID: 10104 RVA: 0x0002909F File Offset: 0x0002729F
		[global::Cpp2ILInjected.Token(Token = "0x6002A32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1170060", Offset = "0x1170060", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime_StartNight", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void NightSetup()
		{
			throw null;
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x000290A2 File Offset: 0x000272A2
		[global::Cpp2ILInjected.Token(Token = "0x6002A33")]
		[global::Cpp2ILInjected.Address(RVA = "0x11701FC", Offset = "0x11701FC", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_148_StarSpawner", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void StarFall(float positionX)
		{
			throw null;
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x000290A5 File Offset: 0x000272A5
		[global::Cpp2ILInjected.Token(Token = "0x6002A34")]
		[global::Cpp2ILInjected.Address(RVA = "0x11704A8", Offset = "0x11704A8", Length = "0x594")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSunAndMoon", MemberParameters = new object[]
		{
			typeof(Main.SceneArea),
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Star), Member = "UpdateStars", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "CreateWithRandomSeed", ReturnType = typeof(FastRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static void SpawnStars(int s = -1)
		{
			throw null;
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x000290A8 File Offset: 0x000272A8
		[global::Cpp2ILInjected.Token(Token = "0x6002A35")]
		[global::Cpp2ILInjected.Address(RVA = "0x11703EC", Offset = "0x11703EC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Fall()
		{
			throw null;
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000290AB File Offset: 0x000272AB
		[global::Cpp2ILInjected.Token(Token = "0x6002A36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1170A44", Offset = "0x1170A44", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Star), Member = "UpdateStars", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x000290AE File Offset: 0x000272AE
		[global::Cpp2ILInjected.Token(Token = "0x6002A37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1170CE4", Offset = "0x1170CE4", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Star), Member = "SpawnStars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Star), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void UpdateStars()
		{
			throw null;
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x000290B1 File Offset: 0x000272B1
		[global::Cpp2ILInjected.Token(Token = "0x6002A38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1170A3C", Offset = "0x1170A3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Star()
		{
			throw null;
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000290B4 File Offset: 0x000272B4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002A39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1170E6C", Offset = "0x1170E6C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Star()
		{
			throw null;
		}

		// Token: 0x04002F52 RID: 12114
		[global::Cpp2ILInjected.Token(Token = "0x4003732")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Vector2 position;

		// Token: 0x04002F53 RID: 12115
		[global::Cpp2ILInjected.Token(Token = "0x4003733")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float scale;

		// Token: 0x04002F54 RID: 12116
		[global::Cpp2ILInjected.Token(Token = "0x4003734")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float rotation;

		// Token: 0x04002F55 RID: 12117
		[global::Cpp2ILInjected.Token(Token = "0x4003735")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int type;

		// Token: 0x04002F56 RID: 12118
		[global::Cpp2ILInjected.Token(Token = "0x4003736")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float twinkle;

		// Token: 0x04002F57 RID: 12119
		[global::Cpp2ILInjected.Token(Token = "0x4003737")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public float twinkleSpeed;

		// Token: 0x04002F58 RID: 12120
		[global::Cpp2ILInjected.Token(Token = "0x4003738")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public float rotationSpeed;

		// Token: 0x04002F59 RID: 12121
		[global::Cpp2ILInjected.Token(Token = "0x4003739")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public bool falling;

		// Token: 0x04002F5A RID: 12122
		[global::Cpp2ILInjected.Token(Token = "0x400373A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		public bool hidden;

		// Token: 0x04002F5B RID: 12123
		[global::Cpp2ILInjected.Token(Token = "0x400373B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public Vector2 fallSpeed;

		// Token: 0x04002F5C RID: 12124
		[global::Cpp2ILInjected.Token(Token = "0x400373C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int fallTime;

		// Token: 0x04002F5D RID: 12125
		[global::Cpp2ILInjected.Token(Token = "0x400373D")]
		public static bool dayCheck;

		// Token: 0x04002F5E RID: 12126
		[global::Cpp2ILInjected.Token(Token = "0x400373E")]
		public static float starfallBoost;

		// Token: 0x04002F5F RID: 12127
		[global::Cpp2ILInjected.Token(Token = "0x400373F")]
		public static int starFallCount;

		// Token: 0x04002F60 RID: 12128
		[global::Cpp2ILInjected.Token(Token = "0x4003740")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public float fadeIn;
	}
}
