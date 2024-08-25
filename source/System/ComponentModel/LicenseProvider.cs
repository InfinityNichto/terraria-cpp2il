using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000396")]
	public abstract class LicenseProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x60017E7")]
		public abstract License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions);

		[global::Cpp2ILInjected.Token(Token = "0x60017E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4DC8C", Offset = "0x1E4DC8C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected LicenseProvider()
		{
			throw null;
		}
	}
}
