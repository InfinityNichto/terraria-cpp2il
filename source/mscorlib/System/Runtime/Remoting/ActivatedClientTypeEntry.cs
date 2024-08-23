using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	// Token: 0x0200029A RID: 666
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000338")]
	public class ActivatedClientTypeEntry : TypeEntry
	{
		// Token: 0x0600198E RID: 6542 RVA: 0x00018CD1 File Offset: 0x00016ED1
		[global::Cpp2ILInjected.Token(Token = "0x6001BB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24A94", Offset = "0x1B24A94", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadClientActivated", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeEntry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl)
		{
			throw null;
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x00018CD4 File Offset: 0x00016ED4
		[global::Cpp2ILInjected.Token(Token = "0x17000323")]
		public string ApplicationUrl
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24BC4", Offset = "0x1B24BC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x00018CD7 File Offset: 0x00016ED7
		[global::Cpp2ILInjected.Token(Token = "0x17000324")]
		public global::System.Runtime.Remoting.Contexts.IContextAttribute[] ContextAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24BCC", Offset = "0x1B24BCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x00018CDA File Offset: 0x00016EDA
		[global::Cpp2ILInjected.Token(Token = "0x17000325")]
		public global::System.Type ObjectType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24BD4", Offset = "0x1B24BD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00018CDD File Offset: 0x00016EDD
		[global::Cpp2ILInjected.Token(Token = "0x6001BB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24BDC", Offset = "0x1B24BDC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000B39 RID: 2873
		[global::Cpp2ILInjected.Token(Token = "0x4000E19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string applicationUrl;

		// Token: 0x04000B3A RID: 2874
		[global::Cpp2ILInjected.Token(Token = "0x4000E1A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Type obj_type;
	}
}
