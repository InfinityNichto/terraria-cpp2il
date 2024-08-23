using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000054 RID: 84
	[global::Cpp2ILInjected.Token(Token = "0x2000071")]
	public class XmlImplementation
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x00003DAF File Offset: 0x00001FAF
		[global::Cpp2ILInjected.Token(Token = "0x600056E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D933A4", Offset = "0x1D933A4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlImplementation()
		{
			throw null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00003DB2 File Offset: 0x00001FB2
		[global::Cpp2ILInjected.Token(Token = "0x600056F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D93474", Offset = "0x1D93474", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XmlImplementation(XmlNameTable nt)
		{
			throw null;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00003DB5 File Offset: 0x00001FB5
		[global::Cpp2ILInjected.Token(Token = "0x6000570")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9349C", Offset = "0x1D9349C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = ".ctor", MemberParameters = new object[] { typeof(XmlImplementation) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlDocument CreateDocument()
		{
			throw null;
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00003DB8 File Offset: 0x00001FB8
		[global::Cpp2ILInjected.Token(Token = "0x1700015A")]
		internal XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000571")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D934F8", Offset = "0x1D934F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040001E3 RID: 483
		[global::Cpp2ILInjected.Token(Token = "0x40002DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlNameTable nameTable;
	}
}
