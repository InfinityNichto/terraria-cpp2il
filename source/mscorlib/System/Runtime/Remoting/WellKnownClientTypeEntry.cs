using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	// Token: 0x020002B4 RID: 692
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000354")]
	public class WellKnownClientTypeEntry : TypeEntry
	{
		// Token: 0x06001A59 RID: 6745 RVA: 0x00018F17 File Offset: 0x00017117
		[global::Cpp2ILInjected.Token(Token = "0x6001C7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B330C8", Offset = "0x1B330C8", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadClientWellKnown", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
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
		public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl)
		{
			throw null;
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x00018F1A File Offset: 0x0001711A
		[global::Cpp2ILInjected.Token(Token = "0x17000348")]
		public string ApplicationUrl
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B331F4", Offset = "0x1B331F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x00018F1D File Offset: 0x0001711D
		[global::Cpp2ILInjected.Token(Token = "0x17000349")]
		public global::System.Type ObjectType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C80")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B331FC", Offset = "0x1B331FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x00018F20 File Offset: 0x00017120
		[global::Cpp2ILInjected.Token(Token = "0x1700034A")]
		public string ObjectUrl
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C81")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B33204", Offset = "0x1B33204", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00018F23 File Offset: 0x00017123
		[global::Cpp2ILInjected.Token(Token = "0x6001C82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3320C", Offset = "0x1B3320C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
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

		// Token: 0x04000B8D RID: 2957
		[global::Cpp2ILInjected.Token(Token = "0x4000E71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Type obj_type;

		// Token: 0x04000B8E RID: 2958
		[global::Cpp2ILInjected.Token(Token = "0x4000E72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string obj_url;

		// Token: 0x04000B8F RID: 2959
		[global::Cpp2ILInjected.Token(Token = "0x4000E73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string app_url;
	}
}
