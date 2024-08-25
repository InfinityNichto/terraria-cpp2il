using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[DefaultMember("Item")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000039")]
	public abstract class XmlReader : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700004E")]
		public virtual XmlReaderSettings Settings
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67D8C", Offset = "0x1D67D8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
		public abstract XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FE")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000050")]
		public virtual string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67D94", Offset = "0x1D67D94", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000051")]
		public abstract string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000200")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000052")]
		public abstract string NamespaceURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000201")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000053")]
		public abstract string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000202")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000054")]
		public abstract string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000203")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000055")]
		public abstract string BaseURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000204")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000056")]
		public abstract bool IsEmptyElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000205")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000057")]
		public virtual bool IsDefault
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000206")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67E6C", Offset = "0x1D67E6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000058")]
		public virtual IXmlSchemaInfo SchemaInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000207")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67E74", Offset = "0x1D67E74", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000208")]
		public abstract bool MoveToAttribute(string name);

		[global::Cpp2ILInjected.Token(Token = "0x6000209")]
		public abstract bool MoveToFirstAttribute();

		[global::Cpp2ILInjected.Token(Token = "0x600020A")]
		public abstract bool MoveToNextAttribute();

		[global::Cpp2ILInjected.Token(Token = "0x600020B")]
		public abstract bool MoveToElement();

		[global::Cpp2ILInjected.Token(Token = "0x600020C")]
		public abstract bool ReadAttributeValue();

		[global::Cpp2ILInjected.Token(Token = "0x600020D")]
		public abstract bool Read();

		[global::Cpp2ILInjected.Token(Token = "0x600020E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67EBC", Offset = "0x1D67EBC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000059")]
		public abstract ReadState ReadState
		{
			[global::Cpp2ILInjected.Token(Token = "0x600020F")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700005A")]
		public abstract XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000210")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000211")]
		public abstract string LookupNamespace(string prefix);

		[global::Cpp2ILInjected.Token(Token = "0x1700005B")]
		public virtual bool CanResolveEntity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000212")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67EC0", Offset = "0x1D67EC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000213")]
		public abstract void ResolveEntity();

		[global::Cpp2ILInjected.Token(Token = "0x6000214")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67EC8", Offset = "0x1D67EC8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000215")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67EDC", Offset = "0x1D67EDC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700005C")]
		internal virtual IDtdInfo DtdInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000216")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67F20", Offset = "0x1D67F20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000217")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67F28", Offset = "0x1D67F28", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static int CalcBufferSize(Stream input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000218")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67FA4", Offset = "0x1D67FA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextReader),
			typeof(XmlNameTable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected XmlReader()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000219")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67FAC", Offset = "0x1D67FAC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static XmlReader()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
		private static uint IsTextualNodeBitmap;

		[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
		private static uint CanReadContentAsBitmap;

		[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
		private static uint HasValueBitmap;
	}
}
