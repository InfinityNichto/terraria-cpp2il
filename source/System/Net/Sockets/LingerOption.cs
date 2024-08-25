using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Sockets
{
	[global::Cpp2ILInjected.Token(Token = "0x20002FA")]
	public class LingerOption
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001409")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E32A40", Offset = "0x1E32A40", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Linger", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LingerOption(bool enable, int seconds)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000489")]
		public bool Enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x600140A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32A74", Offset = "0x1E32A74", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700048A")]
		public int LingerTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600140B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32A80", Offset = "0x1E32A80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x400102A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool enabled;

		[global::Cpp2ILInjected.Token(Token = "0x400102B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int lingerTime;
	}
}
