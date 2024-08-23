using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200005B RID: 91
	[global::Cpp2ILInjected.Token(Token = "0x200007A")]
	public class XmlNodeChangedEventArgs : EventArgs
	{
		// Token: 0x06000574 RID: 1396 RVA: 0x00003F1D File Offset: 0x0000211D
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

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00003F20 File Offset: 0x00002120
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

		// Token: 0x040001F6 RID: 502
		[global::Cpp2ILInjected.Token(Token = "0x40002F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlNodeChangedAction action;

		// Token: 0x040001F7 RID: 503
		[global::Cpp2ILInjected.Token(Token = "0x40002F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlNode node;

		// Token: 0x040001F8 RID: 504
		[global::Cpp2ILInjected.Token(Token = "0x40002F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlNode oldParent;

		// Token: 0x040001F9 RID: 505
		[global::Cpp2ILInjected.Token(Token = "0x40002F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlNode newParent;

		// Token: 0x040001FA RID: 506
		[global::Cpp2ILInjected.Token(Token = "0x40002F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string oldValue;

		// Token: 0x040001FB RID: 507
		[global::Cpp2ILInjected.Token(Token = "0x40002F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string newValue;
	}
}
