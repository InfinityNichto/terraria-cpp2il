using System;
using System.Diagnostics;
using System.Reflection;
using Cpp2ILInjected;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000054 RID: 84
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Capture>))]
	[DefaultMember("Item")]
	[DebuggerDisplay("Count = {Count}")]
	[global::Cpp2ILInjected.Token(Token = "0x20000A5")]
	public class CaptureCollection
	{
		// Token: 0x0400015A RID: 346
		[global::Cpp2ILInjected.Token(Token = "0x4000283")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Group _group;

		// Token: 0x0400015B RID: 347
		[global::Cpp2ILInjected.Token(Token = "0x4000284")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly int _capcount;

		// Token: 0x0400015C RID: 348
		[global::Cpp2ILInjected.Token(Token = "0x4000285")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Capture[] _captures;
	}
}
