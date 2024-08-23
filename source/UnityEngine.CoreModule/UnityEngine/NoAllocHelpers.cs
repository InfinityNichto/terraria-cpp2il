using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000B2 RID: 178
	[NativeHeader("Runtime/Export/Scripting/NoAllocHelpers.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000C3")]
	internal sealed class NoAllocHelpers
	{
		// Token: 0x06000344 RID: 836 RVA: 0x000026D4 File Offset: 0x000008D4
		[global::Cpp2ILInjected.Token(Token = "0x6000356")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593D48", Offset = "0x1593D48", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoAllocHelpers), Member = "Internal_ResizeList", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void ResizeList<T>(List<T> list, int size)
		{
			throw null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000026D7 File Offset: 0x000008D7
		[global::Cpp2ILInjected.Token(Token = "0x6000357")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593C58", Offset = "0x1593C58", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void EnsureListElemCount<T>(List<T> list, int count)
		{
			throw null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000026DA File Offset: 0x000008DA
		[global::Cpp2ILInjected.Token(Token = "0x6000358")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593F50", Offset = "0x1593F50", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new object[] { typeof(List<Color32>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static int SafeLength<T>(List<T> values)
		{
			throw null;
		}

		// Token: 0x06000347 RID: 839
		[FreeFunction("NoAllocHelpers_Bindings::Internal_ResizeList")]
		[global::Cpp2ILInjected.Token(Token = "0x6000359")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7DF40", Offset = "0x1F7DF40", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NoAllocHelpers), Member = "ResizeList", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<T>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern void Internal_ResizeList(object list, int size);

		// Token: 0x06000348 RID: 840
		[FreeFunction("NoAllocHelpers_Bindings::ExtractArrayFromList")]
		[global::Cpp2ILInjected.Token(Token = "0x600035A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6EFA8", Offset = "0x1F6EFA8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(VertexAttributeFormat),
			typeof(int),
			"System.Collections.Generic.List`1<T>",
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			"System.Collections.Generic.List`1<T>",
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<T>",
			typeof(int),
			typeof(VertexAttribute),
			typeof(int),
			typeof(VertexAttributeFormat)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern Array ExtractArrayFromList(object list);
	}
}
