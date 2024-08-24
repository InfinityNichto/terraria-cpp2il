using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Graphics
{
	// Token: 0x020004DD RID: 1245
	[global::Cpp2ILInjected.Token(Token = "0x2000732")]
	public struct SpriteRenderTargetHelper
	{
		// Token: 0x06003693 RID: 13971 RVA: 0x0002BBFE File Offset: 0x00029DFE
		[global::Cpp2ILInjected.Token(Token = "0x6003CF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1498DB8", Offset = "0x1498DB8", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_DrawSelectionRect", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_DrawSelectionRect", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteRenderTargetHelper), Member = "GetHighsAndLowsOf", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref DrawData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void GetDrawBoundary(int playerDrawDataCount, DrawData[] playerDrawData, out Vector2 lowest, out Vector2 highest)
		{
			throw null;
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x0002BC01 File Offset: 0x00029E01
		[global::Cpp2ILInjected.Token(Token = "0x6003CF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1498F1C", Offset = "0x1498F1C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteRenderTargetHelper), Member = "GetDrawBoundary", MemberParameters = new object[]
		{
			typeof(int),
			typeof(DrawData[]),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteRenderTargetHelper), Member = "GetHighsAndLowsOf", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref DrawData),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		public static void GetHighsAndLowsOf(ref Vector2 lowest, ref Vector2 highest, ref DrawData cdd)
		{
			throw null;
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x0002BC04 File Offset: 0x00029E04
		[global::Cpp2ILInjected.Token(Token = "0x6003CF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1499034", Offset = "0x1499034", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteRenderTargetHelper), Member = "GetHighsAndLowsOf", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref DrawData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteRenderTargetHelper), Member = "GetCorner", MemberParameters = new object[]
		{
			typeof(ref DrawData),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Min", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Max", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void GetHighsAndLowsOf(ref Vector2 lowest, ref Vector2 highest, ref DrawData cdd, ref Vector2 pos, ref Vector2 origin, Vector2 corner)
		{
			throw null;
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x0002BC07 File Offset: 0x00029E07
		[global::Cpp2ILInjected.Token(Token = "0x6003CF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1499114", Offset = "0x1499114", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteRenderTargetHelper), Member = "GetHighsAndLowsOf", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref DrawData),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 GetCorner(ref DrawData cdd, ref Vector2 pos, ref Vector2 origin, Vector2 corner)
		{
			throw null;
		}
	}
}
