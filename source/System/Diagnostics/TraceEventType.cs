using System;
using System.ComponentModel;
using Cpp2ILInjected;

namespace System.Diagnostics
{
	// Token: 0x02000075 RID: 117
	[global::Cpp2ILInjected.Token(Token = "0x20000CD")]
	public enum TraceEventType
	{
		// Token: 0x0400025A RID: 602
		[global::Cpp2ILInjected.Token(Token = "0x400039B")]
		Critical = 1,
		// Token: 0x0400025B RID: 603
		[global::Cpp2ILInjected.Token(Token = "0x400039C")]
		Error,
		// Token: 0x0400025C RID: 604
		[global::Cpp2ILInjected.Token(Token = "0x400039D")]
		Warning = 4,
		// Token: 0x0400025D RID: 605
		[global::Cpp2ILInjected.Token(Token = "0x400039E")]
		Information = 8,
		// Token: 0x0400025E RID: 606
		[global::Cpp2ILInjected.Token(Token = "0x400039F")]
		Verbose = 16,
		// Token: 0x0400025F RID: 607
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x40003A0")]
		Start = 256,
		// Token: 0x04000260 RID: 608
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x40003A1")]
		Stop = 512,
		// Token: 0x04000261 RID: 609
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x40003A2")]
		Suspend = 1024,
		// Token: 0x04000262 RID: 610
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x40003A3")]
		Resume = 2048,
		// Token: 0x04000263 RID: 611
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x40003A4")]
		Transfer = 4096
	}
}
