using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ObjectData;

namespace Terraria.DataStructures
{
	// Token: 0x02000440 RID: 1088
	[global::Cpp2ILInjected.Token(Token = "0x200063B")]
	public struct PlacementHook
	{
		// Token: 0x0600312C RID: 12588 RVA: 0x0002ACB6 File Offset: 0x00028EB6
		[global::Cpp2ILInjected.Token(Token = "0x6003649")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD8F8", Offset = "0x13DD8F8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		public PlacementHook(Func<int, int, int, int, int, int, int> hook, int badReturn, int badResponse, bool processedCoordinates)
		{
			throw null;
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x0002ACB9 File Offset: 0x00028EB9
		[global::Cpp2ILInjected.Token(Token = "0x600364A")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD90C", Offset = "0x13DD90C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(bool))]
		public static bool operator ==(PlacementHook first, PlacementHook second)
		{
			throw null;
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x0002ACBC File Offset: 0x00028EBC
		[global::Cpp2ILInjected.Token(Token = "0x600364B")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD978", Offset = "0x13DD978", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(bool))]
		public static bool operator !=(PlacementHook first, PlacementHook second)
		{
			throw null;
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x0002ACBF File Offset: 0x00028EBF
		[global::Cpp2ILInjected.Token(Token = "0x600364C")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD9E0", Offset = "0x13DD9E0", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x0002ACC2 File Offset: 0x00028EC2
		[global::Cpp2ILInjected.Token(Token = "0x600364D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DDAD4", Offset = "0x13DDAD4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x0002ACC5 File Offset: 0x00028EC5
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600364E")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DDB40", Offset = "0x13DDB40", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PlacementHook()
		{
			throw null;
		}

		// Token: 0x04006317 RID: 25367
		[global::Cpp2ILInjected.Token(Token = "0x4007701")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Func<int, int, int, int, int, int, int> hook;

		// Token: 0x04006318 RID: 25368
		[global::Cpp2ILInjected.Token(Token = "0x4007702")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int badReturn;

		// Token: 0x04006319 RID: 25369
		[global::Cpp2ILInjected.Token(Token = "0x4007703")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int badResponse;

		// Token: 0x0400631A RID: 25370
		[global::Cpp2ILInjected.Token(Token = "0x4007704")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool processedCoordinates;

		// Token: 0x0400631B RID: 25371
		[global::Cpp2ILInjected.Token(Token = "0x4007705")]
		public static PlacementHook Empty;

		// Token: 0x0400631C RID: 25372
		[global::Cpp2ILInjected.Token(Token = "0x4007706")]
		public const int Response_AllInvalid = 0;
	}
}
