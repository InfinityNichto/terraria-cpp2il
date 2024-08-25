using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Policy
{
	[global::System.MonoTODO("Serialization format not compatible with .NET")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002A7")]
	[global::System.Serializable]
	public sealed class Evidence : global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001744")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0870", Offset = "0x1AF0870", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Evidence()
		{
			throw null;
		}

		[global::System.Obsolete]
		[global::Cpp2ILInjected.Token(Token = "0x1700025A")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001745")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0878", Offset = "0x1AF0878", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700025B")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001746")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF08D4", Offset = "0x1AF08D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700025C")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001747")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF08DC", Offset = "0x1AF08DC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::System.Obsolete]
		[global::Cpp2ILInjected.Token(Token = "0x6001748")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF08E0", Offset = "0x1AF08E0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		[global::System.Obsolete]
		[global::Cpp2ILInjected.Token(Token = "0x6001749")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0998", Offset = "0x1AF0998", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000BE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _locked;

		[global::Cpp2ILInjected.Token(Token = "0x4000BE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Collections.ArrayList hostEvidenceList;

		[global::Cpp2ILInjected.Token(Token = "0x4000BE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.ArrayList assemblyEvidenceList;

		[global::Cpp2ILInjected.Token(Token = "0x20002A8")]
		private class EvidenceEnumerator : global::System.Collections.IEnumerator
		{
			[global::Cpp2ILInjected.Token(Token = "0x600174A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0A40", Offset = "0x1AF0A40", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public EvidenceEnumerator(global::System.Collections.IEnumerator hostenum, global::System.Collections.IEnumerator assemblyenum)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600174B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0A70", Offset = "0x1AF0A70", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600174C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0B98", Offset = "0x1AF0B98", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700025D")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600174D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AF0CB8", Offset = "0x1AF0CB8", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000BE3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.Collections.IEnumerator currentEnum;

			[global::Cpp2ILInjected.Token(Token = "0x4000BE4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private global::System.Collections.IEnumerator hostEnum;

			[global::Cpp2ILInjected.Token(Token = "0x4000BE5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private global::System.Collections.IEnumerator assemblyEnum;
		}
	}
}
