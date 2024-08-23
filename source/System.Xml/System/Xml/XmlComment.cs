using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200004B RID: 75
	[global::Cpp2ILInjected.Token(Token = "0x2000068")]
	public class XmlComment : XmlCharacterData
	{
		// Token: 0x06000435 RID: 1077 RVA: 0x00003B6C File Offset: 0x00001D6C
		[global::Cpp2ILInjected.Token(Token = "0x60004AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D6FC", Offset = "0x1D8D6FC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLinkedNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		protected internal XmlComment(string comment, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00003B6F File Offset: 0x00001D6F
		[global::Cpp2ILInjected.Token(Token = "0x17000101")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D728", Offset = "0x1D8D728", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00003B72 File Offset: 0x00001D72
		[global::Cpp2ILInjected.Token(Token = "0x17000102")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D748", Offset = "0x1D8D748", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00003B75 File Offset: 0x00001D75
		[global::Cpp2ILInjected.Token(Token = "0x17000103")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D768", Offset = "0x1D8D768", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00003B78 File Offset: 0x00001D78
		[global::Cpp2ILInjected.Token(Token = "0x60004B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D770", Offset = "0x1D8D770", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}
	}
}
