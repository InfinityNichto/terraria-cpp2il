using System;
using System.Collections.Concurrent;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037D RID: 893
	[global::Cpp2ILInjected.Token(Token = "0x2000427")]
	internal sealed class NameCache
	{
		// Token: 0x06001EF4 RID: 7924 RVA: 0x00019BE3 File Offset: 0x00017DE3
		[global::Cpp2ILInjected.Token(Token = "0x6002135")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B68B3C", Offset = "0x1B68B3C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "FastBindToType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal object GetCachedValue(string name)
		{
			throw null;
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x00019BE6 File Offset: 0x00017DE6
		[global::Cpp2ILInjected.Token(Token = "0x6002136")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B68FCC", Offset = "0x1B68FCC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "FastBindToType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void SetCachedValue(object value)
		{
			throw null;
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x00019BE9 File Offset: 0x00017DE9
		[global::Cpp2ILInjected.Token(Token = "0x6002137")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B655D0", Offset = "0x1B655D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NameCache()
		{
			throw null;
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00019BEC File Offset: 0x00017DEC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002138")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6F368", Offset = "0x1B6F368", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static NameCache()
		{
			throw null;
		}

		// Token: 0x04000EBF RID: 3775
		[global::Cpp2ILInjected.Token(Token = "0x40011B4")]
		private static global::System.Collections.Concurrent.ConcurrentDictionary<string, object> ht;

		// Token: 0x04000EC0 RID: 3776
		[global::Cpp2ILInjected.Token(Token = "0x40011B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string name;
	}
}
