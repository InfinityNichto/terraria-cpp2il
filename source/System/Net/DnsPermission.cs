using System;
using System.Security;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200045F")]
	[Serializable]
	public sealed class DnsPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97C5C", Offset = "0x1E97C5C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DnsPermission(PermissionState state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97C94", Offset = "0x1E97C94", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IPermission Copy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97CCC", Offset = "0x1E97CCC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void FromXml(SecurityElement securityElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97D04", Offset = "0x1E97D04", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IPermission Intersect(IPermission target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97D3C", Offset = "0x1E97D3C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsSubsetOf(IPermission target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97D74", Offset = "0x1E97D74", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool IsUnrestricted()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97DAC", Offset = "0x1E97DAC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override SecurityElement ToXml()
		{
			throw null;
		}
	}
}
