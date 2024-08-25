using System;
using System.ComponentModel.Design;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000394")]
	public class LicenseContext : IServiceProvider
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60017CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4DD04", Offset = "0x1E4DD04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4DD0C", Offset = "0x1E4DD0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual object GetService(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4DD14", Offset = "0x1E4DD14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void SetSavedLicenseKey(Type type, string key)
		{
			throw null;
		}

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
