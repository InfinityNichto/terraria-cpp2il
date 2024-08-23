using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000008 RID: 8
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	public class ClipperRegistry
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00002110 File Offset: 0x00000310
		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA8064", Offset = "0x1FA8064", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClipperRegistry), Member = "get_instance", ReturnType = typeof(ClipperRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected ClipperRegistry()
		{
			throw null;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002113 File Offset: 0x00000313
		[global::Cpp2ILInjected.Token(Token = "0x17000012")]
		public static ClipperRegistry instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA6F44", Offset = "0x1FA6F44", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClipperRegistry), Member = "Register", MemberParameters = new object[] { typeof(IClipper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClipperRegistry), Member = "Unregister", MemberParameters = new object[] { typeof(IClipper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClipperRegistry), Member = "Disable", MemberParameters = new object[] { typeof(IClipper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClipperRegistry), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002116 File Offset: 0x00000316
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA6FB8", Offset = "0x1FA6FB8", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Cull()
		{
			throw null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002119 File Offset: 0x00000319
		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA80E0", Offset = "0x1FA80E0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClipperRegistry), Member = "get_instance", ReturnType = typeof(ClipperRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "AddUnique", MemberParameters = new object[]
		{
			"T",
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Register(IClipper c)
		{
			throw null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000211C File Offset: 0x0000031C
		[global::Cpp2ILInjected.Token(Token = "0x600004D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA8144", Offset = "0x1FA8144", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "OnDestroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClipperRegistry), Member = "get_instance", ReturnType = typeof(ClipperRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "Remove", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Unregister(IClipper c)
		{
			throw null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000211F File Offset: 0x0000031F
		[global::Cpp2ILInjected.Token(Token = "0x600004E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA8194", Offset = "0x1FA8194", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClipperRegistry), Member = "get_instance", ReturnType = typeof(ClipperRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "DisableItem", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Disable(IClipper c)
		{
			throw null;
		}

		// Token: 0x04000023 RID: 35
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		private static ClipperRegistry s_Instance;

		// Token: 0x04000024 RID: 36
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly IndexedSet<IClipper> m_Clippers;
	}
}
