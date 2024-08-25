using System;
using System.ComponentModel;
using Cpp2ILInjected;

namespace System.Diagnostics
{
	[global::Cpp2ILInjected.Token(Token = "0x20000CD")]
	public enum TraceEventType
	{
		[global::Cpp2ILInjected.Token(Token = "0x400039B")]
		Critical = 1,
		[global::Cpp2ILInjected.Token(Token = "0x400039C")]
		Error,
		[global::Cpp2ILInjected.Token(Token = "0x400039D")]
		Warning = 4,
		[global::Cpp2ILInjected.Token(Token = "0x400039E")]
		Information = 8,
		[global::Cpp2ILInjected.Token(Token = "0x400039F")]
		Verbose = 16,
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x40003A0")]
		Start = 256,
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x40003A1")]
		Stop = 512,
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x40003A2")]
		Suspend = 1024,
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x40003A3")]
		Resume = 2048,
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x40003A4")]
		Transfer = 4096
	}
}
