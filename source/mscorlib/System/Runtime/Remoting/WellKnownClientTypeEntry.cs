using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000354")]
	public class WellKnownClientTypeEntry : TypeEntry
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000E71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Type obj_type;

		[global::Cpp2ILInjected.Token(Token = "0x4000E72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string obj_url;

		[global::Cpp2ILInjected.Token(Token = "0x4000E73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string app_url;
	}
}
