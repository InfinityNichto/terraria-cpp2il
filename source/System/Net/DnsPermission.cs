using System;
using System.Security;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200032B RID: 811
	[global::Cpp2ILInjected.Token(Token = "0x200045F")]
	[Serializable]
	public sealed class DnsPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		// Token: 0x06001B02 RID: 6914 RVA: 0x00007A3C File Offset: 0x00005C3C
		[global::Cpp2ILInjected.Token(Token = "0x6001E5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97C5C", Offset = "0x1E97C5C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DnsPermission(PermissionState state)
		{
			throw null;
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00007A3F File Offset: 0x00005C3F
		[global::Cpp2ILInjected.Token(Token = "0x6001E5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97C94", Offset = "0x1E97C94", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IPermission Copy()
		{
			throw null;
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00007A42 File Offset: 0x00005C42
		[global::Cpp2ILInjected.Token(Token = "0x6001E5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97CCC", Offset = "0x1E97CCC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void FromXml(SecurityElement securityElement)
		{
			throw null;
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00007A45 File Offset: 0x00005C45
		[global::Cpp2ILInjected.Token(Token = "0x6001E5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97D04", Offset = "0x1E97D04", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IPermission Intersect(IPermission target)
		{
			throw null;
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00007A48 File Offset: 0x00005C48
		[global::Cpp2ILInjected.Token(Token = "0x6001E5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97D3C", Offset = "0x1E97D3C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsSubsetOf(IPermission target)
		{
			throw null;
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00007A4B File Offset: 0x00005C4B
		[global::Cpp2ILInjected.Token(Token = "0x6001E60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97D74", Offset = "0x1E97D74", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool IsUnrestricted()
		{
			throw null;
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00007A4E File Offset: 0x00005C4E
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
