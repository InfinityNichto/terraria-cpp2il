using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.ID
{
	// Token: 0x020003FC RID: 1020
	[global::Cpp2ILInjected.Token(Token = "0x20005E5")]
	public static class PlayerVariantID
	{
		// Token: 0x0600306C RID: 12396 RVA: 0x0002AA8E File Offset: 0x00028C8E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003570")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C7AE8", Offset = "0x13C7AE8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PlayerVariantID()
		{
			throw null;
		}

		// Token: 0x040055D3 RID: 21971
		[global::Cpp2ILInjected.Token(Token = "0x40068DE")]
		public const int MaleStarter = 0;

		// Token: 0x040055D4 RID: 21972
		[global::Cpp2ILInjected.Token(Token = "0x40068DF")]
		public const int MaleSticker = 1;

		// Token: 0x040055D5 RID: 21973
		[global::Cpp2ILInjected.Token(Token = "0x40068E0")]
		public const int MaleGangster = 2;

		// Token: 0x040055D6 RID: 21974
		[global::Cpp2ILInjected.Token(Token = "0x40068E1")]
		public const int MaleCoat = 3;

		// Token: 0x040055D7 RID: 21975
		[global::Cpp2ILInjected.Token(Token = "0x40068E2")]
		public const int FemaleStarter = 4;

		// Token: 0x040055D8 RID: 21976
		[global::Cpp2ILInjected.Token(Token = "0x40068E3")]
		public const int FemaleSticker = 5;

		// Token: 0x040055D9 RID: 21977
		[global::Cpp2ILInjected.Token(Token = "0x40068E4")]
		public const int FemaleGangster = 6;

		// Token: 0x040055DA RID: 21978
		[global::Cpp2ILInjected.Token(Token = "0x40068E5")]
		public const int FemaleCoat = 7;

		// Token: 0x040055DB RID: 21979
		[global::Cpp2ILInjected.Token(Token = "0x40068E6")]
		public const int MaleDress = 8;

		// Token: 0x040055DC RID: 21980
		[global::Cpp2ILInjected.Token(Token = "0x40068E7")]
		public const int FemaleDress = 9;

		// Token: 0x040055DD RID: 21981
		[global::Cpp2ILInjected.Token(Token = "0x40068E8")]
		public const int MaleDisplayDoll = 10;

		// Token: 0x040055DE RID: 21982
		[global::Cpp2ILInjected.Token(Token = "0x40068E9")]
		public const int FemaleDisplayDoll = 11;

		// Token: 0x040055DF RID: 21983
		[global::Cpp2ILInjected.Token(Token = "0x40068EA")]
		public static readonly int Count;

		// Token: 0x02000923 RID: 2339
		[global::Cpp2ILInjected.Token(Token = "0x20005E6")]
		public class Sets
		{
			// Token: 0x06004C7E RID: 19582 RVA: 0x0002F8A3 File Offset: 0x0002DAA3
			[global::Cpp2ILInjected.Token(Token = "0x6003571")]
			[global::Cpp2ILInjected.Address(RVA = "0x13C7B34", Offset = "0x13C7B34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Sets()
			{
				throw null;
			}

			// Token: 0x06004C7F RID: 19583 RVA: 0x0002F8A6 File Offset: 0x0002DAA6
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

			// Token: 0x04008A0D RID: 35341
			[global::Cpp2ILInjected.Token(Token = "0x40068EB")]
			public static SetFactory Factory;

			// Token: 0x04008A0E RID: 35342
			[global::Cpp2ILInjected.Token(Token = "0x40068EC")]
			public static bool[] Male;

			// Token: 0x04008A0F RID: 35343
			[global::Cpp2ILInjected.Token(Token = "0x40068ED")]
			public static int[] AltGenderReference;

			// Token: 0x04008A10 RID: 35344
			[global::Cpp2ILInjected.Token(Token = "0x40068EE")]
			public static int[] VariantOrderMale;

			// Token: 0x04008A11 RID: 35345
			[global::Cpp2ILInjected.Token(Token = "0x40068EF")]
			public static int[] VariantOrderFemale;
		}
	}
}
