using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200006E RID: 110
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000087")]
	public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
	{
		// Token: 0x0600048A RID: 1162 RVA: 0x00002DFE File Offset: 0x00000FFE
		[global::Cpp2ILInjected.Token(Token = "0x60004CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3C18", Offset = "0x1CE3C18", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CamelCasePropertyNamesContractResolver()
		{
			throw null;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002E01 File Offset: 0x00001001
		[global::Cpp2ILInjected.Token(Token = "0x60004CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3C9C", Offset = "0x1CE3C9C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "ToCamelCase", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		protected override string ResolvePropertyName(string propertyName)
		{
			throw null;
		}
	}
}
