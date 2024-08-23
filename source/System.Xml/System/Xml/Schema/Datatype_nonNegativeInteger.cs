using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000E4 RID: 228
	[global::Cpp2ILInjected.Token(Token = "0x2000110")]
	internal class Datatype_nonNegativeInteger : Datatype_integer
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x0000491F File Offset: 0x00002B1F
		[global::Cpp2ILInjected.Token(Token = "0x17000292")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000982")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC3C68", Offset = "0x1DC3C68", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00004922 File Offset: 0x00002B22
		[global::Cpp2ILInjected.Token(Token = "0x17000293")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000983")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC3CC0", Offset = "0x1DC3CC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00004925 File Offset: 0x00002B25
		[global::Cpp2ILInjected.Token(Token = "0x6000984")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC3CC8", Offset = "0x1DC3CC8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_integer), Member = ".ctor", ReturnType = typeof(void))]
		public Datatype_nonNegativeInteger()
		{
			throw null;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00004928 File Offset: 0x00002B28
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000985")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC3CCC", Offset = "0x1DC3CCC", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static Datatype_nonNegativeInteger()
		{
			throw null;
		}

		// Token: 0x0400037F RID: 895
		[global::Cpp2ILInjected.Token(Token = "0x40004F9")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
