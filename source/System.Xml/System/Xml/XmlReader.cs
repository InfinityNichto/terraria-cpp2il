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
	// Token: 0x02000036 RID: 54
	[DefaultMember("Item")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000039")]
	public abstract class XmlReader : IDisposable
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00003518 File Offset: 0x00001718
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

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001F1 RID: 497
		[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
		public abstract XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FE")]
			get;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000351B File Offset: 0x0000171B
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001F3 RID: 499
		[global::Cpp2ILInjected.Token(Token = "0x17000051")]
		public abstract string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000200")]
			get;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001F4 RID: 500
		[global::Cpp2ILInjected.Token(Token = "0x17000052")]
		public abstract string NamespaceURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000201")]
			get;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001F5 RID: 501
		[global::Cpp2ILInjected.Token(Token = "0x17000053")]
		public abstract string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000202")]
			get;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001F6 RID: 502
		[global::Cpp2ILInjected.Token(Token = "0x17000054")]
		public abstract string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000203")]
			get;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001F7 RID: 503
		[global::Cpp2ILInjected.Token(Token = "0x17000055")]
		public abstract string BaseURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000204")]
			get;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001F8 RID: 504
		[global::Cpp2ILInjected.Token(Token = "0x17000056")]
		public abstract bool IsEmptyElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000205")]
			get;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000351E File Offset: 0x0000171E
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

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00003521 File Offset: 0x00001721
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

		// Token: 0x060001FB RID: 507
		[global::Cpp2ILInjected.Token(Token = "0x6000208")]
		public abstract bool MoveToAttribute(string name);

		// Token: 0x060001FC RID: 508
		[global::Cpp2ILInjected.Token(Token = "0x6000209")]
		public abstract bool MoveToFirstAttribute();

		// Token: 0x060001FD RID: 509
		[global::Cpp2ILInjected.Token(Token = "0x600020A")]
		public abstract bool MoveToNextAttribute();

		// Token: 0x060001FE RID: 510
		[global::Cpp2ILInjected.Token(Token = "0x600020B")]
		public abstract bool MoveToElement();

		// Token: 0x060001FF RID: 511
		[global::Cpp2ILInjected.Token(Token = "0x600020C")]
		public abstract bool ReadAttributeValue();

		// Token: 0x06000200 RID: 512
		[global::Cpp2ILInjected.Token(Token = "0x600020D")]
		public abstract bool Read();

		// Token: 0x06000201 RID: 513 RVA: 0x00003524 File Offset: 0x00001724
		[global::Cpp2ILInjected.Token(Token = "0x600020E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67EBC", Offset = "0x1D67EBC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Close()
		{
			throw null;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000202 RID: 514
		[global::Cpp2ILInjected.Token(Token = "0x17000059")]
		public abstract ReadState ReadState
		{
			[global::Cpp2ILInjected.Token(Token = "0x600020F")]
			get;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000203 RID: 515
		[global::Cpp2ILInjected.Token(Token = "0x1700005A")]
		public abstract XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000210")]
			get;
		}

		// Token: 0x06000204 RID: 516
		[global::Cpp2ILInjected.Token(Token = "0x6000211")]
		public abstract string LookupNamespace(string prefix);

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00003527 File Offset: 0x00001727
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

		// Token: 0x06000206 RID: 518
		[global::Cpp2ILInjected.Token(Token = "0x6000213")]
		public abstract void ResolveEntity();

		// Token: 0x06000207 RID: 519 RVA: 0x0000352A File Offset: 0x0000172A
		[global::Cpp2ILInjected.Token(Token = "0x6000214")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67EC8", Offset = "0x1D67EC8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000352D File Offset: 0x0000172D
		[global::Cpp2ILInjected.Token(Token = "0x6000215")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67EDC", Offset = "0x1D67EDC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00003530 File Offset: 0x00001730
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

		// Token: 0x0600020A RID: 522 RVA: 0x00003533 File Offset: 0x00001733
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

		// Token: 0x0600020B RID: 523 RVA: 0x00003536 File Offset: 0x00001736
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

		// Token: 0x0600020C RID: 524 RVA: 0x00003539 File Offset: 0x00001739
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

		// Token: 0x040000BF RID: 191
		[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
		private static uint IsTextualNodeBitmap;

		// Token: 0x040000C0 RID: 192
		[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
		private static uint CanReadContentAsBitmap;

		// Token: 0x040000C1 RID: 193
		[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
		private static uint HasValueBitmap;
	}
}
