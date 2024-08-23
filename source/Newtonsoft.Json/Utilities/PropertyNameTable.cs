using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200003F RID: 63
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000042")]
	internal class PropertyNameTable
	{
		// Token: 0x060002BD RID: 701 RVA: 0x000028D6 File Offset: 0x00000AD6
		[global::Cpp2ILInjected.Token(Token = "0x60002BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCFE0C", Offset = "0x1CCFE0C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PropertyNameTable()
		{
			throw null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000028D9 File Offset: 0x00000AD9
		[global::Cpp2ILInjected.Token(Token = "0x60002C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCFE5C", Offset = "0x1CCFE5C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolverState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PropertyNameTable()
		{
			throw null;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000028DC File Offset: 0x00000ADC
		[global::Cpp2ILInjected.Token(Token = "0x60002C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCFEC4", Offset = "0x1CCFEC4", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseProperty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyNameTable), Member = "TextEquals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public string Get(char[] key, int start, int length)
		{
			throw null;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000028DF File Offset: 0x00000ADF
		[global::Cpp2ILInjected.Token(Token = "0x60002C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD0098", Offset = "0x1CD0098", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MemberSerialization)
		}, ReturnType = typeof(IList<JsonProperty>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public string Add(string key)
		{
			throw null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000028E2 File Offset: 0x00000AE2
		[global::Cpp2ILInjected.Token(Token = "0x60002C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD022C", Offset = "0x1CD022C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyNameTable), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private string AddEntry(string str, int hashCode)
		{
			throw null;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000028E5 File Offset: 0x00000AE5
		[global::Cpp2ILInjected.Token(Token = "0x60002C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD0350", Offset = "0x1CD0350", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyNameTable), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Grow()
		{
			throw null;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000028E8 File Offset: 0x00000AE8
		[global::Cpp2ILInjected.Token(Token = "0x60002C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD0018", Offset = "0x1CD0018", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyNameTable), Member = "Get", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			throw null;
		}

		// Token: 0x0400015D RID: 349
		[global::Cpp2ILInjected.Token(Token = "0x4000177")]
		private static readonly int HashCodeRandomizer;

		// Token: 0x0400015E RID: 350
		[global::Cpp2ILInjected.Token(Token = "0x4000178")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _count;

		// Token: 0x0400015F RID: 351
		[global::Cpp2ILInjected.Token(Token = "0x4000179")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private PropertyNameTable.Entry[] _entries;

		// Token: 0x04000160 RID: 352
		[global::Cpp2ILInjected.Token(Token = "0x400017A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _mask;

		// Token: 0x020000F5 RID: 245
		[global::Cpp2ILInjected.Token(Token = "0x2000043")]
		private class Entry
		{
			// Token: 0x06000A88 RID: 2696 RVA: 0x00003F14 File Offset: 0x00002114
			[global::Cpp2ILInjected.Token(Token = "0x60002C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD0310", Offset = "0x1CD0310", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal Entry(string value, int hashCode, PropertyNameTable.Entry next)
			{
				throw null;
			}

			// Token: 0x0400037E RID: 894
			[global::Cpp2ILInjected.Token(Token = "0x400017B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal readonly string Value;

			// Token: 0x0400037F RID: 895
			[global::Cpp2ILInjected.Token(Token = "0x400017C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal readonly int HashCode;

			// Token: 0x04000380 RID: 896
			[global::Cpp2ILInjected.Token(Token = "0x400017D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal PropertyNameTable.Entry Next;
		}
	}
}
