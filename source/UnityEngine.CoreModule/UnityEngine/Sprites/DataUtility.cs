using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Sprites
{
	// Token: 0x020000D4 RID: 212
	[global::Cpp2ILInjected.Token(Token = "0x20000EB")]
	public sealed class DataUtility
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x00002AC7 File Offset: 0x00000CC7
		[global::Cpp2ILInjected.Token(Token = "0x6000510")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87AC0", Offset = "0x1F87AC0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "GetInnerUVs", ReturnType = typeof(Vector4))]
		public static Vector4 GetInnerUV(Sprite sprite)
		{
			throw null;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002ACA File Offset: 0x00000CCA
		[global::Cpp2ILInjected.Token(Token = "0x6000511")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87AC4", Offset = "0x1F87AC4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSimpleSprite", MemberParameters = new object[]
		{
			"UnityEngine.UI.VertexHelper",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateFilledSprite", MemberParameters = new object[]
		{
			"UnityEngine.UI.VertexHelper",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "GetOuterUVs", ReturnType = typeof(Vector4))]
		public static Vector4 GetOuterUV(Sprite sprite)
		{
			throw null;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00002ACD File Offset: 0x00000CCD
		[global::Cpp2ILInjected.Token(Token = "0x6000512")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87AC8", Offset = "0x1F87AC8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GetDrawingDimensions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "GetPadding", ReturnType = typeof(Vector4))]
		public static Vector4 GetPadding(Sprite sprite)
		{
			throw null;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002AD0 File Offset: 0x00000CD0
		[global::Cpp2ILInjected.Token(Token = "0x6000513")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87ACC", Offset = "0x1F87ACC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredWidth", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredHeight", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
		public static Vector2 GetMinSize(Sprite sprite)
		{
			throw null;
		}
	}
}
