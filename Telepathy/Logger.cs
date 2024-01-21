using System;
using Cpp2IlInjected;

namespace Telepathy;

[Cpp2IlInjected.Token(Token = "0x2000259")]
public static class Logger
{
	[Cpp2IlInjected.Token(Token = "0x4001C3A")]
	public static Action<string> Log;

	[Cpp2IlInjected.Token(Token = "0x4001C3B")]
	public static Action<string> LogWarning;

	[Cpp2IlInjected.Token(Token = "0x4001C3C")]
	public static Action<string> LogError;
}
