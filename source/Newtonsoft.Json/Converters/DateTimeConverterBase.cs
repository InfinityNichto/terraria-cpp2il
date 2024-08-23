using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000B3 RID: 179
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000F9")]
	public abstract class DateTimeConverterBase : JsonConverter
	{
		// Token: 0x060008DB RID: 2267 RVA: 0x00003A79 File Offset: 0x00001C79
		[global::Cpp2ILInjected.Token(Token = "0x6000A10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D25B3C", Offset = "0x1D25B3C", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00003A7C File Offset: 0x00001C7C
		[global::Cpp2ILInjected.Token(Token = "0x6000A11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D25C7C", Offset = "0x1D25C7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		protected DateTimeConverterBase()
		{
			throw null;
		}
	}
}
