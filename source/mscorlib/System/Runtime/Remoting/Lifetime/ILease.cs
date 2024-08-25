using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Lifetime
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200035D")]
	public interface ILease
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000352")]
		global::System.TimeSpan CurrentLeaseTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CB4")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000353")]
		LeaseState CurrentState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CB5")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000354")]
		global::System.TimeSpan RenewOnCallTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CB6")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CB7")]
		global::System.TimeSpan Renew(global::System.TimeSpan renewalTime);
	}
}
