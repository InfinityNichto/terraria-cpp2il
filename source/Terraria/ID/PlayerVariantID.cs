using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.ID
{
	[global::Cpp2ILInjected.Token(Token = "0x20005E5")]
	public static class PlayerVariantID
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003570")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C7AE8", Offset = "0x13C7AE8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PlayerVariantID()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40068DE")]
		public const int MaleStarter = 0;

		[global::Cpp2ILInjected.Token(Token = "0x40068DF")]
		public const int MaleSticker = 1;

		[global::Cpp2ILInjected.Token(Token = "0x40068E0")]
		public const int MaleGangster = 2;

		[global::Cpp2ILInjected.Token(Token = "0x40068E1")]
		public const int MaleCoat = 3;

		[global::Cpp2ILInjected.Token(Token = "0x40068E2")]
		public const int FemaleStarter = 4;

		[global::Cpp2ILInjected.Token(Token = "0x40068E3")]
		public const int FemaleSticker = 5;

		[global::Cpp2ILInjected.Token(Token = "0x40068E4")]
		public const int FemaleGangster = 6;

		[global::Cpp2ILInjected.Token(Token = "0x40068E5")]
		public const int FemaleCoat = 7;

		[global::Cpp2ILInjected.Token(Token = "0x40068E6")]
		public const int MaleDress = 8;

		[global::Cpp2ILInjected.Token(Token = "0x40068E7")]
		public const int FemaleDress = 9;

		[global::Cpp2ILInjected.Token(Token = "0x40068E8")]
		public const int MaleDisplayDoll = 10;

		[global::Cpp2ILInjected.Token(Token = "0x40068E9")]
		public const int FemaleDisplayDoll = 11;

		[global::Cpp2ILInjected.Token(Token = "0x40068EA")]
		public static readonly int Count;

		[global::Cpp2ILInjected.Token(Token = "0x20005E6")]
		public class Sets
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003571")]
			[global::Cpp2ILInjected.Address(RVA = "0x13C7B34", Offset = "0x13C7B34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Sets()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003572")]
			[global::Cpp2ILInjected.Address(RVA = "0x13C7B3C", Offset = "0x13C7B3C", Length = "0x1D0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int[])
			}, ReturnType = typeof(bool[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateIntSet", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int[])
			}, ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			static Sets()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40068EB")]
			public static SetFactory Factory;

			[global::Cpp2ILInjected.Token(Token = "0x40068EC")]
			public static bool[] Male;

			[global::Cpp2ILInjected.Token(Token = "0x40068ED")]
			public static int[] AltGenderReference;

			[global::Cpp2ILInjected.Token(Token = "0x40068EE")]
			public static int[] VariantOrderMale;

			[global::Cpp2ILInjected.Token(Token = "0x40068EF")]
			public static int[] VariantOrderFemale;
		}
	}
}
