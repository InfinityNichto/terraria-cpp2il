using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200013F RID: 319
	[global::Cpp2ILInjected.Token(Token = "0x2000186")]
	internal class NullConsoleDriver : global::System.IConsoleDriver
	{
		// Token: 0x06000E43 RID: 3651 RVA: 0x00016DA8 File Offset: 0x00014FA8
		[global::Cpp2ILInjected.Token(Token = "0x6000F2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82138", Offset = "0x1C82138", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00016DAB File Offset: 0x00014FAB
		[global::Cpp2ILInjected.Token(Token = "0x6000F2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8213C", Offset = "0x1C8213C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public string ReadLine()
		{
			throw null;
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00016DAE File Offset: 0x00014FAE
		[global::Cpp2ILInjected.Token(Token = "0x6000F30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82144", Offset = "0x1C82144", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.ConsoleKeyInfo ReadKey(bool intercept)
		{
			throw null;
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00016DB1 File Offset: 0x00014FB1
		[global::Cpp2ILInjected.Token(Token = "0x6000F31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B870", Offset = "0x1C7B870", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public NullConsoleDriver()
		{
			throw null;
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00016DB4 File Offset: 0x00014FB4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000F32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C821A0", Offset = "0x1C821A0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleKeyInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(global::System.ConsoleKey),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static NullConsoleDriver()
		{
			throw null;
		}

		// Token: 0x040004BA RID: 1210
		[global::Cpp2ILInjected.Token(Token = "0x400068B")]
		private static readonly global::System.ConsoleKeyInfo EmptyConsoleKeyInfo;
	}
}
