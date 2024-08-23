using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000100 RID: 256
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::Cpp2ILInjected.Token(Token = "0x2000184")]
	public class WriteStreamClosedEventArgs : EventArgs
	{
		// Token: 0x06000900 RID: 2304 RVA: 0x000047CF File Offset: 0x000029CF
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x6000A0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08968", Offset = "0x1F08968", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WriteStreamClosedEventArgs()
		{
			throw null;
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x000047D2 File Offset: 0x000029D2
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x17000206")]
		public Exception Error
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A0C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F089C0", Offset = "0x1F089C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
