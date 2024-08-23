using System;
using System.ComponentModel.Design;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200029C RID: 668
	[global::Cpp2ILInjected.Token(Token = "0x2000394")]
	public class LicenseContext : IServiceProvider
	{
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x00006ABB File Offset: 0x00004CBB
		[global::Cpp2ILInjected.Token(Token = "0x1700056E")]
		public virtual LicenseUsageMode UsageMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4DCFC", Offset = "0x1E4DCFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00006ABE File Offset: 0x00004CBE
		[global::Cpp2ILInjected.Token(Token = "0x60017CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4DD04", Offset = "0x1E4DD04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
		{
			throw null;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00006AC1 File Offset: 0x00004CC1
		[global::Cpp2ILInjected.Token(Token = "0x60017D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4DD0C", Offset = "0x1E4DD0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual object GetService(Type type)
		{
			throw null;
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00006AC4 File Offset: 0x00004CC4
		[global::Cpp2ILInjected.Token(Token = "0x60017D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4DD14", Offset = "0x1E4DD14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void SetSavedLicenseKey(Type type, string key)
		{
			throw null;
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00006AC7 File Offset: 0x00004CC7
		[global::Cpp2ILInjected.Token(Token = "0x60017D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4DD18", Offset = "0x1E4DD18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeLicenseContext), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LicenseContext()
		{
			throw null;
		}
	}
}
