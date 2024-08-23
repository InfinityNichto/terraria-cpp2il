using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x02000016 RID: 22
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	public class XProcessingInstruction : XNode
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00002233 File Offset: 0x00000433
		[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6EF74", Offset = "0x1D6EF74", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XProcessingInstruction), Member = "ValidateName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public XProcessingInstruction(string target, string data)
		{
			throw null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002236 File Offset: 0x00000436
		[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F0CC", Offset = "0x1D6F0CC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XProcessingInstruction), Member = "CloneNode", ReturnType = typeof(XNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public XProcessingInstruction(XProcessingInstruction other)
		{
			throw null;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002239 File Offset: 0x00000439
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000223C File Offset: 0x0000043C
		[global::Cpp2ILInjected.Token(Token = "0x17000025")]
		public string Data
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6F144", Offset = "0x1D6F144", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6F14C", Offset = "0x1D6F14C", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XProcessingInstructionWrapper", Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "NotifyChanging", MemberParameters = new object[]
			{
				typeof(object),
				typeof(XObjectChangeEventArgs)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "NotifyChanged", MemberParameters = new object[]
			{
				typeof(object),
				typeof(XObjectChangeEventArgs)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000223F File Offset: 0x0000043F
		[global::Cpp2ILInjected.Token(Token = "0x17000026")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6F23C", Offset = "0x1D6F23C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00002242 File Offset: 0x00000442
		[global::Cpp2ILInjected.Token(Token = "0x17000027")]
		public string Target
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6F244", Offset = "0x1D6F244", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002245 File Offset: 0x00000445
		[global::Cpp2ILInjected.Token(Token = "0x60000C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F24C", Offset = "0x1D6F24C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void WriteTo(XmlWriter writer)
		{
			throw null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002248 File Offset: 0x00000448
		[global::Cpp2ILInjected.Token(Token = "0x60000C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F2BC", Offset = "0x1D6F2BC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XProcessingInstruction), Member = ".ctor", MemberParameters = new object[] { typeof(XProcessingInstruction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override XNode CloneNode()
		{
			throw null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000224B File Offset: 0x0000044B
		[global::Cpp2ILInjected.Token(Token = "0x60000C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6EFF4", Offset = "0x1D6EFF4", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XProcessingInstruction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "VerifyNCName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void ValidateName(string name)
		{
			throw null;
		}

		// Token: 0x04000033 RID: 51
		[global::Cpp2ILInjected.Token(Token = "0x400004A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string target;

		// Token: 0x04000034 RID: 52
		[global::Cpp2ILInjected.Token(Token = "0x400004B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string data;
	}
}
