using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x20003E2")]
	internal class ObjectHolderListEnumerator
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001F7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B589B4", Offset = "0x1B589B4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001F7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B57A48", Offset = "0x1B57A48", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal bool MoveNext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000430")]
		internal ObjectHolder Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B57A14", Offset = "0x1B57A14", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000FBB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool m_isFixupEnumerator;

		[global::Cpp2ILInjected.Token(Token = "0x4000FBC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ObjectHolderList m_list;

		[global::Cpp2ILInjected.Token(Token = "0x4000FBD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_startingVersion;

		[global::Cpp2ILInjected.Token(Token = "0x4000FBE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int m_currPos;
	}
}
