using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x0200053B RID: 1339
	[global::Cpp2ILInjected.Token(Token = "0x2000659")]
	[global::System.Serializable]
	internal class ByteEqualityComparer : EqualityComparer<byte>
	{
		// Token: 0x06002D0A RID: 11530 RVA: 0x0001C277 File Offset: 0x0001A477
		[global::Cpp2ILInjected.Token(Token = "0x600319B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15114", Offset = "0x1C15114", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool Equals(byte x, byte y)
		{
			throw null;
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x0001C27A File Offset: 0x0001A47A
		[global::Cpp2ILInjected.Token(Token = "0x600319C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15124", Offset = "0x1C15124", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode(byte b)
		{
			throw null;
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x0001C27D File Offset: 0x0001A47D
		[global::Cpp2ILInjected.Token(Token = "0x600319D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15140", Offset = "0x1C15140", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "IndexOfByte", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal unsafe override int IndexOf(byte[] array, byte value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x0001C280 File Offset: 0x0001A480
		[global::Cpp2ILInjected.Token(Token = "0x600319E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C152C0", Offset = "0x1C152C0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override int LastIndexOf(byte[] array, byte value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x0001C283 File Offset: 0x0001A483
		[global::Cpp2ILInjected.Token(Token = "0x600319F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C152F8", Offset = "0x1C152F8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x0001C286 File Offset: 0x0001A486
		[global::Cpp2ILInjected.Token(Token = "0x60031A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15370", Offset = "0x1C15370", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x0001C289 File Offset: 0x0001A489
		[global::Cpp2ILInjected.Token(Token = "0x60031A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15398", Offset = "0x1C15398", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EqualityComparer<>), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EqualityComparer<byte>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ByteEqualityComparer()
		{
			throw null;
		}
	}
}
