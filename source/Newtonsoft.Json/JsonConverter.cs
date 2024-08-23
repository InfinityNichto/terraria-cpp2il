using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200002E RID: 46
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200002F")]
	public abstract class JsonConverter
	{
		// Token: 0x06000157 RID: 343
		[global::Cpp2ILInjected.Token(Token = "0x6000159")]
		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

		// Token: 0x06000158 RID: 344
		[global::Cpp2ILInjected.Token(Token = "0x600015A")]
		public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

		// Token: 0x06000159 RID: 345
		[global::Cpp2ILInjected.Token(Token = "0x600015B")]
		public abstract bool CanConvert(Type objectType);

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000024B3 File Offset: 0x000006B3
		[global::Cpp2ILInjected.Token(Token = "0x17000053")]
		public virtual bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x600015C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1F00", Offset = "0x1CC1F00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000024B6 File Offset: 0x000006B6
		[global::Cpp2ILInjected.Token(Token = "0x17000054")]
		public virtual bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600015D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1F08", Offset = "0x1CC1F08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000024B9 File Offset: 0x000006B9
		[global::Cpp2ILInjected.Token(Token = "0x600015E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1F10", Offset = "0x1CC1F10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected JsonConverter()
		{
			throw null;
		}
	}
}
