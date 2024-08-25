using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x200007A")]
	public class XmlNodeChangedEventArgs : EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A424", Offset = "0x1D9A424", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "GetEventArgs", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode),
			typeof(XmlNode),
			typeof(string),
			typeof(string),
			typeof(XmlNodeChangedAction)
		}, ReturnType = typeof(XmlNodeChangedEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode)
		}, ReturnType = typeof(XmlNodeChangedEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700018C")]
		public XmlNodeChangedAction Action
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9A4C0", Offset = "0x1D9A4C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40002F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlNodeChangedAction action;

		[global::Cpp2ILInjected.Token(Token = "0x40002F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlNode node;

		[global::Cpp2ILInjected.Token(Token = "0x40002F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlNode oldParent;

		[global::Cpp2ILInjected.Token(Token = "0x40002F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlNode newParent;

		[global::Cpp2ILInjected.Token(Token = "0x40002F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string oldValue;

		[global::Cpp2ILInjected.Token(Token = "0x40002F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string newValue;
	}
}
