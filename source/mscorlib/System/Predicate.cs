using System;
using Cpp2ILInjected;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000080")]
	public delegate bool Predicate<in T>(T obj);
}
