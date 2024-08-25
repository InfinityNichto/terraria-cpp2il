using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace System.Net
{
	[Obsolete("This API is no longer supported.")]
	[global::Cpp2ILInjected.Token(Token = "0x2000271")]
	public delegate IEnumerable<string> CipherSuitesCallback(SecurityProtocolType protocol, IEnumerable<string> allCiphers);
}
