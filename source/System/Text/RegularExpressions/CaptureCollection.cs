using System;
using System.Diagnostics;
using System.Reflection;
using Cpp2ILInjected;

namespace System.Text.RegularExpressions
{
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Capture>))]
	[DefaultMember("Item")]
	[DebuggerDisplay("Count = {Count}")]
	[global::Cpp2ILInjected.Token(Token = "0x20000A5")]
	public class CaptureCollection
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000283")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Group _group;

		[global::Cpp2ILInjected.Token(Token = "0x4000284")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly int _capcount;

		[global::Cpp2ILInjected.Token(Token = "0x4000285")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Capture[] _captures;
	}
}
