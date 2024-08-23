using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000176 RID: 374
	[global::System.Diagnostics.DebuggerDisplay("Initial Count={InitialCount}, Current Count={CurrentCount}")]
	[global::Cpp2ILInjected.Token(Token = "0x20001C8")]
	public class CountdownEvent
	{
		// Token: 0x06000F9A RID: 3994 RVA: 0x00017123 File Offset: 0x00015323
		[global::Cpp2ILInjected.Token(Token = "0x60010CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C944F4", Offset = "0x1C944F4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.FastParallel.RangeTask", Member = "Invoke", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CountdownEvent), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEventSlim), Member = "Set", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool Signal()
		{
			throw null;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00017126 File Offset: 0x00015326
		[global::Cpp2ILInjected.Token(Token = "0x60010CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9459C", Offset = "0x1C9459C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CountdownEvent), Member = "Signal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ThrowIfDisposed()
		{
			throw null;
		}

		// Token: 0x04000715 RID: 1813
		[global::Cpp2ILInjected.Token(Token = "0x4000915")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _currentCount;

		// Token: 0x04000716 RID: 1814
		[global::Cpp2ILInjected.Token(Token = "0x4000916")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ManualResetEventSlim _event;

		// Token: 0x04000717 RID: 1815
		[global::Cpp2ILInjected.Token(Token = "0x4000917")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _disposed;
	}
}
