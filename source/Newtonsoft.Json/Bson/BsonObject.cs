using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020000DB RID: 219
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000124")]
	internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable
	{
		// Token: 0x06000A2C RID: 2604 RVA: 0x00003E00 File Offset: 0x00002000
		[global::Cpp2ILInjected.Token(Token = "0x6000B69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A210", Offset = "0x1D3A210", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Add(string name, BsonToken token)
		{
			throw null;
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00003E03 File Offset: 0x00002003
		[global::Cpp2ILInjected.Token(Token = "0x17000233")]
		public override BsonType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A36C", Offset = "0x1D3A36C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00003E06 File Offset: 0x00002006
		[global::Cpp2ILInjected.Token(Token = "0x6000B6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3830C", Offset = "0x1D3830C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "CalculateSize", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonObject), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IEnumerator<BsonProperty> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00003E09 File Offset: 0x00002009
		[global::Cpp2ILInjected.Token(Token = "0x6000B6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A374", Offset = "0x1D3A374", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonObject), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<BsonProperty>))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00003E0C File Offset: 0x0000200C
		[global::Cpp2ILInjected.Token(Token = "0x6000B6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A378", Offset = "0x1D3A378", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public BsonObject()
		{
			throw null;
		}

		// Token: 0x04000327 RID: 807
		[global::Cpp2ILInjected.Token(Token = "0x400044E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly List<BsonProperty> _children;
	}
}
