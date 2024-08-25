using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	[global::Cpp2ILInjected.Token(Token = "0x20005F2")]
	[global::System.Serializable]
	internal sealed class CompatibleComparer : IEqualityComparer
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002DED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C08350", Offset = "0x1C08350", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CompatibleComparer(IHashCodeProvider hashCodeProvider, IComparer comparer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000715")]
		internal IHashCodeProvider HashCodeProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0837C", Offset = "0x1C0837C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000716")]
		internal IComparer Comparer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C08384", Offset = "0x1C08384", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002DF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0838C", Offset = "0x1C0838C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompatibleComparer), Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		public bool Equals(object a, object b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002DF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C083A4", Offset = "0x1C083A4", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompatibleComparer), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public int Compare(object a, object b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002DF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C08564", Offset = "0x1C08564", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public int GetHashCode(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40019B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly IHashCodeProvider _hcp;

		[global::Cpp2ILInjected.Token(Token = "0x40019B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly IComparer _comparer;
	}
}
