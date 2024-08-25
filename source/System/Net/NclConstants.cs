using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001A1")]
	internal static class NclConstants
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000A82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0EBE0", Offset = "0x1F0EBE0", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static NclConstants()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000857")]
		internal static readonly object Sentinel;

		[global::Cpp2ILInjected.Token(Token = "0x4000858")]
		internal static readonly object[] EmptyObjectArray;

		[global::Cpp2ILInjected.Token(Token = "0x4000859")]
		internal static readonly Uri[] EmptyUriArray;

		[global::Cpp2ILInjected.Token(Token = "0x400085A")]
		internal static readonly byte[] CRLF;

		[global::Cpp2ILInjected.Token(Token = "0x400085B")]
		internal static readonly byte[] ChunkTerminator;
	}
}
