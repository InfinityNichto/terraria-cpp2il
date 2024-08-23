using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000147 RID: 327
	[global::Cpp2ILInjected.Token(Token = "0x20001D0")]
	internal class CaseInsensitiveAscii : IEqualityComparer, IComparer
	{
		// Token: 0x06000A31 RID: 2609 RVA: 0x00004B0B File Offset: 0x00002D0B
		[global::Cpp2ILInjected.Token(Token = "0x6000B46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F16CF0", Offset = "0x1F16CF0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public int GetHashCode(object myObject)
		{
			throw null;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00004B0E File Offset: 0x00002D0E
		[global::Cpp2ILInjected.Token(Token = "0x6000B47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F16DD4", Offset = "0x1F16DD4", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public int Compare(object firstObject, object secondObject)
		{
			throw null;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00004B11 File Offset: 0x00002D11
		[global::Cpp2ILInjected.Token(Token = "0x6000B48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F16F1C", Offset = "0x1F16F1C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaseInsensitiveAscii), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int FastGetHashCode(string myString)
		{
			throw null;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00004B14 File Offset: 0x00002D14
		[global::Cpp2ILInjected.Token(Token = "0x6000B49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F16FD8", Offset = "0x1F16FD8", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaseInsensitiveAscii), Member = "FastGetHashCode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Equals(object firstObject, object secondObject)
		{
			throw null;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00004B17 File Offset: 0x00002D17
		[global::Cpp2ILInjected.Token(Token = "0x6000B4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F17128", Offset = "0x1F17128", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CaseInsensitiveAscii()
		{
			throw null;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00004B1A File Offset: 0x00002D1A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000B4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F17130", Offset = "0x1F17130", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static CaseInsensitiveAscii()
		{
			throw null;
		}

		// Token: 0x040007C4 RID: 1988
		[global::Cpp2ILInjected.Token(Token = "0x40009E6")]
		internal static readonly CaseInsensitiveAscii StaticInstance;

		// Token: 0x040007C5 RID: 1989
		[global::Cpp2ILInjected.Token(Token = "0x40009E7")]
		internal static readonly byte[] AsciiToLower;
	}
}
