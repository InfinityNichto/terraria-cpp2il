using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200004D")]
	internal delegate TResult MethodCall<T, TResult>(T target, params object[] args);
}
