using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020002DF RID: 735
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000383")]
	public class SinkProviderData
	{
		// Token: 0x06001B1F RID: 6943 RVA: 0x000190FD File Offset: 0x000172FD
		[global::Cpp2ILInjected.Token(Token = "0x6001D4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B41550", Offset = "0x1B41550", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadCustomProviderData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadProvider", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(bool)
		}, ReturnType = typeof(ProviderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public SinkProviderData(string name)
		{
			throw null;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x00019100 File Offset: 0x00017300
		[global::Cpp2ILInjected.Token(Token = "0x17000375")]
		public global::System.Collections.IList Children
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D4D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B415F0", Offset = "0x1B415F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x00019103 File Offset: 0x00017303
		[global::Cpp2ILInjected.Token(Token = "0x17000376")]
		public global::System.Collections.IDictionary Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D4E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B415F8", Offset = "0x1B415F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000BDB RID: 3035
		[global::Cpp2ILInjected.Token(Token = "0x4000EC6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string sinkName;

		// Token: 0x04000BDC RID: 3036
		[global::Cpp2ILInjected.Token(Token = "0x4000EC7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Collections.ArrayList children;

		// Token: 0x04000BDD RID: 3037
		[global::Cpp2ILInjected.Token(Token = "0x4000EC8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.Hashtable properties;
	}
}
