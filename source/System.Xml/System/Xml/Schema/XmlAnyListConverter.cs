using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x02000132 RID: 306
	[global::Cpp2ILInjected.Token(Token = "0x2000166")]
	internal class XmlAnyListConverter : XmlListConverter
	{
		// Token: 0x06000BC0 RID: 3008 RVA: 0x000050AE File Offset: 0x000032AE
		[global::Cpp2ILInjected.Token(Token = "0x6000C5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEAA0C", Offset = "0x1DEAA0C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected XmlAnyListConverter(XmlBaseConverter atomicConverter)
		{
			throw null;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x000050B1 File Offset: 0x000032B1
		[global::Cpp2ILInjected.Token(Token = "0x6000C5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEAA80", Offset = "0x1DEAA80", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x000050B4 File Offset: 0x000032B4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000C5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DEACBC", Offset = "0x1DEACBC", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlListConverter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlBaseConverter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static XmlAnyListConverter()
		{
			throw null;
		}

		// Token: 0x0400049A RID: 1178
		[global::Cpp2ILInjected.Token(Token = "0x400062D")]
		public static readonly XmlValueConverter ItemList;

		// Token: 0x0400049B RID: 1179
		[global::Cpp2ILInjected.Token(Token = "0x400062E")]
		public static readonly XmlValueConverter AnyAtomicList;
	}
}
