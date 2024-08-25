using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000BB")]
	public class JsonLoadSettings
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000152")]
		public CommentHandling CommentHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0440C", Offset = "0x1D0440C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D04414", Offset = "0x1D04414", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000153")]
		public LineInfoHandling LineInfoHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D04474", Offset = "0x1D04474", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0447C", Offset = "0x1D0447C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D044DC", Offset = "0x1D044DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public JsonLoadSettings()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40002F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private CommentHandling _commentHandling;

		[global::Cpp2ILInjected.Token(Token = "0x40002F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private LineInfoHandling _lineInfoHandling;
	}
}
