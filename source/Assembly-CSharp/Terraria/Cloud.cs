using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.IO;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000324 RID: 804
	[global::Cpp2ILInjected.Token(Token = "0x2000424")]
	public class Cloud
	{
		// Token: 0x06002563 RID: 9571 RVA: 0x00028A78 File Offset: 0x00026C78
		[global::Cpp2ILInjected.Token(Token = "0x6002760")]
		[global::Cpp2ILInjected.Address(RVA = "0x10BD168", Offset = "0x10BD168", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBG", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ClientLoopFrameUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RandomizeWeather", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cloud), Member = "addCloud", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void resetClouds()
		{
			throw null;
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x00028A7B File Offset: 0x00026C7B
		[global::Cpp2ILInjected.Token(Token = "0x6002761")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C5FA0", Offset = "0x10C5FA0", Length = "0xF48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cloud), Member = "resetClouds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cloud), Member = "UpdateClouds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHostOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cloud), Member = "RollRareCloud", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 70)]
		public static void addCloud()
		{
			throw null;
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x00028A7E File Offset: 0x00026C7E
		[global::Cpp2ILInjected.Token(Token = "0x6002762")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C6EE8", Offset = "0x10C6EE8", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cloud), Member = "addCloud", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static int RollRareCloud()
		{
			throw null;
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00028A81 File Offset: 0x00026C81
		[global::Cpp2ILInjected.Token(Token = "0x6002763")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C70F8", Offset = "0x10C70F8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Color cloudColor(Color bgColor)
		{
			throw null;
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00028A84 File Offset: 0x00026C84
		[global::Cpp2ILInjected.Token(Token = "0x6002764")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C71EC", Offset = "0x10C71EC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x00028A87 File Offset: 0x00026C87
		[global::Cpp2ILInjected.Token(Token = "0x6002765")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C71F4", Offset = "0x10C71F4", Length = "0x424")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHostOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cloud), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cloud), Member = "addCloud", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public static void UpdateClouds()
		{
			throw null;
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x00028A8A File Offset: 0x00026C8A
		[global::Cpp2ILInjected.Token(Token = "0x6002766")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C7618", Offset = "0x10C7618", Length = "0x59C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cloud), Member = "UpdateClouds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenLastPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_bgAlphaFrontLayer", ReturnType = typeof(float[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00028A8D File Offset: 0x00026C8D
		[global::Cpp2ILInjected.Token(Token = "0x6002767")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C7BB4", Offset = "0x10C7BB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_Entities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Cloud()
		{
			throw null;
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00028A90 File Offset: 0x00026C90
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002768")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C7BBC", Offset = "0x10C7BBC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Cloud()
		{
			throw null;
		}

		// Token: 0x04002C7F RID: 11391
		[global::Cpp2ILInjected.Token(Token = "0x400339B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Vector2 position;

		// Token: 0x04002C80 RID: 11392
		[global::Cpp2ILInjected.Token(Token = "0x400339C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float scale;

		// Token: 0x04002C81 RID: 11393
		[global::Cpp2ILInjected.Token(Token = "0x400339D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float rotation;

		// Token: 0x04002C82 RID: 11394
		[global::Cpp2ILInjected.Token(Token = "0x400339E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public float rSpeed;

		// Token: 0x04002C83 RID: 11395
		[global::Cpp2ILInjected.Token(Token = "0x400339F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float sSpeed;

		// Token: 0x04002C84 RID: 11396
		[global::Cpp2ILInjected.Token(Token = "0x40033A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public bool active;

		// Token: 0x04002C85 RID: 11397
		[global::Cpp2ILInjected.Token(Token = "0x40033A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public SpriteEffects spriteDir;

		// Token: 0x04002C86 RID: 11398
		[global::Cpp2ILInjected.Token(Token = "0x40033A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int type;

		// Token: 0x04002C87 RID: 11399
		[global::Cpp2ILInjected.Token(Token = "0x40033A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int width;

		// Token: 0x04002C88 RID: 11400
		[global::Cpp2ILInjected.Token(Token = "0x40033A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int height;

		// Token: 0x04002C89 RID: 11401
		[global::Cpp2ILInjected.Token(Token = "0x40033A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public float Alpha;

		// Token: 0x04002C8A RID: 11402
		[global::Cpp2ILInjected.Token(Token = "0x40033A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool kill;

		// Token: 0x04002C8B RID: 11403
		[global::Cpp2ILInjected.Token(Token = "0x40033A7")]
		private static UnifiedRandom rand;
	}
}
