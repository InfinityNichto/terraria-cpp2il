using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000147")]
	internal class ResponseDescription
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001A3")]
		internal bool PositiveIntermediate
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECD70", Offset = "0x1EECD70", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001A4")]
		internal bool PositiveCompletion
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECD84", Offset = "0x1EECD84", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001A5")]
		internal bool TransientFailure
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECD98", Offset = "0x1EECD98", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001A6")]
		internal bool PermanentFailure
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECDAC", Offset = "0x1EECDAC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001A7")]
		internal bool InvalidStatusCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECDC0", Offset = "0x1EECDC0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EECDD4", Offset = "0x1EECDD4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReceiveState), Member = ".ctor", MemberParameters = new object[] { typeof(CommandStream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ResponseDescription()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400066C")]
		internal const int NoStatus = -1;

		[global::Cpp2ILInjected.Token(Token = "0x400066D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal bool Multiline;

		[global::Cpp2ILInjected.Token(Token = "0x400066E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int Status;

		[global::Cpp2ILInjected.Token(Token = "0x400066F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string StatusDescription;

		[global::Cpp2ILInjected.Token(Token = "0x4000670")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal StringBuilder StatusBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x4000671")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string StatusCodeString;
	}
}
