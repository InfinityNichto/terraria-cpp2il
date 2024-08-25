using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000356")]
	public class WellKnownServiceTypeEntry : TypeEntry
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001C87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B33370", Offset = "0x1B33370", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Type obj_type;

		[global::Cpp2ILInjected.Token(Token = "0x4000E78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string obj_uri;

		[global::Cpp2ILInjected.Token(Token = "0x4000E79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private WellKnownObjectMode obj_mode;
	}
}
