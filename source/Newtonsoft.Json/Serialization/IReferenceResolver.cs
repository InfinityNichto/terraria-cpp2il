using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000080 RID: 128
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000A4")]
	public interface IReferenceResolver
	{
		// Token: 0x0600057D RID: 1405
		[global::Cpp2ILInjected.Token(Token = "0x60005E3")]
		object ResolveReference(object context, string reference);

		// Token: 0x0600057E RID: 1406
		[global::Cpp2ILInjected.Token(Token = "0x60005E4")]
		string GetReference(object context, object value);

		// Token: 0x0600057F RID: 1407
		[global::Cpp2ILInjected.Token(Token = "0x60005E5")]
		bool IsReferenced(object context, object value);

		// Token: 0x06000580 RID: 1408
		[global::Cpp2ILInjected.Token(Token = "0x60005E6")]
		void AddReference(object context, string reference, object value);
	}
}
