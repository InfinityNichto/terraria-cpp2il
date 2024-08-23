using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	public struct UIVertex
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0000209B File Offset: 0x0000029B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA5938", Offset = "0x1FA5938", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static UIVertex()
		{
			throw null;
		}

		// Token: 0x0400003E RID: 62
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		// Token: 0x0400003F RID: 63
		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public Vector3 normal;

		// Token: 0x04000040 RID: 64
		[global::Cpp2ILInjected.Token(Token = "0x4000040")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Vector4 tangent;

		// Token: 0x04000041 RID: 65
		[global::Cpp2ILInjected.Token(Token = "0x4000041")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Color32 color;

		// Token: 0x04000042 RID: 66
		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public Vector4 uv0;

		// Token: 0x04000043 RID: 67
		[global::Cpp2ILInjected.Token(Token = "0x4000043")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public Vector4 uv1;

		// Token: 0x04000044 RID: 68
		[global::Cpp2ILInjected.Token(Token = "0x4000044")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public Vector4 uv2;

		// Token: 0x04000045 RID: 69
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public Vector4 uv3;

		// Token: 0x04000046 RID: 70
		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		private static readonly Color32 s_DefaultColor;

		// Token: 0x04000047 RID: 71
		[global::Cpp2ILInjected.Token(Token = "0x4000047")]
		private static readonly Vector4 s_DefaultTangent;

		// Token: 0x04000048 RID: 72
		[global::Cpp2ILInjected.Token(Token = "0x4000048")]
		public static UIVertex simpleVert;
	}
}
