using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020000DC RID: 220
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000125")]
	internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable
	{
		// Token: 0x06000A31 RID: 2609 RVA: 0x00003E0F File Offset: 0x0000200F
		[global::Cpp2ILInjected.Token(Token = "0x6000B6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A3F4", Offset = "0x1D3A3F4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Add(BsonToken token)
		{
			throw null;
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00003E12 File Offset: 0x00002012
		[global::Cpp2ILInjected.Token(Token = "0x17000234")]
		public override BsonType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A498", Offset = "0x1D3A498", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00003E15 File Offset: 0x00002015
		[global::Cpp2ILInjected.Token(Token = "0x6000B70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D38434", Offset = "0x1D38434", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "CalculateSize", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonArray), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IEnumerator<BsonToken> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00003E18 File Offset: 0x00002018
		[global::Cpp2ILInjected.Token(Token = "0x6000B71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A4A0", Offset = "0x1D3A4A0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonArray), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<BsonToken>))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00003E1B File Offset: 0x0000201B
		[global::Cpp2ILInjected.Token(Token = "0x6000B72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A4A4", Offset = "0x1D3A4A4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public BsonArray()
		{
			throw null;
		}

		// Token: 0x04000328 RID: 808
		[global::Cpp2ILInjected.Token(Token = "0x400044F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly List<BsonToken> _children;
	}
}
