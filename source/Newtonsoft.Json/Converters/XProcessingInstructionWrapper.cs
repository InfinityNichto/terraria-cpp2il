using System;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	[global::Cpp2ILInjected.Token(Token = "0x2000118")]
	internal class XProcessingInstructionWrapper : XObjectWrapper
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000210")]
		private XProcessingInstruction ProcessingInstruction
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E09C", Offset = "0x1D2E09C", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XProcessingInstructionWrapper), Member = "get_LocalName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XProcessingInstructionWrapper), Member = "get_Value", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XProcessingInstructionWrapper), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2D40C", Offset = "0x1D2D40C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "CreateProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XObject) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000211")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E114", Offset = "0x1D2E114", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XProcessingInstructionWrapper), Member = "get_ProcessingInstruction", ReturnType = typeof(XProcessingInstruction))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000212")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E128", Offset = "0x1D2E128", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XProcessingInstructionWrapper), Member = "get_ProcessingInstruction", ReturnType = typeof(XProcessingInstruction))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000AEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2E13C", Offset = "0x1D2E13C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XProcessingInstructionWrapper), Member = "get_ProcessingInstruction", ReturnType = typeof(XProcessingInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XProcessingInstruction), Member = "set_Data", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}
	}
}
