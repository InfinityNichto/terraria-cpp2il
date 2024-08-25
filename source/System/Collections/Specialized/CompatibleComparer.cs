using System;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Specialized
{
	[global::Cpp2ILInjected.Token(Token = "0x2000428")]
	[Serializable]
	internal class CompatibleComparer : IEqualityComparer
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001CD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E924D8", Offset = "0x1E924D8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93160", Offset = "0x1E93160", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public bool Equals(object a, object b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93360", Offset = "0x1E93360", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public int GetHashCode(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000677")]
		public IComparer Comparer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E93468", Offset = "0x1E93468", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000678")]
		public IHashCodeProvider HashCodeProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CDC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E93470", Offset = "0x1E93470", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000679")]
		public static IComparer DefaultComparer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E91C2C", Offset = "0x1E91C2C", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = "GetObjectData", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaseInsensitiveComparer), Member = ".ctor", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700067A")]
		public static IHashCodeProvider DefaultHashCodeProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E91B54", Offset = "0x1E91B54", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = "GetObjectData", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaseInsensitiveHashCodeProvider), Member = ".ctor", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40013C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IComparer _comparer;

		[global::Cpp2ILInjected.Token(Token = "0x40013C9")]
		private static IComparer defaultComparer;

		[global::Cpp2ILInjected.Token(Token = "0x40013CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IHashCodeProvider _hcp;

		[global::Cpp2ILInjected.Token(Token = "0x40013CB")]
		private static IHashCodeProvider defaultHashProvider;
	}
}
