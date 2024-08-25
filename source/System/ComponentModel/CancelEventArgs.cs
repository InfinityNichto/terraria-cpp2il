using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003C8")]
	public class CancelEventArgs : EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x170005DC")]
		public bool Cancel
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60019BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E602A0", Offset = "0x1E602A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60019BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E602A8", Offset = "0x1E602A8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E602B4", Offset = "0x1E602B4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DoWorkEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CancelEventArgs()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6030C", Offset = "0x1E6030C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CancelEventArgs(bool cancel)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <Cancel>k__BackingField;
	}
}
