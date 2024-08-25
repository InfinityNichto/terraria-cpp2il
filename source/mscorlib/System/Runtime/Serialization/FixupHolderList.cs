using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x20003DF")]
	[global::System.Serializable]
	internal class FixupHolderList
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001F68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58508", Offset = "0x1B58508", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FixupHolderList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		internal FixupHolderList()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001F69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B585F0", Offset = "0x1B585F0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = "AddFixup", MemberParameters = new object[]
		{
			typeof(FixupHolder),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FixupHolderList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal FixupHolderList(int startingSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001F6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5865C", Offset = "0x1B5865C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FixupHolderList), Member = "EnlargeArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal virtual void Add(FixupHolder fixup)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001F6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B586D8", Offset = "0x1B586D8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FixupHolderList), Member = "Add", MemberParameters = new object[] { typeof(FixupHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnlargeArray()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000FB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal FixupHolder[] m_values;

		[global::Cpp2ILInjected.Token(Token = "0x4000FB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int m_count;
	}
}
