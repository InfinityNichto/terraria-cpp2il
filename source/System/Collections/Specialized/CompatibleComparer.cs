using System;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Specialized
{
	// Token: 0x0200030C RID: 780
	[global::Cpp2ILInjected.Token(Token = "0x2000428")]
	[Serializable]
	internal class CompatibleComparer : IEqualityComparer
	{
		// Token: 0x060019CF RID: 6607 RVA: 0x000076CA File Offset: 0x000058CA
		[global::Cpp2ILInjected.Token(Token = "0x6001CD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E924D8", Offset = "0x1E924D8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider)
		{
			throw null;
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x000076CD File Offset: 0x000058CD
		[global::Cpp2ILInjected.Token(Token = "0x6001CD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93160", Offset = "0x1E93160", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public bool Equals(object a, object b)
		{
			throw null;
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x000076D0 File Offset: 0x000058D0
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

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x000076D3 File Offset: 0x000058D3
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

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x000076D6 File Offset: 0x000058D6
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

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x000076D9 File Offset: 0x000058D9
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

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x000076DC File Offset: 0x000058DC
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

		// Token: 0x04000F6F RID: 3951
		[global::Cpp2ILInjected.Token(Token = "0x40013C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IComparer _comparer;

		// Token: 0x04000F70 RID: 3952
		[global::Cpp2ILInjected.Token(Token = "0x40013C9")]
		private static IComparer defaultComparer;

		// Token: 0x04000F71 RID: 3953
		[global::Cpp2ILInjected.Token(Token = "0x40013CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IHashCodeProvider _hcp;

		// Token: 0x04000F72 RID: 3954
		[global::Cpp2ILInjected.Token(Token = "0x40013CB")]
		private static IHashCodeProvider defaultHashProvider;
	}
}
