using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x20000D3")]
	internal class ContentValidator
	{
		[global::Cpp2ILInjected.Token(Token = "0x600084F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB64DC", Offset = "0x1DB64DC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ContentValidator(XmlSchemaContentType contentType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000850")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB650C", Offset = "0x1DB650C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000206")]
		public XmlSchemaContentType ContentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000851")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB654C", Offset = "0x1DB654C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000207")]
		public bool IsOpen
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000852")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB6554", Offset = "0x1DB6554", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000853")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB6578", Offset = "0x1DB6578", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static ContentValidator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000430")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlSchemaContentType contentType;

		[global::Cpp2ILInjected.Token(Token = "0x4000431")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool isOpen;

		[global::Cpp2ILInjected.Token(Token = "0x4000432")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
		private bool isEmptiable;

		[global::Cpp2ILInjected.Token(Token = "0x4000433")]
		public static readonly ContentValidator Empty;

		[global::Cpp2ILInjected.Token(Token = "0x4000434")]
		public static readonly ContentValidator TextOnly;

		[global::Cpp2ILInjected.Token(Token = "0x4000435")]
		public static readonly ContentValidator Mixed;

		[global::Cpp2ILInjected.Token(Token = "0x4000436")]
		public static readonly ContentValidator Any;
	}
}
