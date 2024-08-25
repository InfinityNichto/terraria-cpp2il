using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ObjectData;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200063B")]
	public struct PlacementHook
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003649")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD8F8", Offset = "0x13DD8F8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		public PlacementHook(Func<int, int, int, int, int, int, int> hook, int badReturn, int badResponse, bool processedCoordinates)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600364D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DDAD4", Offset = "0x13DDAD4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600364E")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DDB40", Offset = "0x13DDB40", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PlacementHook()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007701")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Func<int, int, int, int, int, int, int> hook;

		[global::Cpp2ILInjected.Token(Token = "0x4007702")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int badReturn;

		[global::Cpp2ILInjected.Token(Token = "0x4007703")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int badResponse;

		[global::Cpp2ILInjected.Token(Token = "0x4007704")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool processedCoordinates;

		[global::Cpp2ILInjected.Token(Token = "0x4007705")]
		public static PlacementHook Empty;

		[global::Cpp2ILInjected.Token(Token = "0x4007706")]
		public const int Response_AllInvalid = 0;
	}
}
