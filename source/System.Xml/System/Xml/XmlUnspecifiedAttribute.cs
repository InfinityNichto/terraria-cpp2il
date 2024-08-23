using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000062 RID: 98
	[global::Cpp2ILInjected.Token(Token = "0x2000081")]
	internal class XmlUnspecifiedAttribute : XmlAttribute
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x00003F98 File Offset: 0x00002198
		[global::Cpp2ILInjected.Token(Token = "0x6000623")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D95E7C", Offset = "0x1D95E7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateDefaultAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		protected internal XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00003F9B File Offset: 0x0000219B
		[global::Cpp2ILInjected.Token(Token = "0x170001A5")]
		public override bool Specified
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000624")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9ABF0", Offset = "0x1D9ABF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00003F9E File Offset: 0x0000219E
		[global::Cpp2ILInjected.Token(Token = "0x6000625")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9ABF8", Offset = "0x1D9ABF8", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x17000182 RID: 386
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00003FA1 File Offset: 0x000021A1
		[global::Cpp2ILInjected.Token(Token = "0x170001A6")]
		public override string InnerText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000626")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9AD1C", Offset = "0x1D9AD1C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00003FA4 File Offset: 0x000021A4
		[global::Cpp2ILInjected.Token(Token = "0x6000627")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9AD3C", Offset = "0x1D9AD3C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = "RemoveChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		public override XmlNode RemoveChild(XmlNode oldChild)
		{
			throw null;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00003FA7 File Offset: 0x000021A7
		[global::Cpp2ILInjected.Token(Token = "0x6000628")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9AD5C", Offset = "0x1D9AD5C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = "AppendChild", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlNode))]
		public override XmlNode AppendChild(XmlNode newChild)
		{
			throw null;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00003FAA File Offset: 0x000021AA
		[global::Cpp2ILInjected.Token(Token = "0x6000629")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9AD7C", Offset = "0x1D9AD7C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetSpecified(bool f)
		{
			throw null;
		}

		// Token: 0x04000201 RID: 513
		[global::Cpp2ILInjected.Token(Token = "0x40002FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool fSpecified;
	}
}
