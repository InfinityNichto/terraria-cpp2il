using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	// Token: 0x020002B6 RID: 694
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000356")]
	public class WellKnownServiceTypeEntry : TypeEntry
	{
		// Token: 0x06001A5E RID: 6750 RVA: 0x00018F26 File Offset: 0x00017126
		[global::Cpp2ILInjected.Token(Token = "0x6001C83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B33228", Offset = "0x1B33228", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadServiceWellKnown", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
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
		public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode)
		{
			throw null;
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001A5F RID: 6751 RVA: 0x00018F29 File Offset: 0x00017129
		[global::Cpp2ILInjected.Token(Token = "0x1700034B")]
		public WellKnownObjectMode Mode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C84")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B33358", Offset = "0x1B33358", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00018F2C File Offset: 0x0001712C
		[global::Cpp2ILInjected.Token(Token = "0x1700034C")]
		public global::System.Type ObjectType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C85")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B33360", Offset = "0x1B33360", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x00018F2F File Offset: 0x0001712F
		[global::Cpp2ILInjected.Token(Token = "0x1700034D")]
		public string ObjectUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C86")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B33368", Offset = "0x1B33368", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00018F32 File Offset: 0x00017132
		[global::Cpp2ILInjected.Token(Token = "0x6001C87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B33370", Offset = "0x1B33370", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000B93 RID: 2963
		[global::Cpp2ILInjected.Token(Token = "0x4000E77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Type obj_type;

		// Token: 0x04000B94 RID: 2964
		[global::Cpp2ILInjected.Token(Token = "0x4000E78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string obj_uri;

		// Token: 0x04000B95 RID: 2965
		[global::Cpp2ILInjected.Token(Token = "0x4000E79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private WellKnownObjectMode obj_mode;
	}
}
