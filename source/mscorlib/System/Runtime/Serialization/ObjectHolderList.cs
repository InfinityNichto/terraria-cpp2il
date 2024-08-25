using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x20003E1")]
	internal class ObjectHolderList
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001F75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54D78", Offset = "0x1B54D78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolderList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		internal ObjectHolderList()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001F76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5884C", Offset = "0x1B5884C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "get_SpecialFixupObjects", ReturnType = typeof(ObjectHolderList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolderList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ObjectHolderList(int startingSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001F77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B588B8", Offset = "0x1B588B8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolderList), Member = "EnlargeArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal virtual void Add(ObjectHolder value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001F78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B579A4", Offset = "0x1B579A4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ObjectHolderListEnumerator GetFixupEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001F79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58934", Offset = "0x1B58934", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolderList), Member = "Add", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
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

		[global::Cpp2ILInjected.Token(Token = "0x1700042E")]
		internal int Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B589F0", Offset = "0x1B589F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700042F")]
		internal int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B589F8", Offset = "0x1B589F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000FB9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ObjectHolder[] m_values;

		[global::Cpp2ILInjected.Token(Token = "0x4000FBA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int m_count;
	}
}
