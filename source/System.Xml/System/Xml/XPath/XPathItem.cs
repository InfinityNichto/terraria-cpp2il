using System;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.XPath
{
	[global::Cpp2ILInjected.Token(Token = "0x20000B5")]
	public abstract class XPathItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001D4")]
		public abstract XmlSchemaType XmlType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007C7")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001D5")]
		public abstract string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007C8")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001D6")]
		public abstract object TypedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007C9")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001D7")]
		public abstract Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007CA")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001D8")]
		public abstract bool ValueAsBoolean
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007CB")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001D9")]
		public abstract DateTime ValueAsDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007CC")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001DA")]
		public abstract double ValueAsDouble
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007CD")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001DB")]
		public abstract int ValueAsInt
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007CE")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001DC")]
		public abstract long ValueAsLong
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007CF")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB1A1C", Offset = "0x1DB1A1C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual object ValueAs(Type returnType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007D1")]
		public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);

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
