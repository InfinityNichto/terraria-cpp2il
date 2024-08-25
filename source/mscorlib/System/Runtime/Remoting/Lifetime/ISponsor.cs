using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Lifetime
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200035E")]
	public interface ISponsor
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001CB8")]
		global::System.TimeSpan Renewal(ILease lease);
	}
}
