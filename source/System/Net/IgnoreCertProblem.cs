using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001AD")]
	internal enum IgnoreCertProblem
	{
		[global::Cpp2ILInjected.Token(Token = "0x40008CA")]
		not_time_valid = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40008CB")]
		ctl_not_time_valid,
		[global::Cpp2ILInjected.Token(Token = "0x40008CC")]
		not_time_nested = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40008CD")]
		invalid_basic_constraints = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40008CE")]
		all_not_time_valid = 7,
		[global::Cpp2ILInjected.Token(Token = "0x40008CF")]
		allow_unknown_ca = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40008D0")]
		wrong_usage = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40008D1")]
		invalid_name = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40008D2")]
		invalid_policy = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40008D3")]
		end_rev_unknown = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40008D4")]
		ctl_signer_rev_unknown = 512,
		[global::Cpp2ILInjected.Token(Token = "0x40008D5")]
		ca_rev_unknown = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x40008D6")]
		root_rev_unknown = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x40008D7")]
		all_rev_unknown = 3840,
		[global::Cpp2ILInjected.Token(Token = "0x40008D8")]
		none = 4095
	}
}
