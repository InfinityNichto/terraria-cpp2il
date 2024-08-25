using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x2000080")]
	public class XmlText : XmlCharacterData
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000619")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D94AF0", Offset = "0x1D94AF0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharacterData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		internal XmlText(string strData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600061A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D94AE8", Offset = "0x1D94AE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateTextNode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlText))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharacterData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		protected internal XmlText(string strData, XmlDocument doc)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700019F")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600061B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A9FC", Offset = "0x1D9A9FC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001A0")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600061C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9AA1C", Offset = "0x1D9AA1C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001A1")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600061D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9AA3C", Offset = "0x1D9AA3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001A2")]
		public override XmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600061E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9AA44", Offset = "0x1D9AA44", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600061F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9AAB8", Offset = "0x1D9AAB8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001A3")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000620")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9AB0C", Offset = "0x1D9AB0C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000621")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9AB1C", Offset = "0x1D9AB1C", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001A4")]
		internal override bool IsText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000622")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9ABE8", Offset = "0x1D9ABE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
