using System;
using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
	// Token: 0x02000038 RID: 56
	[global::Cpp2ILInjected.Token(Token = "0x2000070")]
	public static class StencilMaterial
	{
		// Token: 0x06000430 RID: 1072 RVA: 0x00002C89 File Offset: 0x00000E89
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Material.Add instead.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000493")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB950", Offset = "0x1FDB950", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Material Add(Material baseMat, int stencilID)
		{
			throw null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002C8C File Offset: 0x00000E8C
		[global::Cpp2ILInjected.Token(Token = "0x6000494")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB958", Offset = "0x1FDB958", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mask), Member = "GetModifiedMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask)
		{
			throw null;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002C8F File Offset: 0x00000E8F
		[global::Cpp2ILInjected.Token(Token = "0x6000495")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDC23C", Offset = "0x1FDC23C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StencilMaterial), Member = "Add", MemberParameters = new object[]
		{
			typeof(Material),
			typeof(int),
			typeof(StencilOp),
			typeof(CompareFunction),
			typeof(ColorWriteMask),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isBatchMode", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void LogWarningWhenNotInBatchmode(string warning, Object context)
		{
			throw null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002C92 File Offset: 0x00000E92
		[global::Cpp2ILInjected.Token(Token = "0x6000496")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB9E4", Offset = "0x1FDB9E4", Length = "0x858")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mask), Member = "GetModifiedMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "GetModifiedMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StencilMaterial), Member = "LogWarningWhenNotInBatchmode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new object[] { typeof(HideFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 55)]
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask)
		{
			throw null;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002C95 File Offset: 0x00000E95
		[global::Cpp2ILInjected.Token(Token = "0x6000497")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDC2C4", Offset = "0x1FDC2C4", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mask), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mask), Member = "GetModifiedMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "GetModifiedMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "RecalculateMasking", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Misc), Member = "DestroyImmediate", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void Remove(Material customMat)
		{
			throw null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002C98 File Offset: 0x00000E98
		[global::Cpp2ILInjected.Token(Token = "0x6000498")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDC470", Offset = "0x1FDC470", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Misc), Member = "DestroyImmediate", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void ClearAll()
		{
			throw null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002C9B File Offset: 0x00000E9B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000499")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDC57C", Offset = "0x1FDC57C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static StencilMaterial()
		{
			throw null;
		}

		// Token: 0x0400016F RID: 367
		[global::Cpp2ILInjected.Token(Token = "0x4000238")]
		private static List<StencilMaterial.MatEntry> m_List;

		// Token: 0x020000B7 RID: 183
		[global::Cpp2ILInjected.Token(Token = "0x2000071")]
		private class MatEntry
		{
			// Token: 0x060006C7 RID: 1735 RVA: 0x000033E5 File Offset: 0x000015E5
			[global::Cpp2ILInjected.Token(Token = "0x600049A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDC2B4", Offset = "0x1FDC2B4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MatEntry()
			{
				throw null;
			}

			// Token: 0x04000312 RID: 786
			[global::Cpp2ILInjected.Token(Token = "0x4000239")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Material baseMat;

			// Token: 0x04000313 RID: 787
			[global::Cpp2ILInjected.Token(Token = "0x400023A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Material customMat;

			// Token: 0x04000314 RID: 788
			[global::Cpp2ILInjected.Token(Token = "0x400023B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int count;

			// Token: 0x04000315 RID: 789
			[global::Cpp2ILInjected.Token(Token = "0x400023C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public int stencilId;

			// Token: 0x04000316 RID: 790
			[global::Cpp2ILInjected.Token(Token = "0x400023D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public StencilOp operation;

			// Token: 0x04000317 RID: 791
			[global::Cpp2ILInjected.Token(Token = "0x400023E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			public CompareFunction compareFunction;

			// Token: 0x04000318 RID: 792
			[global::Cpp2ILInjected.Token(Token = "0x400023F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int readMask;

			// Token: 0x04000319 RID: 793
			[global::Cpp2ILInjected.Token(Token = "0x4000240")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public int writeMask;

			// Token: 0x0400031A RID: 794
			[global::Cpp2ILInjected.Token(Token = "0x4000241")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public bool useAlphaClip;

			// Token: 0x0400031B RID: 795
			[global::Cpp2ILInjected.Token(Token = "0x4000242")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			public ColorWriteMask colorMask;
		}
	}
}
