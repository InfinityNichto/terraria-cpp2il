using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	// Token: 0x0200029B RID: 667
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000339")]
	public class ActivatedServiceTypeEntry : TypeEntry
	{
		// Token: 0x06001993 RID: 6547 RVA: 0x00018CE0 File Offset: 0x00016EE0
		[global::Cpp2ILInjected.Token(Token = "0x6001BB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24BF0", Offset = "0x1B24BF0", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadServiceActivated", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
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
		public ActivatedServiceTypeEntry(string typeName, string assemblyName)
		{
			throw null;
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x00018CE3 File Offset: 0x00016EE3
		[global::Cpp2ILInjected.Token(Token = "0x17000326")]
		public global::System.Type ObjectType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B24D08", Offset = "0x1B24D08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00018CE6 File Offset: 0x00016EE6
		[global::Cpp2ILInjected.Token(Token = "0x6001BB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24D10", Offset = "0x1B24D10", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000B3B RID: 2875
		[global::Cpp2ILInjected.Token(Token = "0x4000E1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Type obj_type;
	}
}
