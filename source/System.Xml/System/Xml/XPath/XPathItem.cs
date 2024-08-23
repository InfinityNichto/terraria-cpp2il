using System;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.XPath
{
	// Token: 0x0200008B RID: 139
	[global::Cpp2ILInjected.Token(Token = "0x20000B5")]
	public abstract class XPathItem
	{
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000739 RID: 1849
		[global::Cpp2ILInjected.Token(Token = "0x170001D4")]
		public abstract XmlSchemaType XmlType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007C7")]
			get;
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600073A RID: 1850
		[global::Cpp2ILInjected.Token(Token = "0x170001D5")]
		public abstract string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007C8")]
			get;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600073B RID: 1851
		[global::Cpp2ILInjected.Token(Token = "0x170001D6")]
		public abstract object TypedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007C9")]
			get;
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600073C RID: 1852
		[global::Cpp2ILInjected.Token(Token = "0x170001D7")]
		public abstract Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007CA")]
			get;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600073D RID: 1853
		[global::Cpp2ILInjected.Token(Token = "0x170001D8")]
		public abstract bool ValueAsBoolean
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007CB")]
			get;
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600073E RID: 1854
		[global::Cpp2ILInjected.Token(Token = "0x170001D9")]
		public abstract DateTime ValueAsDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007CC")]
			get;
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600073F RID: 1855
		[global::Cpp2ILInjected.Token(Token = "0x170001DA")]
		public abstract double ValueAsDouble
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007CD")]
			get;
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000740 RID: 1856
		[global::Cpp2ILInjected.Token(Token = "0x170001DB")]
		public abstract int ValueAsInt
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007CE")]
			get;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000741 RID: 1857
		[global::Cpp2ILInjected.Token(Token = "0x170001DC")]
		public abstract long ValueAsLong
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007CF")]
			get;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0000444B File Offset: 0x0000264B
		[global::Cpp2ILInjected.Token(Token = "0x60007D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB1A1C", Offset = "0x1DB1A1C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual object ValueAs(Type returnType)
		{
			throw null;
		}

		// Token: 0x06000743 RID: 1859
		[global::Cpp2ILInjected.Token(Token = "0x60007D1")]
		public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);

		// Token: 0x06000744 RID: 1860 RVA: 0x0000444E File Offset: 0x0000264E
		[global::Cpp2ILInjected.Token(Token = "0x60007D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB1A30", Offset = "0x1DB1A30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(string),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlSchemaType),
			typeof(object),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected XPathItem()
		{
			throw null;
		}
	}
}
